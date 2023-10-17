namespace Diary.Forms
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
            this.tvTags = new System.Windows.Forms.TreeView();
            this.dgvGroups = new System.Windows.Forms.DataGridView();
            this.colGroupCaption = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.tsmiRecordCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.tstbFilter = new System.Windows.Forms.ToolStripTextBox();
            this.tsmiFilterIcon = new System.Windows.Forms.ToolStripMenuItem();
            this.colRecordDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRecordCaption = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRecordEmotion = new System.Windows.Forms.DataGridViewImageColumn();
            this.colText = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.scMain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.scMain.Name = "scMain";
            // 
            // scMain.Panel1
            // 
            this.scMain.Panel1.Controls.Add(this.tvTags);
            this.scMain.Panel1.Controls.Add(this.dgvGroups);
            this.scMain.Panel1.Controls.Add(this.msGroups);
            // 
            // scMain.Panel2
            // 
            this.scMain.Panel2.Controls.Add(this.dgvRecords);
            this.scMain.Panel2.Controls.Add(this.msRecords);
            this.scMain.Size = new System.Drawing.Size(1446, 1035);
            this.scMain.SplitterDistance = 334;
            this.scMain.SplitterWidth = 9;
            this.scMain.TabIndex = 0;
            // 
            // tvTags
            // 
            this.tvTags.AllowDrop = true;
            this.tvTags.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvTags.HideSelection = false;
            this.tvTags.Location = new System.Drawing.Point(0, 39);
            this.tvTags.Name = "tvTags";
            this.tvTags.Size = new System.Drawing.Size(334, 996);
            this.tvTags.TabIndex = 2;
            this.tvTags.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.tvTags_ItemDrag);
            this.tvTags.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvTags_AfterSelect);
            this.tvTags.DragDrop += new System.Windows.Forms.DragEventHandler(this.tvTags_DragDrop);
            this.tvTags.DragEnter += new System.Windows.Forms.DragEventHandler(this.tvTags_DragEnter);
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
            this.dgvGroups.Location = new System.Drawing.Point(0, 39);
            this.dgvGroups.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvGroups.MultiSelect = false;
            this.dgvGroups.Name = "dgvGroups";
            this.dgvGroups.RowHeadersVisible = false;
            this.dgvGroups.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGroups.Size = new System.Drawing.Size(334, 996);
            this.dgvGroups.TabIndex = 1;
            this.dgvGroups.SelectionChanged += new System.EventHandler(this.dgvGroups_SelectionChanged);
            // 
            // colGroupCaption
            // 
            this.colGroupCaption.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colGroupCaption.DataPropertyName = "Caption";
            this.colGroupCaption.HeaderText = "Заголовок";
            this.colGroupCaption.Name = "colGroupCaption";
            // 
            // msGroups
            // 
            this.msGroups.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.msGroups.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tscbGroup,
            this.tsmiGroupAdd,
            this.tsmiGroupEdit,
            this.tsmiGroupDelete});
            this.msGroups.Location = new System.Drawing.Point(0, 0);
            this.msGroups.Name = "msGroups";
            this.msGroups.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.msGroups.Size = new System.Drawing.Size(334, 39);
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
            this.tscbGroup.Size = new System.Drawing.Size(180, 33);
            this.tscbGroup.SelectedIndexChanged += new System.EventHandler(this.tscbGroup_SelectedIndexChanged);
            // 
            // tsmiGroupAdd
            // 
            this.tsmiGroupAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsmiGroupAdd.Image = global::Diary.Properties.Resources.IconPlus;
            this.tsmiGroupAdd.Name = "tsmiGroupAdd";
            this.tsmiGroupAdd.Size = new System.Drawing.Size(36, 33);
            this.tsmiGroupAdd.Text = "Добавить";
            this.tsmiGroupAdd.Click += new System.EventHandler(this.tsmiGroupAdd_Click);
            // 
            // tsmiGroupEdit
            // 
            this.tsmiGroupEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsmiGroupEdit.Image = global::Diary.Properties.Resources.IconEdit;
            this.tsmiGroupEdit.Name = "tsmiGroupEdit";
            this.tsmiGroupEdit.Size = new System.Drawing.Size(36, 33);
            this.tsmiGroupEdit.Text = "Редактировать";
            this.tsmiGroupEdit.Click += new System.EventHandler(this.tsmiGroupEdit_Click);
            // 
            // tsmiGroupDelete
            // 
            this.tsmiGroupDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsmiGroupDelete.Image = global::Diary.Properties.Resources.action_delete_sharp_thick;
            this.tsmiGroupDelete.Name = "tsmiGroupDelete";
            this.tsmiGroupDelete.Size = new System.Drawing.Size(36, 33);
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
            this.colRecordCaption,
            this.colRecordEmotion,
            this.colText});
            this.dgvRecords.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRecords.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvRecords.Location = new System.Drawing.Point(0, 37);
            this.dgvRecords.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvRecords.MultiSelect = false;
            this.dgvRecords.Name = "dgvRecords";
            this.dgvRecords.RowHeadersVisible = false;
            this.dgvRecords.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRecords.Size = new System.Drawing.Size(1103, 998);
            this.dgvRecords.TabIndex = 1;
            // 
            // msRecords
            // 
            this.msRecords.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.msRecords.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiRecordAdd,
            this.tsmiRecordEdit,
            this.tsmiRecordDelete,
            this.tsmiRecordCopy,
            this.tstbFilter,
            this.tsmiFilterIcon});
            this.msRecords.Location = new System.Drawing.Point(0, 0);
            this.msRecords.Name = "msRecords";
            this.msRecords.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.msRecords.Size = new System.Drawing.Size(1103, 37);
            this.msRecords.TabIndex = 0;
            this.msRecords.Text = "Записи";
            // 
            // tsmiRecordAdd
            // 
            this.tsmiRecordAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsmiRecordAdd.Image = global::Diary.Properties.Resources.IconPlus;
            this.tsmiRecordAdd.Name = "tsmiRecordAdd";
            this.tsmiRecordAdd.Size = new System.Drawing.Size(36, 31);
            this.tsmiRecordAdd.Text = "Добавить";
            this.tsmiRecordAdd.Click += new System.EventHandler(this.tsmiRecordAdd_Click);
            // 
            // tsmiRecordEdit
            // 
            this.tsmiRecordEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsmiRecordEdit.Image = global::Diary.Properties.Resources.IconEdit;
            this.tsmiRecordEdit.Name = "tsmiRecordEdit";
            this.tsmiRecordEdit.Size = new System.Drawing.Size(36, 31);
            this.tsmiRecordEdit.Text = "Редактировать";
            this.tsmiRecordEdit.Click += new System.EventHandler(this.tsmiRecordEdit_Click);
            // 
            // tsmiRecordDelete
            // 
            this.tsmiRecordDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsmiRecordDelete.Image = global::Diary.Properties.Resources.action_delete_sharp_thick;
            this.tsmiRecordDelete.Name = "tsmiRecordDelete";
            this.tsmiRecordDelete.Size = new System.Drawing.Size(36, 31);
            this.tsmiRecordDelete.Text = "Удалить";
            this.tsmiRecordDelete.Click += new System.EventHandler(this.tsmiRecordDelete_Click);
            // 
            // tsmiRecordCopy
            // 
            this.tsmiRecordCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsmiRecordCopy.Image = global::Diary.Properties.Resources.IconCopy;
            this.tsmiRecordCopy.Name = "tsmiRecordCopy";
            this.tsmiRecordCopy.Size = new System.Drawing.Size(36, 31);
            this.tsmiRecordCopy.Text = "Copy";
            this.tsmiRecordCopy.Click += new System.EventHandler(this.tsmiRecordCopy_Click);
            // 
            // tstbFilter
            // 
            this.tstbFilter.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tstbFilter.Name = "tstbFilter";
            this.tstbFilter.Size = new System.Drawing.Size(200, 31);
            this.tstbFilter.TextChanged += new System.EventHandler(this.tstbFilter_TextChanged);
            // 
            // tsmiFilterIcon
            // 
            this.tsmiFilterIcon.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsmiFilterIcon.Image = global::Diary.Properties.Resources.IconFilter;
            this.tsmiFilterIcon.Name = "tsmiFilterIcon";
            this.tsmiFilterIcon.Size = new System.Drawing.Size(36, 31);
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
            // colRecordEmotion
            // 
            this.colRecordEmotion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colRecordEmotion.DataPropertyName = "EmotionPic";
            this.colRecordEmotion.HeaderText = "Отношение";
            this.colRecordEmotion.Name = "colRecordEmotion";
            this.colRecordEmotion.Width = 103;
            // 
            // colText
            // 
            this.colText.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colText.DataPropertyName = "TextStr";
            this.colText.HeaderText = "Текст";
            this.colText.Name = "colText";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1446, 1035);
            this.Controls.Add(this.scMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.msGroups;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn colGroupCaption;
        private System.Windows.Forms.ToolStripMenuItem tsmiRecordCopy;
        private System.Windows.Forms.ToolStripTextBox tstbFilter;
        private System.Windows.Forms.ToolStripMenuItem tsmiFilterIcon;
        private System.Windows.Forms.TreeView tvTags;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRecordDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRecordCaption;
        private System.Windows.Forms.DataGridViewImageColumn colRecordEmotion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colText;
    }
}

