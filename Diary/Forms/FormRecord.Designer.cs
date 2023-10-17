namespace Diary.Forms
{
    partial class FormRecord
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRecord));
            this.btCancel = new System.Windows.Forms.Button();
            this.btOk = new System.Windows.Forms.Button();
            this.tbText = new System.Windows.Forms.TextBox();
            this.tbCaption = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.scMain = new System.Windows.Forms.SplitContainer();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.scLinked = new System.Windows.Forms.SplitContainer();
            this.tbTags = new System.Windows.Forms.TextBox();
            this.msTags = new System.Windows.Forms.MenuStrip();
            this.tsmiTagAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvEntities = new System.Windows.Forms.DataGridView();
            this.colEntityCaption = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.msEntities = new System.Windows.Forms.MenuStrip();
            this.tsmiEntityAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEntityRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.rbNothing = new System.Windows.Forms.RadioButton();
            this.rbNoEmotion = new System.Windows.Forms.RadioButton();
            this.rbPlusMinus = new System.Windows.Forms.RadioButton();
            this.rbDoublePlus = new System.Windows.Forms.RadioButton();
            this.rbPlus = new System.Windows.Forms.RadioButton();
            this.rbMinus = new System.Windows.Forms.RadioButton();
            this.rbDoubleMinus = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).BeginInit();
            this.scMain.Panel1.SuspendLayout();
            this.scMain.Panel2.SuspendLayout();
            this.scMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scLinked)).BeginInit();
            this.scLinked.Panel1.SuspendLayout();
            this.scLinked.Panel2.SuspendLayout();
            this.scLinked.SuspendLayout();
            this.msTags.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntities)).BeginInit();
            this.msEntities.SuspendLayout();
            this.SuspendLayout();
            // 
            // btCancel
            // 
            this.btCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancel.Location = new System.Drawing.Point(357, 385);
            this.btCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(112, 35);
            this.btCancel.TabIndex = 4;
            this.btCancel.Text = "Отмена";
            this.btCancel.UseVisualStyleBackColor = true;
            // 
            // btOk
            // 
            this.btOk.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btOk.Location = new System.Drawing.Point(235, 385);
            this.btOk.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(112, 35);
            this.btOk.TabIndex = 3;
            this.btOk.Text = "ОК";
            this.btOk.UseVisualStyleBackColor = true;
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // tbText
            // 
            this.tbText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbText.Location = new System.Drawing.Point(9, 142);
            this.tbText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbText.Multiline = true;
            this.tbText.Name = "tbText";
            this.tbText.Size = new System.Drawing.Size(452, 222);
            this.tbText.TabIndex = 2;
            // 
            // tbCaption
            // 
            this.tbCaption.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCaption.Location = new System.Drawing.Point(9, 38);
            this.tbCaption.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbCaption.Name = "tbCaption";
            this.tbCaption.Size = new System.Drawing.Size(278, 26);
            this.tbCaption.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 115);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Текст";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Заголовок";
            // 
            // scMain
            // 
            this.scMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scMain.Location = new System.Drawing.Point(0, 0);
            this.scMain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.scMain.Name = "scMain";
            // 
            // scMain.Panel1
            // 
            this.scMain.Panel1.Controls.Add(this.rbDoubleMinus);
            this.scMain.Panel1.Controls.Add(this.rbMinus);
            this.scMain.Panel1.Controls.Add(this.rbPlus);
            this.scMain.Panel1.Controls.Add(this.rbDoublePlus);
            this.scMain.Panel1.Controls.Add(this.rbPlusMinus);
            this.scMain.Panel1.Controls.Add(this.rbNoEmotion);
            this.scMain.Panel1.Controls.Add(this.rbNothing);
            this.scMain.Panel1.Controls.Add(this.dtpDate);
            this.scMain.Panel1.Controls.Add(this.label3);
            this.scMain.Panel1.Controls.Add(this.label1);
            this.scMain.Panel1.Controls.Add(this.label2);
            this.scMain.Panel1.Controls.Add(this.tbCaption);
            this.scMain.Panel1.Controls.Add(this.tbText);
            // 
            // scMain.Panel2
            // 
            this.scMain.Panel2.Controls.Add(this.scLinked);
            this.scMain.Size = new System.Drawing.Size(704, 371);
            this.scMain.SplitterDistance = 467;
            this.scMain.SplitterWidth = 9;
            this.scMain.TabIndex = 0;
            // 
            // dtpDate
            // 
            this.dtpDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDate.CustomFormat = "dd.MM.yy HH:mm";
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(297, 42);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(164, 26);
            this.dtpDate.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(293, 17);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Дата";
            // 
            // scLinked
            // 
            this.scLinked.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scLinked.Location = new System.Drawing.Point(0, 0);
            this.scLinked.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.scLinked.Name = "scLinked";
            this.scLinked.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scLinked.Panel1
            // 
            this.scLinked.Panel1.Controls.Add(this.tbTags);
            this.scLinked.Panel1.Controls.Add(this.msTags);
            // 
            // scLinked.Panel2
            // 
            this.scLinked.Panel2.Controls.Add(this.dgvEntities);
            this.scLinked.Panel2.Controls.Add(this.msEntities);
            this.scLinked.Size = new System.Drawing.Size(228, 371);
            this.scLinked.SplitterDistance = 161;
            this.scLinked.SplitterWidth = 9;
            this.scLinked.TabIndex = 0;
            // 
            // tbTags
            // 
            this.tbTags.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbTags.Location = new System.Drawing.Point(0, 34);
            this.tbTags.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbTags.Multiline = true;
            this.tbTags.Name = "tbTags";
            this.tbTags.Size = new System.Drawing.Size(228, 127);
            this.tbTags.TabIndex = 0;
            // 
            // msTags
            // 
            this.msTags.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.msTags.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiTagAdd});
            this.msTags.Location = new System.Drawing.Point(0, 0);
            this.msTags.Name = "msTags";
            this.msTags.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.msTags.Size = new System.Drawing.Size(228, 34);
            this.msTags.TabIndex = 1;
            this.msTags.Text = "menuStrip1";
            // 
            // tsmiTagAdd
            // 
            this.tsmiTagAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsmiTagAdd.Image = global::Diary.Properties.Resources.IconPlus;
            this.tsmiTagAdd.Name = "tsmiTagAdd";
            this.tsmiTagAdd.Size = new System.Drawing.Size(36, 28);
            this.tsmiTagAdd.Text = "Добавить";
            this.tsmiTagAdd.Click += new System.EventHandler(this.tsmiTagAdd_Click);
            // 
            // dgvEntities
            // 
            this.dgvEntities.AllowUserToAddRows = false;
            this.dgvEntities.AllowUserToDeleteRows = false;
            this.dgvEntities.AllowUserToResizeRows = false;
            this.dgvEntities.BackgroundColor = System.Drawing.Color.White;
            this.dgvEntities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEntities.ColumnHeadersVisible = false;
            this.dgvEntities.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colEntityCaption});
            this.dgvEntities.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEntities.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvEntities.Location = new System.Drawing.Point(0, 34);
            this.dgvEntities.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvEntities.MultiSelect = false;
            this.dgvEntities.Name = "dgvEntities";
            this.dgvEntities.RowHeadersVisible = false;
            this.dgvEntities.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEntities.Size = new System.Drawing.Size(228, 167);
            this.dgvEntities.TabIndex = 0;
            // 
            // colEntityCaption
            // 
            this.colEntityCaption.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colEntityCaption.DataPropertyName = "Caption";
            this.colEntityCaption.HeaderText = "Заголовок";
            this.colEntityCaption.Name = "colEntityCaption";
            // 
            // msEntities
            // 
            this.msEntities.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.msEntities.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiEntityAdd,
            this.tsmiEntityRemove});
            this.msEntities.Location = new System.Drawing.Point(0, 0);
            this.msEntities.Name = "msEntities";
            this.msEntities.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.msEntities.Size = new System.Drawing.Size(228, 34);
            this.msEntities.TabIndex = 1;
            this.msEntities.Text = "menuStrip1";
            // 
            // tsmiEntityAdd
            // 
            this.tsmiEntityAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsmiEntityAdd.Image = global::Diary.Properties.Resources.IconPlus;
            this.tsmiEntityAdd.Name = "tsmiEntityAdd";
            this.tsmiEntityAdd.Size = new System.Drawing.Size(36, 28);
            this.tsmiEntityAdd.Text = "Добавить";
            this.tsmiEntityAdd.Click += new System.EventHandler(this.tsmiEntityAdd_Click);
            // 
            // tsmiEntityRemove
            // 
            this.tsmiEntityRemove.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsmiEntityRemove.Image = global::Diary.Properties.Resources.action_delete_sharp_thick;
            this.tsmiEntityRemove.Name = "tsmiEntityRemove";
            this.tsmiEntityRemove.Size = new System.Drawing.Size(36, 28);
            this.tsmiEntityRemove.Text = "Удалить";
            this.tsmiEntityRemove.Click += new System.EventHandler(this.tsmiEntityRemove_Click);
            // 
            // rbNothing
            // 
            this.rbNothing.Checked = true;
            this.rbNothing.Location = new System.Drawing.Point(10, 72);
            this.rbNothing.Name = "rbNothing";
            this.rbNothing.Size = new System.Drawing.Size(55, 40);
            this.rbNothing.TabIndex = 11;
            this.rbNothing.UseVisualStyleBackColor = true;
            // 
            // rbNoEmotion
            // 
            this.rbNoEmotion.Image = global::Diary.Properties.Resources.IconArrowsCenter;
            this.rbNoEmotion.Location = new System.Drawing.Point(58, 72);
            this.rbNoEmotion.Name = "rbNoEmotion";
            this.rbNoEmotion.Size = new System.Drawing.Size(55, 40);
            this.rbNoEmotion.TabIndex = 12;
            this.rbNoEmotion.Text = "    ";
            this.rbNoEmotion.UseVisualStyleBackColor = true;
            // 
            // rbPlusMinus
            // 
            this.rbPlusMinus.Image = global::Diary.Properties.Resources.IconArrows;
            this.rbPlusMinus.Location = new System.Drawing.Point(118, 72);
            this.rbPlusMinus.Name = "rbPlusMinus";
            this.rbPlusMinus.Size = new System.Drawing.Size(55, 40);
            this.rbPlusMinus.TabIndex = 13;
            this.rbPlusMinus.Text = "    ";
            this.rbPlusMinus.UseVisualStyleBackColor = true;
            // 
            // rbDoublePlus
            // 
            this.rbDoublePlus.Image = global::Diary.Properties.Resources.IconArrowUpDouble;
            this.rbDoublePlus.Location = new System.Drawing.Point(180, 72);
            this.rbDoublePlus.Name = "rbDoublePlus";
            this.rbDoublePlus.Size = new System.Drawing.Size(55, 40);
            this.rbDoublePlus.TabIndex = 14;
            this.rbDoublePlus.Text = "    ";
            this.rbDoublePlus.UseVisualStyleBackColor = true;
            // 
            // rbPlus
            // 
            this.rbPlus.Image = global::Diary.Properties.Resources.IconArrowUp;
            this.rbPlus.Location = new System.Drawing.Point(242, 72);
            this.rbPlus.Name = "rbPlus";
            this.rbPlus.Size = new System.Drawing.Size(55, 40);
            this.rbPlus.TabIndex = 15;
            this.rbPlus.Text = "    ";
            this.rbPlus.UseVisualStyleBackColor = true;
            // 
            // rbMinus
            // 
            this.rbMinus.Image = global::Diary.Properties.Resources.IconArrowDown;
            this.rbMinus.Location = new System.Drawing.Point(305, 72);
            this.rbMinus.Name = "rbMinus";
            this.rbMinus.Size = new System.Drawing.Size(55, 40);
            this.rbMinus.TabIndex = 16;
            this.rbMinus.Text = "    ";
            this.rbMinus.UseVisualStyleBackColor = true;
            // 
            // rbDoubleMinus
            // 
            this.rbDoubleMinus.Image = global::Diary.Properties.Resources.IconArrowDownDouble;
            this.rbDoubleMinus.Location = new System.Drawing.Point(366, 72);
            this.rbDoubleMinus.Name = "rbDoubleMinus";
            this.rbDoubleMinus.Size = new System.Drawing.Size(55, 40);
            this.rbDoubleMinus.TabIndex = 17;
            this.rbDoubleMinus.Text = "    ";
            this.rbDoubleMinus.UseVisualStyleBackColor = true;
            // 
            // FormRecord
            // 
            this.AcceptButton = this.btOk;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.CancelButton = this.btCancel;
            this.ClientSize = new System.Drawing.Size(708, 432);
            this.Controls.Add(this.scMain);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btOk);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.msEntities;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormRecord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Запись";
            this.scMain.Panel1.ResumeLayout(false);
            this.scMain.Panel1.PerformLayout();
            this.scMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).EndInit();
            this.scMain.ResumeLayout(false);
            this.scLinked.Panel1.ResumeLayout(false);
            this.scLinked.Panel1.PerformLayout();
            this.scLinked.Panel2.ResumeLayout(false);
            this.scLinked.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scLinked)).EndInit();
            this.scLinked.ResumeLayout(false);
            this.msTags.ResumeLayout(false);
            this.msTags.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntities)).EndInit();
            this.msEntities.ResumeLayout(false);
            this.msEntities.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btOk;
        private System.Windows.Forms.TextBox tbText;
        private System.Windows.Forms.TextBox tbCaption;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer scMain;
        private System.Windows.Forms.SplitContainer scLinked;
        private System.Windows.Forms.DataGridView dgvEntities;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEntityCaption;
        private System.Windows.Forms.MenuStrip msEntities;
        private System.Windows.Forms.ToolStripMenuItem tsmiEntityAdd;
        private System.Windows.Forms.ToolStripMenuItem tsmiEntityRemove;
        private System.Windows.Forms.TextBox tbTags;
        private System.Windows.Forms.MenuStrip msTags;
        private System.Windows.Forms.ToolStripMenuItem tsmiTagAdd;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbDoubleMinus;
        private System.Windows.Forms.RadioButton rbMinus;
        private System.Windows.Forms.RadioButton rbPlus;
        private System.Windows.Forms.RadioButton rbDoublePlus;
        private System.Windows.Forms.RadioButton rbPlusMinus;
        private System.Windows.Forms.RadioButton rbNoEmotion;
        private System.Windows.Forms.RadioButton rbNothing;
    }
}