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
            record.Tags.ForEach(t => tbTags.Text += (tbTags.Text.Length > 0 ? Environment.NewLine : "") + t);

            tbText.Text = "";
            record.Text.ForEach(t => tbText.Text += (tbText.Text.Length > 0 ? Environment.NewLine : "") + t);

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
            EditedRecord.Caption = tbCaption.Text;
            EditedRecord.Entities = _entities;
            EditedRecord.Date = dtpDate.Value;

            List<string> tags = new List<string>();
            foreach (String line in tbTags.Lines)
                if (line.Trim().Length > 0)
                    tags.Add(line.Trim());
            EditedRecord.Tags = tags;

            List<string> text = new List<string>();
            foreach (String line in tbText.Lines)
                text.Add(line.Trim());
            EditedRecord.Text = text;

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
