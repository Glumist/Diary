using System;
using System.Windows.Forms;

using Diary.Classes;

namespace Diary.Forms
{
    public partial class FormTag : Form
    {
        public Tag EditedTag;

        public FormTag()
        {
            InitializeComponent();

            EditedTag = new Tag();
        }

        public FormTag(Tag item)
        {
            InitializeComponent();

            EditedTag = item;

            tbItemName.Text = item.Name;
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            EditedTag.Name = tbItemName.Text;

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}