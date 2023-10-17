using System;
using System.Collections.Generic;
using System.Windows.Forms;

using Diary.Classes;

namespace Diary.Forms
{
    public partial class FormEntity : Form
    {
        public Entity EditedEntity;

        public FormEntity()
        {
            InitializeComponent();

            EditedEntity = new Entity();
        }

        public FormEntity(Entity entity)
        {
            InitializeComponent();

            EditedEntity = entity;

            tbCaption.Text = entity.Caption;

            tbText.Text = "";
            entity.Text.ForEach(t => tbText.Text += (tbText.Text.Length > 0 ? Environment.NewLine : "") + t);
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            EditedEntity.Caption = tbCaption.Text;
            //EditedEntity.Text = tbText.Text.Replace("\r\n", "&#13");

            List<string> text = new List<string>();
            foreach (String line in tbText.Lines)
                text.Add(line.Trim());
            EditedEntity.Text = text;

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}