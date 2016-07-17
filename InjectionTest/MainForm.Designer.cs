namespace NetInject.App
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.loadAssemblyDialog = new System.Windows.Forms.OpenFileDialog();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.assemblyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemAssemblyLoad = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.treeLoadedAssemblies = new System.Windows.Forms.TreeView();
            this.gridMethodOpCodes = new System.Windows.Forms.DataGridView();
            this.Index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Offset = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OpCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Operand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textEditor = new System.Windows.Forms.RichTextBox();
            this.listProgrammingLanguage = new System.Windows.Forms.ToolStripComboBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridMethodOpCodes)).BeginInit();
            this.SuspendLayout();
            // 
            // loadAssemblyDialog
            // 
            this.loadAssemblyDialog.Filter = "Assembly|*.dll|Executable|*.exe|All files|*.*";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 23);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // assemblyToolStripMenuItem
            // 
            this.assemblyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemAssemblyLoad});
            this.assemblyToolStripMenuItem.Name = "assemblyToolStripMenuItem";
            this.assemblyToolStripMenuItem.Size = new System.Drawing.Size(70, 23);
            this.assemblyToolStripMenuItem.Text = "Assembly";
            // 
            // menuItemAssemblyLoad
            // 
            this.menuItemAssemblyLoad.Name = "menuItemAssemblyLoad";
            this.menuItemAssemblyLoad.Size = new System.Drawing.Size(100, 22);
            this.menuItemAssemblyLoad.Text = "Load";
            this.menuItemAssemblyLoad.Click += new System.EventHandler(this.menuItemAssemblyLoad_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.assemblyToolStripMenuItem,
            this.listProgrammingLanguage});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1377, 27);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // treeLoadedAssemblies
            // 
            this.treeLoadedAssemblies.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeLoadedAssemblies.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeLoadedAssemblies.Location = new System.Drawing.Point(0, 27);
            this.treeLoadedAssemblies.Name = "treeLoadedAssemblies";
            this.treeLoadedAssemblies.ShowLines = false;
            this.treeLoadedAssemblies.Size = new System.Drawing.Size(311, 711);
            this.treeLoadedAssemblies.TabIndex = 1;
            this.treeLoadedAssemblies.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeLoadedAssemblies_AfterSelect);
            // 
            // gridMethodOpCodes
            // 
            this.gridMethodOpCodes.AllowUserToAddRows = false;
            this.gridMethodOpCodes.AllowUserToDeleteRows = false;
            this.gridMethodOpCodes.AllowUserToResizeRows = false;
            this.gridMethodOpCodes.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.gridMethodOpCodes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridMethodOpCodes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridMethodOpCodes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.gridMethodOpCodes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridMethodOpCodes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Index,
            this.Offset,
            this.OpCode,
            this.Operand});
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridMethodOpCodes.DefaultCellStyle = dataGridViewCellStyle16;
            this.gridMethodOpCodes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridMethodOpCodes.Location = new System.Drawing.Point(311, 226);
            this.gridMethodOpCodes.Name = "gridMethodOpCodes";
            this.gridMethodOpCodes.ReadOnly = true;
            this.gridMethodOpCodes.RowHeadersVisible = false;
            this.gridMethodOpCodes.Size = new System.Drawing.Size(1066, 512);
            this.gridMethodOpCodes.TabIndex = 4;
            // 
            // Index
            // 
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Index.DefaultCellStyle = dataGridViewCellStyle14;
            this.Index.HeaderText = "";
            this.Index.Name = "Index";
            this.Index.ReadOnly = true;
            this.Index.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Index.Width = 40;
            // 
            // Offset
            // 
            this.Offset.HeaderText = "Offset";
            this.Offset.Name = "Offset";
            this.Offset.ReadOnly = true;
            this.Offset.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // OpCode
            // 
            this.OpCode.HeaderText = "OpCode";
            this.OpCode.Name = "OpCode";
            this.OpCode.ReadOnly = true;
            this.OpCode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Operand
            // 
            this.Operand.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Operand.DefaultCellStyle = dataGridViewCellStyle15;
            this.Operand.HeaderText = "Operand";
            this.Operand.Name = "Operand";
            this.Operand.ReadOnly = true;
            this.Operand.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // textEditor
            // 
            this.textEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textEditor.Location = new System.Drawing.Point(311, 27);
            this.textEditor.Name = "textEditor";
            this.textEditor.Size = new System.Drawing.Size(1066, 199);
            this.textEditor.TabIndex = 5;
            this.textEditor.Text = "";
            // 
            // listProgrammingLanguage
            // 
            this.listProgrammingLanguage.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.listProgrammingLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listProgrammingLanguage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.listProgrammingLanguage.Items.AddRange(new object[] {
            "C#"});
            this.listProgrammingLanguage.Name = "listProgrammingLanguage";
            this.listProgrammingLanguage.Size = new System.Drawing.Size(75, 23);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1377, 738);
            this.Controls.Add(this.textEditor);
            this.Controls.Add(this.gridMethodOpCodes);
            this.Controls.Add(this.treeLoadedAssemblies);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Main";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridMethodOpCodes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog loadAssemblyDialog;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem assemblyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuItemAssemblyLoad;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TreeView treeLoadedAssemblies;
        private System.Windows.Forms.DataGridView gridMethodOpCodes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Index;
        private System.Windows.Forms.DataGridViewTextBoxColumn Offset;
        private System.Windows.Forms.DataGridViewTextBoxColumn OpCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Operand;
        private System.Windows.Forms.RichTextBox textEditor;
        private System.Windows.Forms.ToolStripComboBox listProgrammingLanguage;
    }
}