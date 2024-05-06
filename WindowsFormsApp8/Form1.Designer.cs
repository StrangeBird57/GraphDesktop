
namespace WindowsFormsApp8
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.AddVertexBtn = new System.Windows.Forms.Button();
            this.RemoveVertexBtn = new System.Windows.Forms.Button();
            this.AddEdgeBtn = new System.Windows.Forms.Button();
            this.DfsBtn = new System.Windows.Forms.Button();
            this.BfsBtn = new System.Windows.Forms.Button();
            this.ResetBtn = new System.Windows.Forms.Button();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ImportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dFSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bFSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeVertexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddVertexBtn
            // 
            this.AddVertexBtn.Location = new System.Drawing.Point(9, 26);
            this.AddVertexBtn.Margin = new System.Windows.Forms.Padding(2);
            this.AddVertexBtn.Name = "AddVertexBtn";
            this.AddVertexBtn.Size = new System.Drawing.Size(112, 32);
            this.AddVertexBtn.TabIndex = 1;
            this.AddVertexBtn.Text = "Добавить вершину";
            this.AddVertexBtn.UseVisualStyleBackColor = true;
            this.AddVertexBtn.Click += new System.EventHandler(this.AddVertexBtn_Click);
            // 
            // RemoveVertexBtn
            // 
            this.RemoveVertexBtn.BackColor = System.Drawing.Color.Gainsboro;
            this.RemoveVertexBtn.Location = new System.Drawing.Point(125, 26);
            this.RemoveVertexBtn.Margin = new System.Windows.Forms.Padding(2);
            this.RemoveVertexBtn.Name = "RemoveVertexBtn";
            this.RemoveVertexBtn.Size = new System.Drawing.Size(112, 32);
            this.RemoveVertexBtn.TabIndex = 2;
            this.RemoveVertexBtn.Text = "Удалить вершину";
            this.RemoveVertexBtn.UseVisualStyleBackColor = false;
            this.RemoveVertexBtn.Click += new System.EventHandler(this.RemoveVertexBtn_Click);
            // 
            // AddEdgeBtn
            // 
            this.AddEdgeBtn.Location = new System.Drawing.Point(241, 26);
            this.AddEdgeBtn.Margin = new System.Windows.Forms.Padding(2);
            this.AddEdgeBtn.Name = "AddEdgeBtn";
            this.AddEdgeBtn.Size = new System.Drawing.Size(112, 32);
            this.AddEdgeBtn.TabIndex = 3;
            this.AddEdgeBtn.Text = "Добавить ребро";
            this.AddEdgeBtn.UseVisualStyleBackColor = true;
            this.AddEdgeBtn.Click += new System.EventHandler(this.AddEdgeBtn_Click);
            // 
            // DfsBtn
            // 
            this.DfsBtn.Location = new System.Drawing.Point(357, 26);
            this.DfsBtn.Margin = new System.Windows.Forms.Padding(2);
            this.DfsBtn.Name = "DfsBtn";
            this.DfsBtn.Size = new System.Drawing.Size(112, 32);
            this.DfsBtn.TabIndex = 4;
            this.DfsBtn.Text = "DFS";
            this.DfsBtn.UseVisualStyleBackColor = true;
            this.DfsBtn.Click += new System.EventHandler(this.DfsBtn_Click);
            // 
            // BfsBtn
            // 
            this.BfsBtn.Location = new System.Drawing.Point(473, 26);
            this.BfsBtn.Margin = new System.Windows.Forms.Padding(2);
            this.BfsBtn.Name = "BfsBtn";
            this.BfsBtn.Size = new System.Drawing.Size(112, 32);
            this.BfsBtn.TabIndex = 5;
            this.BfsBtn.Text = "BFS";
            this.BfsBtn.UseVisualStyleBackColor = true;
            this.BfsBtn.Click += new System.EventHandler(this.BfsBtn_Click);
            // 
            // ResetBtn
            // 
            this.ResetBtn.Location = new System.Drawing.Point(9, 334);
            this.ResetBtn.Margin = new System.Windows.Forms.Padding(2);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(75, 24);
            this.ResetBtn.TabIndex = 6;
            this.ResetBtn.Text = "Сбросить";
            this.ResetBtn.UseVisualStyleBackColor = true;
            this.ResetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // ClearBtn
            // 
            this.ClearBtn.Location = new System.Drawing.Point(540, 334);
            this.ClearBtn.Margin = new System.Windows.Forms.Padding(2);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(75, 24);
            this.ClearBtn.TabIndex = 7;
            this.ClearBtn.Text = "Очистить";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(624, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExportToolStripMenuItem,
            this.ImportToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // ExportToolStripMenuItem
            // 
            this.ExportToolStripMenuItem.Name = "ExportToolStripMenuItem";
            this.ExportToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.ExportToolStripMenuItem.Text = "Экспорт";
            this.ExportToolStripMenuItem.Click += new System.EventHandler(this.ExportToolStripMenuItem_Click);
            // 
            // ImportToolStripMenuItem
            // 
            this.ImportToolStripMenuItem.Name = "ImportToolStripMenuItem";
            this.ImportToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.ImportToolStripMenuItem.Text = "Импорт";
            this.ImportToolStripMenuItem.Click += new System.EventHandler(this.ImportToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dFSToolStripMenuItem,
            this.bFSToolStripMenuItem,
            this.removeVertexToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(172, 70);
            // 
            // dFSToolStripMenuItem
            // 
            this.dFSToolStripMenuItem.Name = "dFSToolStripMenuItem";
            this.dFSToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.dFSToolStripMenuItem.Text = "DFS";
            this.dFSToolStripMenuItem.Click += new System.EventHandler(this.dFSToolStripMenuItem_Click);
            // 
            // bFSToolStripMenuItem
            // 
            this.bFSToolStripMenuItem.Name = "bFSToolStripMenuItem";
            this.bFSToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.bFSToolStripMenuItem.Text = "BFS";
            this.bFSToolStripMenuItem.Click += new System.EventHandler(this.bFSToolStripMenuItem_Click);
            // 
            // removeVertexToolStripMenuItem
            // 
            this.removeVertexToolStripMenuItem.Name = "removeVertexToolStripMenuItem";
            this.removeVertexToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.removeVertexToolStripMenuItem.Text = "Удалить вершину";
            this.removeVertexToolStripMenuItem.Click += new System.EventHandler(this.removeVertexToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(624, 368);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.ResetBtn);
            this.Controls.Add(this.BfsBtn);
            this.Controls.Add(this.DfsBtn);
            this.Controls.Add(this.AddEdgeBtn);
            this.Controls.Add(this.RemoveVertexBtn);
            this.Controls.Add(this.AddVertexBtn);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form_MouseClick);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button AddVertexBtn;
        private System.Windows.Forms.Button RemoveVertexBtn;
        private System.Windows.Forms.Button AddEdgeBtn;
        private System.Windows.Forms.Button DfsBtn;
        private System.Windows.Forms.Button BfsBtn;
        private System.Windows.Forms.Button ResetBtn;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ImportToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dFSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bFSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeVertexToolStripMenuItem;
    }
}

