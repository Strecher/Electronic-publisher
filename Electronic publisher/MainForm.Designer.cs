namespace Electronic_publisher
{
    partial class MainForm
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
            this.topPanel = new System.Windows.Forms.Panel();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createNewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.publishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.correctionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.treeView = new System.Windows.Forms.TreeView();
            this.panelForStructureLabel = new System.Windows.Forms.Panel();
            this.structureLabel = new System.Windows.Forms.Label();
            this.mainRichTextBox = new System.Windows.Forms.RichTextBox();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.panelForStructureLabel.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.topPanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.topPanel.Location = new System.Drawing.Point(1, 28);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1263, 92);
            this.topPanel.TabIndex = 1;
            // 
            // menuStrip
            // 
            this.menuStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.correctionToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(142, 27);
            this.menuStrip.TabIndex = 2;
            this.menuStrip.Text = "menuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createNewToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.publishToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(67, 23);
            this.fileToolStripMenuItem.Text = "Проект";
            // 
            // createNewToolStripMenuItem
            // 
            this.createNewToolStripMenuItem.Name = "createNewToolStripMenuItem";
            this.createNewToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+N";
            this.createNewToolStripMenuItem.Size = new System.Drawing.Size(264, 24);
            this.createNewToolStripMenuItem.Text = "Новый...";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+O";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(264, 24);
            this.openToolStripMenuItem.Text = "Открыть...";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+S";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(264, 24);
            this.saveToolStripMenuItem.Text = "Сохранить";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+Shift+S";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(264, 24);
            this.saveAsToolStripMenuItem.Text = "Сохранить как...";
            // 
            // publishToolStripMenuItem
            // 
            this.publishToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.publishToolStripMenuItem.Name = "publishToolStripMenuItem";
            this.publishToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+P";
            this.publishToolStripMenuItem.Size = new System.Drawing.Size(264, 24);
            this.publishToolStripMenuItem.Text = "Опубликовать";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(264, 24);
            this.exitToolStripMenuItem.Text = "Выход";
            // 
            // correctionToolStripMenuItem
            // 
            this.correctionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cancelToolStripMenuItem1,
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem});
            this.correctionToolStripMenuItem.Name = "correctionToolStripMenuItem";
            this.correctionToolStripMenuItem.Size = new System.Drawing.Size(67, 23);
            this.correctionToolStripMenuItem.Text = "Правка";
            // 
            // cancelToolStripMenuItem1
            // 
            this.cancelToolStripMenuItem1.Name = "cancelToolStripMenuItem1";
            this.cancelToolStripMenuItem1.ShortcutKeyDisplayString = "Ctrl+Z";
            this.cancelToolStripMenuItem1.Size = new System.Drawing.Size(203, 24);
            this.cancelToolStripMenuItem1.Text = "Отменить";
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+X";
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(203, 24);
            this.cutToolStripMenuItem.Text = "Вырезать";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+C";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(203, 24);
            this.copyToolStripMenuItem.Text = "Копировать";
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+V";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(203, 24);
            this.pasteToolStripMenuItem.Text = "Вставить";
            // 
            // splitContainer
            // 
            this.splitContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer.Location = new System.Drawing.Point(0, 126);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.treeView);
            this.splitContainer.Panel1.Controls.Add(this.panelForStructureLabel);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.mainRichTextBox);
            this.splitContainer.Size = new System.Drawing.Size(1264, 553);
            this.splitContainer.SplitterDistance = 421;
            this.splitContainer.TabIndex = 4;
            // 
            // treeView
            // 
            this.treeView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeView.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.treeView.Location = new System.Drawing.Point(1, 22);
            this.treeView.Name = "treeView";
            this.treeView.Size = new System.Drawing.Size(417, 530);
            this.treeView.TabIndex = 6;
            // 
            // panelForStructureLabel
            // 
            this.panelForStructureLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelForStructureLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelForStructureLabel.Controls.Add(this.structureLabel);
            this.panelForStructureLabel.Location = new System.Drawing.Point(1, -1);
            this.panelForStructureLabel.Name = "panelForStructureLabel";
            this.panelForStructureLabel.Size = new System.Drawing.Size(417, 24);
            this.panelForStructureLabel.TabIndex = 5;
            // 
            // structureLabel
            // 
            this.structureLabel.AutoSize = true;
            this.structureLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.structureLabel.Location = new System.Drawing.Point(1, 0);
            this.structureLabel.Name = "structureLabel";
            this.structureLabel.Size = new System.Drawing.Size(87, 20);
            this.structureLabel.TabIndex = 0;
            this.structureLabel.Text = "Структура";
            // 
            // mainRichTextBox
            // 
            this.mainRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainRichTextBox.Location = new System.Drawing.Point(-1, -1);
            this.mainRichTextBox.Name = "mainRichTextBox";
            this.mainRichTextBox.Size = new System.Drawing.Size(839, 553);
            this.mainRichTextBox.TabIndex = 0;
            this.mainRichTextBox.Text = "";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.menuStrip);
            this.Name = "MainForm";
            this.Text = "Электронный публикатор";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.panelForStructureLabel.ResumeLayout(false);
            this.panelForStructureLabel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createNewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem correctionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem publishToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.Panel panelForStructureLabel;
        private System.Windows.Forms.Label structureLabel;
        private System.Windows.Forms.RichTextBox mainRichTextBox;
    }
}

