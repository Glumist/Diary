using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

using Diary.Classes;

namespace Diary.Forms
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
            if (tscbGroup.SelectedIndex == 0)
                AddTag();
            else if (tscbGroup.SelectedIndex == 1)
                AddEntity();
        }

        private void tsmiGroupEdit_Click(object sender, EventArgs e)
        {
            if (tscbGroup.SelectedIndex == 0)
                EditTag();
            else if (tscbGroup.SelectedIndex == 1)
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
            tsmiGroupDelete.Enabled = false;

            tvTags.BringToFront();

            Tag selectedTag = tvTags.SelectedNode != null ? tvTags.SelectedNode.Tag as Tag : null;

            /*List<Entity> tags = new List<Entity>();
            tags.Add(new Entity() { Caption = TAGS_ALL });

            _recordsCollection.GetAllTags().ForEach(t => tags.Add(new Entity() { Caption = t }));

            dgvGroups.DataSource = tags;*/

            tvTags.Nodes.Clear();
            TreeNode allNode = new TreeNode(TAGS_ALL) { Tag = new Tag() { Name = TAGS_ALL } };
            tvTags.Nodes.Add(allNode);

            Dictionary<Tag, TreeNode> tagNodes = new Dictionary<Tag, TreeNode>();
            foreach (Tag tag in RecordsCollection.GetInstance().Tags)
                tagNodes.Add(tag, GetTagNode(tag));
            foreach (Tag tag in RecordsCollection.GetInstance().Tags.FindAll(i => i.Parent != null))
                tagNodes[tag.Parent].Nodes.Add(tagNodes[tag]);
            foreach (Tag tag in RecordsCollection.GetInstance().Tags.FindAll(i => i.Parent == null))
                allNode.Nodes.Add(tagNodes[tag]);

            allNode.Expand();

            if (selectedTag != null && selectedTag.Name != TAGS_ALL)
                tvTags.SelectedNode = tagNodes[selectedTag];
            else
                tvTags.SelectedNode = tvTags.Nodes[0];
        }

        private TreeNode GetTagNode(Tag tag)
        {
            return new TreeNode(tag.Name) { Tag = tag };
        }

        private void tvTags_AfterSelect(object sender, TreeViewEventArgs e)
        {
            RefreshRecordsTable();
        }

        private void AddTag()
        {
            FormTag form = new FormTag();
            if (form.ShowDialog() != DialogResult.OK)
                return;

            _recordsCollection.Add(form.EditedTag);
            Save();
            TreeNode newNode = GetTagNode(form.EditedTag);
            tvTags.Nodes[0].Nodes.Add(newNode);
            tvTags.SelectedNode = newNode;
        }

        private void EditTag()
        {
            Tag selectedTag = tvTags.SelectedNode != null ? tvTags.SelectedNode.Tag as Tag : null;
            if (selectedTag == null || selectedTag.Name == TAGS_ALL)
                return;

            if (new FormTag(selectedTag).ShowDialog() != DialogResult.OK)
                return;

            Save();
            tvTags.SelectedNode.Text = selectedTag.Name;
        }

        /*private string GetSelectedTag()
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
        }*/

        #region DragDrop

        private void tvTags_ItemDrag(object sender, ItemDragEventArgs e)
        {
            if (e.Item is TreeNode && (e.Item as TreeNode).Text != TAGS_ALL)
                DoDragDrop(e.Item, DragDropEffects.All);
        }

        private void tvTags_DragDrop(object sender, DragEventArgs e)
        {
            Point targetPoint = tvTags.PointToClient(new Point(e.X, e.Y));
            TreeNode targetNode = tvTags.GetNodeAt(targetPoint);
            TreeNode draggedNode = (TreeNode)e.Data.GetData(typeof(TreeNode));

            if (draggedNode != targetNode)
                MoveNode(draggedNode, targetNode);
            e.Effect = DragDropEffects.None;
        }

        private void MoveNode(TreeNode nodeToMove, TreeNode newParent)
        {
            nodeToMove.Remove();

            if (newParent != null && newParent.Text != TAGS_ALL)
            {
                newParent.Nodes.Add(nodeToMove);
                ((Tag)nodeToMove.Tag).Parent = (Tag)newParent.Tag;
            }
            else
            {
                tvTags.Nodes[0].Nodes.Add(nodeToMove);
                ((Tag)nodeToMove.Tag).Parent = null;
                ((Tag)nodeToMove.Tag).ParentId = -1;
            }
            RecordsCollection.GetInstance().Save();
        }

        private void tvTags_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        #endregion

        private bool IsTagReal(string tag)
        {
            return tag != TAGS_ALL;
        }

        #endregion

        #region Entities

        private void RefreshEntities()
        {
            dgvGroups.BringToFront();

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
            List<Record> filteredRecords = new List<Record>(_recordsCollection.Records);
            if (!string.IsNullOrWhiteSpace(tstbFilter.Text))
                filteredRecords.RemoveAll(fr => !fr.Caption.ToLower().Contains(tstbFilter.Text.ToLower()));

            switch (tscbGroup.SelectedIndex)
            {
                case 0:
                    Tag selectedTag = tvTags.SelectedNode != null ? tvTags.SelectedNode.Tag as Tag : null;
                    if (selectedTag != null && selectedTag.Name != TAGS_ALL)
                    {
                        List<Tag> selectedTags = RecordsCollection.GetSubTags(selectedTag);
                        filteredRecords = filteredRecords.FindAll(r => r.TagList.Exists(t => selectedTags.Contains(t)));
                    }
                    break;
                case 1:
                    Entity selectedEntity = GetSelectedEntity();
                    if (selectedEntity != null)
                        filteredRecords = filteredRecords.FindAll(g => g.Entities.Contains(selectedEntity));
                    break;
                default:
                    break;
            }

            dgvRecords.DataSource = filteredRecords;
            dgvRecords.ClearSelection();
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

        private void tsmiRecordCopy_Click(object sender, EventArgs e)
        {
            Record selectedRecord = GetSelectedRecord();
            if (selectedRecord == null)
                return;

            Record newRecord = new Record()
            {
                Caption = selectedRecord.Caption,
                Date = DateTime.Now,
                Entities = new List<Entity>(selectedRecord.Entities),
                Tags = new List<string>(selectedRecord.Tags),
                TagList = new List<Tag>(selectedRecord.TagList),
                Text = selectedRecord.Text
            };


            if (new FormRecord(newRecord).ShowDialog() != DialogResult.OK)
                return;

            _recordsCollection.Add(newRecord);
            Save();
            RefreshGroupTable();

            SelectRecord(newRecord);
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

        private void tstbFilter_TextChanged(object sender, EventArgs e)
        {
            RefreshRecordsTable();
        }

        #endregion
    }
}