namespace Diary
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
            this.scLinked = new System.Windows.Forms.SplitContainer();
            this.tbTags = new System.Windows.Forms.TextBox();
            this.msTags = new System.Windows.Forms.MenuStrip();
            this.tsmiTagAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvEntities = new System.Windows.Forms.DataGridView();
            this.colEntityCaption = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.msEntities = new System.Windows.Forms.MenuStrip();
            this.tsmiEntityAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEntityRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
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
            this.btCancel.Location = new System.Drawing.Point(361, 469);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 4;
            this.btCancel.Text = "Отмена";
            this.btCancel.UseVisualStyleBackColor = true;
            // 
            // btOk
            // 
            this.btOk.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btOk.Location = new System.Drawing.Point(280, 469);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(75, 23);
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
            this.tbText.Location = new System.Drawing.Point(6, 73);
            this.tbText.Multiline = true;
            this.tbText.Name = "tbText";
            this.tbText.Size = new System.Drawing.Size(466, 384);
            this.tbText.TabIndex = 2;
            // 
            // tbCaption
            // 
            this.tbCaption.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCaption.Location = new System.Drawing.Point(6, 25);
            this.tbCaption.Name = "tbCaption";
            this.tbCaption.Size = new System.Drawing.Size(349, 20);
            this.tbCaption.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Текст";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Заголовок";
            // 
            // scMain
            // 
            this.scMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scMain.Location = new System.Drawing.Point(0, 0);
            this.scMain.Name = "scMain";
            // 
            // scMain.Panel1
            // 
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
            this.scMain.Size = new System.Drawing.Size(716, 460);
            this.scMain.SplitterDistance = 475;
            this.scMain.SplitterWidth = 6;
            this.scMain.TabIndex = 0;
            // 
            // scLinked
            // 
            this.scLinked.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scLinked.Location = new System.Drawing.Point(0, 0);
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
            this.scLinked.Size = new System.Drawing.Size(235, 460);
            this.scLinked.SplitterDistance = 253;
            this.scLinked.SplitterWidth = 6;
            this.scLinked.TabIndex = 0;
            // 
            // tbTags
            // 
            this.tbTags.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbTags.Location = new System.Drawing.Point(0, 24);
            this.tbTags.Multiline = true;
            this.tbTags.Name = "tbTags";
            this.tbTags.Size = new System.Drawing.Size(235, 229);
            this.tbTags.TabIndex = 0;
            // 
            // msTags
            // 
            this.msTags.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiTagAdd});
            this.msTags.Location = new System.Drawing.Point(0, 0);
            this.msTags.Name = "msTags";
            this.msTags.Size = new System.Drawing.Size(235, 24);
            this.msTags.TabIndex = 1;
            this.msTags.Text = "menuStrip1";
            // 
            // tsmiTagAdd
            // 
            this.tsmiTagAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsmiTagAdd.Image = global::Diary.Properties.Resources.IconPlus;
            this.tsmiTagAdd.Name = "tsmiTagAdd";
            this.tsmiTagAdd.Size = new System.Drawing.Size(28, 20);
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
            this.dgvEntities.Location = new System.Drawing.Point(0, 24);
            this.dgvEntities.MultiSelect = false;
            this.dgvEntities.Name = "dgvEntities";
            this.dgvEntities.RowHeadersVisible = false;
            this.dgvEntities.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEntities.Size = new System.Drawing.Size(235, 177);
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
            this.msEntities.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiEntityAdd,
            this.tsmiEntityRemove});
            this.msEntities.Location = new System.Drawing.Point(0, 0);
            this.msEntities.Name = "msEntities";
            this.msEntities.Size = new System.Drawing.Size(235, 24);
            this.msEntities.TabIndex = 1;
            this.msEntities.Text = "menuStrip1";
            // 
            // tsmiEntityAdd
            // 
            this.tsmiEntityAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsmiEntityAdd.Image = global::Diary.Properties.Resources.IconPlus;
            this.tsmiEntityAdd.Name = "tsmiEntityAdd";
            this.tsmiEntityAdd.Size = new System.Drawing.Size(28, 20);
            this.tsmiEntityAdd.Text = "Добавить";
            this.tsmiEntityAdd.Click += new System.EventHandler(this.tsmiEntityAdd_Click);
            // 
            // tsmiEntityRemove
            // 
            this.tsmiEntityRemove.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsmiEntityRemove.Image = global::Diary.Properties.Resources.action_delete_sharp_thick;
            this.tsmiEntityRemove.Name = "tsmiEntityRemove";
            this.tsmiEntityRemove.Size = new System.Drawing.Size(28, 20);
            this.tsmiEntityRemove.Text = "Удалить";
            this.tsmiEntityRemove.Click += new System.EventHandler(this.tsmiEntityRemove_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(358, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Дата";
            // 
            // dateTimePicker1
            // 
            this.dtpDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDate.CustomFormat = "dd.MM.yy HH:mm";
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(361, 27);
            this.dtpDate.Name = "dateTimePicker1";
            this.dtpDate.Size = new System.Drawing.Size(111, 20);
            this.dtpDate.TabIndex = 1;
            // 
            // FormRecord
            // 
            this.AcceptButton = this.btOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btCancel;
            this.ClientSize = new System.Drawing.Size(719, 500);
            this.Controls.Add(this.scMain);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btOk);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.msEntities;
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
    }
}