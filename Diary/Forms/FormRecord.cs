using System;
using System.Collections.Generic;
using System.Windows.Forms;

using Diary.Classes;

namespace Diary.Forms
{
    public partial class FormRecord : Form
    {
        public Record EditedRecord;
        private List<Entity> _entities;

        public FormRecord()
        {
            InitializeComponent();

            EditedRecord = new Record();
            _entities = new List<Entity>();
            Init();
        }
        
        public FormRecord(Record record)
        {
            InitializeComponent();

            EditedRecord = record;

            tbCaption.Text = record.Caption;
            dtpDate.Value = record.Date;

            tbTags.Text = "";
            record.TagList.ForEach(t => tbTags.Text += (tbTags.Text.Length > 0 ? Environment.NewLine : "") + t.Name);

            tbText.Text = "";
            record.Text.ForEach(t => tbText.Text += (tbText.Text.Length > 0 ? Environment.NewLine : "") + t);

            switch (record.Emotion)
            {
                case "0": rbNoEmotion.Checked = true; break;
                case "+-": rbPlusMinus.Checked = true; break;
                case "+": rbPlus.Checked = true; break;
                case "++": rbDoublePlus.Checked = true; break;
                case "-": rbMinus.Checked = true; break;
                case "--": rbDoubleMinus.Checked = true; break;
            }

            _entities = new List<Entity>(record.Entities);
            Init();
        }

        private void Init()
        {
            dgvEntities.AutoGenerateColumns = false;
            dgvEntities.DataSource = _entities;
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            RecordsCollection recordsCollection = RecordsCollection.GetInstance();

            EditedRecord.Caption = tbCaption.Text;
            EditedRecord.Entities = _entities;
            EditedRecord.Date = dtpDate.Value;

            List<Tag> tags = new List<Tag>();
            foreach (string line in tbTags.Lines)
            {
                string tagText = line.Trim();
                if (tagText.Length == 0)
                    continue;

                Tag tag = recordsCollection.Tags.Find(t => t.Name == tagText);
                if (tag == null)
                {
                    tag = new Tag() { Name = tagText };
                    recordsCollection.Add(tag);
                }

                tags.Add(tag);
            }
            EditedRecord.TagList = tags;

            List<string> text = new List<string>();
            foreach (String line in tbText.Lines)
                text.Add(line.Trim());
            EditedRecord.Text = text;

            if (rbNothing.Checked)
                EditedRecord.Emotion = "";
            else if (rbNoEmotion.Checked)
                EditedRecord.Emotion = "0";
            else if (rbPlusMinus.Checked)
                EditedRecord.Emotion = "+-";
            else if (rbPlus.Checked)
                EditedRecord.Emotion = "+";
            else if (rbDoublePlus.Checked)
                EditedRecord.Emotion = "++";
            else if (rbMinus.Checked)
                EditedRecord.Emotion = "-";
            else if (rbDoubleMinus.Checked)
                EditedRecord.Emotion = "--";

            DialogResult = DialogResult.OK;
            Close();
        }

        private void tsmiTagAdd_Click(object sender, EventArgs e)
        {
            FormChoice form = new FormChoice(FormChoice.Selection.Tag);
            if (form.ShowDialog() != DialogResult.OK)
                return;

            tbTags.Text += Environment.NewLine + form.SelectedTag;
        }

        private void tsmiEntityAdd_Click(object sender, EventArgs e)
        {
            FormChoice form = new FormChoice(FormChoice.Selection.Entity);
            if (form.ShowDialog() != DialogResult.OK)
                return;

            _entities.Add(form.SelectedEntity);
            dgvEntities.DataSource = new List<Entity>(_entities);
        }

        private void tsmiEntityRemove_Click(object sender, EventArgs e)
        {
            if (dgvEntities.SelectedRows.Count == 0 || dgvEntities.SelectedRows[0].Index == -1)
                return;

            Entity selectedEntity = dgvEntities.SelectedRows[0].DataBoundItem as Entity;

            if (selectedEntity == null)
                return;

            _entities.Remove(selectedEntity);
            dgvEntities.DataSource = new List<Entity>(_entities);
        }
    }
}