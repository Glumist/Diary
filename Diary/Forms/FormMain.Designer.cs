namespace Diary
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.scMain = new System.Windows.Forms.SplitContainer();
            this.dgvGroups = new System.Windows.Forms.DataGridView();
            this.msGroups = new System.Windows.Forms.MenuStrip();
            this.tscbGroup = new System.Windows.Forms.ToolStripComboBox();
            this.tsmiGroupAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiGroupEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiGroupDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvRecords = new System.Windows.Forms.DataGridView();
            this.msRecords = new System.Windows.Forms.MenuStrip();
            this.tsmiRecordAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRecordEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRecordDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.colRecordDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRecordCaption = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGroupCaption = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).BeginInit();
            this.scMain.Panel1.SuspendLayout();
            this.scMain.Panel2.SuspendLayout();
            this.scMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroups)).BeginInit();
            this.msGroups.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecords)).BeginInit();
            this.msRecords.SuspendLayout();
            this.SuspendLayout();
            // 
            // scMain
            // 
            this.scMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scMain.Location = new System.Drawing.Point(0, 0);
            this.scMain.Name = "scMain";
            // 
            // scMain.Panel1
            // 
            this.scMain.Panel1.Controls.Add(this.dgvGroups);
            this.scMain.Panel1.Controls.Add(this.msGroups);
            // 
            // scMain.Panel2
            // 
            this.scMain.Panel2.Controls.Add(this.dgvRecords);
            this.scMain.Panel2.Controls.Add(this.msRecords);
            this.scMain.Size = new System.Drawing.Size(964, 673);
            this.scMain.SplitterDistance = 223;
            this.scMain.SplitterWidth = 6;
            this.scMain.TabIndex = 0;
            // 
            // dgvGroups
            // 
            this.dgvGroups.AllowUserToAddRows = false;
            this.dgvGroups.AllowUserToDeleteRows = false;
            this.dgvGroups.AllowUserToResizeRows = false;
            this.dgvGroups.BackgroundColor = System.Drawing.Color.White;
            this.dgvGroups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGroups.ColumnHeadersVisible = false;
            this.dgvGroups.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colGroupCaption});
            this.dgvGroups.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGroups.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvGroups.Location = new System.Drawing.Point(0, 27);
            this.dgvGroups.MultiSelect = false;
            this.dgvGroups.Name = "dgvGroups";
            this.dgvGroups.RowHeadersVisible = false;
            this.dgvGroups.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGroups.Size = new System.Drawing.Size(223, 646);
            this.dgvGroups.TabIndex = 1;
            this.dgvGroups.SelectionChanged += new System.EventHandler(this.dgvGroups_SelectionChanged);
            // 
            // msGroups
            // 
            this.msGroups.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tscbGroup,
            this.tsmiGroupAdd,
            this.tsmiGroupEdit,
            this.tsmiGroupDelete});
            this.msGroups.Location = new System.Drawing.Point(0, 0);
            this.msGroups.Name = "msGroups";
            this.msGroups.Size = new System.Drawing.Size(223, 27);
            this.msGroups.TabIndex = 0;
            this.msGroups.Text = "Группировка";
            // 
            // tscbGroup
            // 
            this.tscbGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tscbGroup.Items.AddRange(new object[] {
            "Тэги",
            "Сущности"});
            this.tscbGroup.Name = "tscbGroup";
            this.tscbGroup.Size = new System.Drawing.Size(121, 23);
            this.tscbGroup.SelectedIndexChanged += new System.EventHandler(this.tscbGroup_SelectedIndexChanged);
            // 
            // tsmiGroupAdd
            // 
            this.tsmiGroupAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsmiGroupAdd.Image = global::Diary.Properties.Resources.IconPlus;
            this.tsmiGroupAdd.Name = "tsmiGroupAdd";
            this.tsmiGroupAdd.Size = new System.Drawing.Size(28, 23);
            this.tsmiGroupAdd.Text = "Добавить";
            this.tsmiGroupAdd.Click += new System.EventHandler(this.tsmiGroupAdd_Click);
            // 
            // tsmiGroupEdit
            // 
            this.tsmiGroupEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsmiGroupEdit.Image = global::Diary.Properties.Resources.IconEdit;
            this.tsmiGroupEdit.Name = "tsmiGroupEdit";
            this.tsmiGroupEdit.Size = new System.Drawing.Size(28, 23);
            this.tsmiGroupEdit.Text = "Редактировать";
            this.tsmiGroupEdit.Click += new System.EventHandler(this.tsmiGroupEdit_Click);
            // 
            // tsmiGroupDelete
            // 
            this.tsmiGroupDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsmiGroupDelete.Image = global::Diary.Properties.Resources.action_delete_sharp_thick;
            this.tsmiGroupDelete.Name = "tsmiGroupDelete";
            this.tsmiGroupDelete.Size = new System.Drawing.Size(28, 23);
            this.tsmiGroupDelete.Text = "Удалить";
            this.tsmiGroupDelete.Click += new System.EventHandler(this.tsmiGroupDelete_Click);
            // 
            // dgvRecords
            // 
            this.dgvRecords.AllowUserToAddRows = false;
            this.dgvRecords.AllowUserToDeleteRows = false;
            this.dgvRecords.AllowUserToResizeRows = false;
            this.dgvRecords.BackgroundColor = System.Drawing.Color.White;
            this.dgvRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecords.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colRecordDate,
            this.colRecordCaption});
            this.dgvRecords.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRecords.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvRecords.Location = new System.Drawing.Point(0, 24);
            this.dgvRecords.MultiSelect = false;
            this.dgvRecords.Name = "dgvRecords";
            this.dgvRecords.RowHeadersVisible = false;
            this.dgvRecords.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRecords.Size = new System.Drawing.Size(735, 649);
            this.dgvRecords.TabIndex = 1;
            // 
            // msRecords
            // 
            this.msRecords.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiRecordAdd,
            this.tsmiRecordEdit,
            this.tsmiRecordDelete});
            this.msRecords.Location = new System.Drawing.Point(0, 0);
            this.msRecords.Name = "msRecords";
            this.msRecords.Size = new System.Drawing.Size(735, 24);
            this.msRecords.TabIndex = 0;
            this.msRecords.Text = "Записи";
            // 
            // tsmiRecordAdd
            // 
            this.tsmiRecordAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsmiRecordAdd.Image = global::Diary.Properties.Resources.IconPlus;
            this.tsmiRecordAdd.Name = "tsmiRecordAdd";
            this.tsmiRecordAdd.Size = new System.Drawing.Size(28, 20);
            this.tsmiRecordAdd.Text = "Добавить";
            this.tsmiRecordAdd.Click += new System.EventHandler(this.tsmiRecordAdd_Click);
            // 
            // tsmiRecordEdit
            // 
            this.tsmiRecordEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsmiRecordEdit.Image = global::Diary.Properties.Resources.IconEdit;
            this.tsmiRecordEdit.Name = "tsmiRecordEdit";
            this.tsmiRecordEdit.Size = new System.Drawing.Size(28, 20);
            this.tsmiRecordEdit.Text = "Редактировать";
            this.tsmiRecordEdit.Click += new System.EventHandler(this.tsmiRecordEdit_Click);
            // 
            // tsmiRecordDelete
            // 
            this.tsmiRecordDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsmiRecordDelete.Image = global::Diary.Properties.Resources.action_delete_sharp_thick;
            this.tsmiRecordDelete.Name = "tsmiRecordDelete";
            this.tsmiRecordDelete.Size = new System.Drawing.Size(28, 20);
            this.tsmiRecordDelete.Text = "Удалить";
            this.tsmiRecordDelete.Click += new System.EventHandler(this.tsmiRecordDelete_Click);
            // 
            // colRecordDate
            // 
            this.colRecordDate.DataPropertyName = "Date";
            this.colRecordDate.HeaderText = "Дата";
            this.colRecordDate.Name = "colRecordDate";
            // 
            // colRecordCaption
            // 
            this.colRecordCaption.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colRecordCaption.DataPropertyName = "Caption";
            this.colRecordCaption.HeaderText = "Заголовок";
            this.colRecordCaption.Name = "colRecordCaption";
            // 
            // colGroupCaption
            // 
            this.colGroupCaption.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colGroupCaption.DataPropertyName = "Caption";
            this.colGroupCaption.HeaderText = "Заголовок";
            this.colGroupCaption.Name = "colGroupCaption";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 673);
            this.Controls.Add(this.scMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.msGroups;
            this.Name = "FormMain";
            this.Text = "Дневник";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.scMain.Panel1.ResumeLayout(false);
            this.scMain.Panel1.PerformLayout();
            this.scMain.Panel2.ResumeLayout(false);
            this.scMain.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).EndInit();
            this.scMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroups)).EndInit();
            this.msGroups.ResumeLayout(false);
            this.msGroups.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecords)).EndInit();
            this.msRecords.ResumeLayout(false);
            this.msRecords.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer scMain;
        private System.Windows.Forms.MenuStrip msGroups;
        private System.Windows.Forms.ToolStripComboBox tscbGroup;
        private System.Windows.Forms.ToolStripMenuItem tsmiGroupAdd;
        private System.Windows.Forms.ToolStripMenuItem tsmiGroupEdit;
        private System.Windows.Forms.DataGridView dgvGroups;
        private System.Windows.Forms.ToolStripMenuItem tsmiGroupDelete;
        private System.Windows.Forms.DataGridView dgvRecords;
        private System.Windows.Forms.MenuStrip msRecords;
        private System.Windows.Forms.ToolStripMenuItem tsmiRecordAdd;
        private System.Windows.Forms.ToolStripMenuItem tsmiRecordEdit;
        private System.Windows.Forms.ToolStripMenuItem tsmiRecordDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRecordDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRecordCaption;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGroupCaption;
    }
}

