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
    public partial class FormChoice : Form
    {
        public Entity SelectedEntity;
        public string SelectedTag;
        private Selection _selection;
        private RecordsCollection _recordsCollection;

        public FormChoice(Selection selection)
        {
            InitializeComponent();

            _selection = selection;
            _recordsCollection = RecordsCollection.GetInstance();

            if (selection == Selection.Entity)
                Text += "сущность";
            else if (selection == Selection.Tag)
            {
                Text += "тэг";
                btAdd.Visible = false;
                cbChoice.Width += 30;
            }
            RefreshChoice();
        }

        private void RefreshChoice()
        {
            cbChoice.Items.Clear();
            if (_selection == Selection.Entity)
                foreach (Entity bundle in _recordsCollection.Entities)
                    cbChoice.Items.Add(bundle);
            else if (_selection == Selection.Tag)
                foreach (string tag in _recordsCollection.GetAllTags())
                    cbChoice.Items.Add(tag);
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            if (_selection == Selection.Entity)
            {
                FormEntity form = new FormEntity();
                if (form.ShowDialog() != DialogResult.OK)
                    return;

                _recordsCollection.Add(form.EditedEntity);
                _recordsCollection.Save();
                RefreshChoice();
                cbChoice.SelectedItem = form.EditedEntity;
            }
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            switch (_selection)
            {
                case Selection.Entity: SelectedEntity = (Entity)cbChoice.SelectedItem; break;
                case Selection.Tag: SelectedTag = cbChoice.Text; break;
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        public enum Selection
        {
            Entity,
            Tag
        }
    }
}
