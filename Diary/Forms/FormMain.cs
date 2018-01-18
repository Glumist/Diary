using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diary
{
    public partial class FormMain : Form
    {
        RecordsCollection _recordsCollection;
        private const string TAGS_ALL = "Все";

        public FormMain()
        {
            InitializeComponent();

            dgvGroups.AutoGenerateColumns = false;
            dgvRecords.AutoGenerateColumns = false;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            _recordsCollection = RecordsCollection.GetInstance();

            tscbGroup.SelectedIndex = 0;
        }

        private void Save()
        {
            if (!_recordsCollection.Save())
                MessageBox.Show("Ошибка при сохранении!");
        }

        #region Groups

        private void RefreshGroupTable()
        {
            tsmiGroupAdd.Enabled = true;
            tsmiGroupEdit.Enabled = true;
            tsmiGroupDelete.Enabled = true;

            switch (tscbGroup.SelectedIndex)
            {
                case 0: RefreshTags(); break;
                case 1: RefreshEntities(); break;
            }
        }

        private void tscbGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshGroupTable();
        }

        private void tsmiGroupAdd_Click(object sender, EventArgs e)
        {
            if (tscbGroup.SelectedIndex == 1)
                AddEntity();
        }

        private void tsmiGroupEdit_Click(object sender, EventArgs e)
        {
            if (tscbGroup.SelectedIndex == 1)
                EditEntity();
        }

        private void tsmiGroupDelete_Click(object sender, EventArgs e)
        {
            if (tscbGroup.SelectedIndex == 1)
                DeleteEntity();
        }

        private void dgvGroups_SelectionChanged(object sender, EventArgs e)
        {
            RefreshRecordsTable();
        }

        #region Tags

        private void RefreshTags()
        {
            tsmiGroupAdd.Enabled = false;
            tsmiGroupEdit.Enabled = false;
            tsmiGroupDelete.Enabled = false;

            string selectedTag = GetSelectedTag();

            List<Entity> tags = new List<Entity>();
            tags.Add(new Entity() { Caption = TAGS_ALL });

            _recordsCollection.GetAllTags().ForEach(t => tags.Add(new Entity() { Caption = t }));

            dgvGroups.DataSource = tags;

            if (selectedTag != null)
                SelectTag(selectedTag);
        }

        private string GetSelectedTag()
        {
            if (dgvGroups.SelectedRows.Count == 0 || dgvGroups.SelectedRows[0].Index == -1)
                return null;

            return (dgvGroups.SelectedRows[0].DataBoundItem as Entity).Caption;
        }

        private void SelectTag(string tag)
        {
            if (tscbGroup.SelectedIndex != 1)
                return;

            foreach (DataGridViewRow row in dgvGroups.Rows)
            {
                Entity rowTag;

                if (row.DataBoundItem is Entity)
                    rowTag = row.DataBoundItem as Entity;
                else
                    continue;

                if (rowTag.Caption == tag)
                {
                    row.Selected = true;
                    dgvGroups.FirstDisplayedScrollingRowIndex = row.Index;
                    break;
                }
            }
        }

        private bool IsTagReal(string tag)
        {
            return tag != TAGS_ALL;
        }

        #endregion

        #region Entities

        private void RefreshEntities()
        {
            Entity selectedEntity = GetSelectedEntity();

            dgvGroups.DataSource = new List<Entity>(_recordsCollection.Entities);

            if (selectedEntity != null)
                SelectEntity(selectedEntity);
        }

        private void AddEntity()
        {
            FormEntity form = new FormEntity();
            if (form.ShowDialog() != DialogResult.OK)
                return;

            _recordsCollection.Add(form.EditedEntity);
            Save();
            RefreshGroupTable();
            SelectEntity(form.EditedEntity);
        }

        private void EditEntity()
        {
            Entity selectedEntity = GetSelectedEntity();
            if (selectedEntity == null)
                return;

            if (new FormEntity(selectedEntity).ShowDialog() != DialogResult.OK)
                return;

            Save();
            RefreshGroupTable();
            SelectEntity(selectedEntity);
        }

        private void DeleteEntity()
        {
            Entity selectedEntity = GetSelectedEntity();
            if (selectedEntity == null)
                return;

            if (MessageBox.Show("Вы дейтсвительно хотите удалить " + selectedEntity.ToString() + "?", "Удаление", MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;

            _recordsCollection.Entities.Remove(selectedEntity);
            Save();
            RefreshGroupTable();
        }

        private Entity GetSelectedEntity()
        {
            if (dgvGroups.SelectedRows.Count == 0 || dgvGroups.SelectedRows[0].Index == -1)
                return null;

            return dgvGroups.SelectedRows[0].DataBoundItem as Entity;
        }

        private void SelectEntity(Entity entity)
        {
            if (tscbGroup.SelectedIndex != 1)
                return;

            foreach (DataGridViewRow row in dgvGroups.Rows)
            {
                Entity rowEntity;

                if (row.DataBoundItem is Entity)
                    rowEntity = row.DataBoundItem as Entity;
                else
                    continue;

                if (rowEntity == entity)
                {
                    row.Selected = true;
                    dgvGroups.FirstDisplayedScrollingRowIndex = row.Index;
                    break;
                }
            }
        }

        #endregion

        #endregion

        #region Records

        private void RefreshRecordsTable()
        {
            switch (tscbGroup.SelectedIndex)
            {
                case 0:
                    string selectedTag = GetSelectedTag();
                    if (selectedTag != null)
                        ShowRecordsByTag(selectedTag);
                    break;
                case 1:
                    Entity selectedEntity = GetSelectedEntity();
                    if (selectedEntity != null)
                        ShowRecordsByEntity(selectedEntity);
                    break;
                default:
                    dgvRecords.DataSource = new List<Record>(_recordsCollection.Records);
                    break;
            }

            dgvRecords.ClearSelection();
        }

        private void ShowRecordsByTag(string tag)
        {
            if (tag == TAGS_ALL)
                dgvRecords.DataSource = new List<Record>(_recordsCollection.Records);
            else
                dgvRecords.DataSource = _recordsCollection.Records.FindAll(r => r.Tags.Contains(tag));
        }

        private void ShowRecordsByEntity(Entity entity)
        {
            dgvRecords.DataSource = new List<Record>(_recordsCollection.Records.FindAll(g => g.Entities.Contains(entity)));
        }

        private void tsmiRecordAdd_Click(object sender, EventArgs e)
        {
            FormRecord form = new FormRecord();
            if (form.ShowDialog() != DialogResult.OK)
                return;

            _recordsCollection.Add(form.EditedRecord);
            Save();
            RefreshGroupTable();

            SelectRecord(form.EditedRecord);
        }

        private void tsmiRecordEdit_Click(object sender, EventArgs e)
        {
            Record selectedRecord = GetSelectedRecord();
            if (selectedRecord == null)
                return;

            DateTime recordDate = selectedRecord.Date;
            if (new FormRecord(selectedRecord).ShowDialog() != DialogResult.OK)
                return;

            if (recordDate != selectedRecord.Date)
                _recordsCollection.Records.Sort(Record.CompareByDate);
            Save();
            RefreshGroupTable();
            SelectRecord(selectedRecord);
        }

        private void tsmiRecordDelete_Click(object sender, EventArgs e)
        {
            Record selectedRecord = GetSelectedRecord();
            if (selectedRecord == null)
                return;

            if (MessageBox.Show("Вы дейтсвительно хотите удалить " + selectedRecord.ToString() + "?", "Удаление", MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;

            _recordsCollection.Records.Remove(selectedRecord);
            Save();
            RefreshGroupTable();
        }

        private Record GetSelectedRecord()
        {
            if (dgvRecords.SelectedRows.Count == 0 || dgvRecords.SelectedRows[0].Index == -1)
                return null;

            return dgvRecords.SelectedRows[0].DataBoundItem as Record;
        }

        private void SelectRecord(Record record)
        {
            foreach (DataGridViewRow row in dgvRecords.Rows)
            {
                Record rowGame;

                if (row.DataBoundItem is Record)
                    rowGame = row.DataBoundItem as Record;
                else
                    continue;

                if (rowGame == record)
                {
                    row.Selected = true;
                    dgvRecords.FirstDisplayedScrollingRowIndex = row.Index;
                    break;
                }
            }
        }

        #endregion
    }
}
