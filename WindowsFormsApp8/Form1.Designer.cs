
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
            this.ResetBtn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.новыйФалйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ImportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.графToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.матрицаСмеожностиtxtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.видToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.цветВершинToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.цветВершинПриВыделенииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.размерВершинToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.алгоритмыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dFSToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.bFSToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dFSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bFSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeVertexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.IsOrientedSwitch = new WindowsFormsApp8.ToggleSwitch();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddVertexBtn
            // 
            this.AddVertexBtn.Location = new System.Drawing.Point(12, 32);
            this.AddVertexBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddVertexBtn.Name = "AddVertexBtn";
            this.AddVertexBtn.Size = new System.Drawing.Size(149, 39);
            this.AddVertexBtn.TabIndex = 1;
            this.AddVertexBtn.Text = "Добавить вершину";
            this.AddVertexBtn.UseVisualStyleBackColor = true;
            this.AddVertexBtn.Click += new System.EventHandler(this.AddVertexBtn_Click);
            // 
            // RemoveVertexBtn
            // 
            this.RemoveVertexBtn.BackColor = System.Drawing.Color.Gainsboro;
            this.RemoveVertexBtn.Location = new System.Drawing.Point(167, 32);
            this.RemoveVertexBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RemoveVertexBtn.Name = "RemoveVertexBtn";
            this.RemoveVertexBtn.Size = new System.Drawing.Size(149, 39);
            this.RemoveVertexBtn.TabIndex = 2;
            this.RemoveVertexBtn.Text = "Удалить вершину";
            this.RemoveVertexBtn.UseVisualStyleBackColor = false;
            this.RemoveVertexBtn.Click += new System.EventHandler(this.RemoveVertexBtn_Click);
            // 
            // AddEdgeBtn
            // 
            this.AddEdgeBtn.Location = new System.Drawing.Point(321, 32);
            this.AddEdgeBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddEdgeBtn.Name = "AddEdgeBtn";
            this.AddEdgeBtn.Size = new System.Drawing.Size(149, 39);
            this.AddEdgeBtn.TabIndex = 3;
            this.AddEdgeBtn.Text = "Добавить ребро";
            this.AddEdgeBtn.UseVisualStyleBackColor = true;
            this.AddEdgeBtn.Click += new System.EventHandler(this.AddEdgeBtn_Click);
            // 
            // ResetBtn
            // 
            this.ResetBtn.Location = new System.Drawing.Point(12, 411);
            this.ResetBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(100, 30);
            this.ResetBtn.TabIndex = 6;
            this.ResetBtn.Text = "Сбросить";
            this.ResetBtn.UseVisualStyleBackColor = true;
            this.ResetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.видToolStripMenuItem,
            this.алгоритмыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(832, 28);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.новыйФалйToolStripMenuItem,
            this.ImportToolStripMenuItem,
            this.ExportToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // новыйФалйToolStripMenuItem
            // 
            this.новыйФалйToolStripMenuItem.Name = "новыйФалйToolStripMenuItem";
            this.новыйФалйToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.новыйФалйToolStripMenuItem.Text = "Новый файл";
            this.новыйФалйToolStripMenuItem.Click += new System.EventHandler(this.новыйФалйToolStripMenuItem_Click);
            // 
            // ImportToolStripMenuItem
            // 
            this.ImportToolStripMenuItem.Name = "ImportToolStripMenuItem";
            this.ImportToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.ImportToolStripMenuItem.Text = "Открыть";
            this.ImportToolStripMenuItem.Click += new System.EventHandler(this.ImportToolStripMenuItem_Click);
            // 
            // ExportToolStripMenuItem
            // 
            this.ExportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.графToolStripMenuItem,
            this.txtToolStripMenuItem,
            this.матрицаСмеожностиtxtToolStripMenuItem});
            this.ExportToolStripMenuItem.Name = "ExportToolStripMenuItem";
            this.ExportToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.ExportToolStripMenuItem.Text = "Сохранить как...";
            // 
            // графToolStripMenuItem
            // 
            this.графToolStripMenuItem.Name = "графToolStripMenuItem";
            this.графToolStripMenuItem.Size = new System.Drawing.Size(269, 26);
            this.графToolStripMenuItem.Text = "Граф (.json)";
            this.графToolStripMenuItem.Click += new System.EventHandler(this.графToolStripMenuItem_Click);
            // 
            // txtToolStripMenuItem
            // 
            this.txtToolStripMenuItem.Name = "txtToolStripMenuItem";
            this.txtToolStripMenuItem.Size = new System.Drawing.Size(269, 26);
            this.txtToolStripMenuItem.Text = "Список рёбер (.txt)";
            this.txtToolStripMenuItem.Click += new System.EventHandler(this.txtToolStripMenuItem_Click);
            // 
            // матрицаСмеожностиtxtToolStripMenuItem
            // 
            this.матрицаСмеожностиtxtToolStripMenuItem.Name = "матрицаСмеожностиtxtToolStripMenuItem";
            this.матрицаСмеожностиtxtToolStripMenuItem.Size = new System.Drawing.Size(269, 26);
            this.матрицаСмеожностиtxtToolStripMenuItem.Text = "Матрица смежности (.txt)";
            this.матрицаСмеожностиtxtToolStripMenuItem.Click += new System.EventHandler(this.матрицаСмеожностиtxtToolStripMenuItem_Click);
            // 
            // видToolStripMenuItem
            // 
            this.видToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.цветВершинToolStripMenuItem,
            this.цветВершинПриВыделенииToolStripMenuItem,
            this.размерВершинToolStripMenuItem});
            this.видToolStripMenuItem.Name = "видToolStripMenuItem";
            this.видToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.видToolStripMenuItem.Text = "Вид";
            // 
            // цветВершинToolStripMenuItem
            // 
            this.цветВершинToolStripMenuItem.Name = "цветВершинToolStripMenuItem";
            this.цветВершинToolStripMenuItem.Size = new System.Drawing.Size(297, 26);
            this.цветВершинToolStripMenuItem.Text = "Цвет вершин по умолчанию";
            this.цветВершинToolStripMenuItem.Click += new System.EventHandler(this.defaultVertexColorMenuItem_Click);
            // 
            // цветВершинПриВыделенииToolStripMenuItem
            // 
            this.цветВершинПриВыделенииToolStripMenuItem.Name = "цветВершинПриВыделенииToolStripMenuItem";
            this.цветВершинПриВыделенииToolStripMenuItem.Size = new System.Drawing.Size(297, 26);
            this.цветВершинПриВыделенииToolStripMenuItem.Text = "Цвет вершин при выделении";
            this.цветВершинПриВыделенииToolStripMenuItem.Click += new System.EventHandler(this.selectedVertexColorMenuItem_Click);
            // 
            // размерВершинToolStripMenuItem
            // 
            this.размерВершинToolStripMenuItem.Name = "размерВершинToolStripMenuItem";
            this.размерВершинToolStripMenuItem.Size = new System.Drawing.Size(297, 26);
            this.размерВершинToolStripMenuItem.Text = "Размер вершин";
            this.размерВершинToolStripMenuItem.Click += new System.EventHandler(this.vertexSizeMenuItem_Click);
            // 
            // алгоритмыToolStripMenuItem
            // 
            this.алгоритмыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dFSToolStripMenuItem1,
            this.bFSToolStripMenuItem1});
            this.алгоритмыToolStripMenuItem.Name = "алгоритмыToolStripMenuItem";
            this.алгоритмыToolStripMenuItem.Size = new System.Drawing.Size(102, 24);
            this.алгоритмыToolStripMenuItem.Text = "Алгоритмы";
            // 
            // dFSToolStripMenuItem1
            // 
            this.dFSToolStripMenuItem1.Name = "dFSToolStripMenuItem1";
            this.dFSToolStripMenuItem1.Size = new System.Drawing.Size(118, 26);
            this.dFSToolStripMenuItem1.Text = "DFS";
            this.dFSToolStripMenuItem1.Click += new System.EventHandler(this.dFSToolStripMenuItem1_Click);
            // 
            // bFSToolStripMenuItem1
            // 
            this.bFSToolStripMenuItem1.Name = "bFSToolStripMenuItem1";
            this.bFSToolStripMenuItem1.Size = new System.Drawing.Size(118, 26);
            this.bFSToolStripMenuItem1.Text = "BFS";
            this.bFSToolStripMenuItem1.Click += new System.EventHandler(this.bFSToolStripMenuItem1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dFSToolStripMenuItem,
            this.bFSToolStripMenuItem,
            this.removeVertexToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(201, 76);
            // 
            // dFSToolStripMenuItem
            // 
            this.dFSToolStripMenuItem.Name = "dFSToolStripMenuItem";
            this.dFSToolStripMenuItem.Size = new System.Drawing.Size(200, 24);
            this.dFSToolStripMenuItem.Text = "DFS";
            this.dFSToolStripMenuItem.Click += new System.EventHandler(this.dFSToolStripMenuItem_Click);
            // 
            // bFSToolStripMenuItem
            // 
            this.bFSToolStripMenuItem.Name = "bFSToolStripMenuItem";
            this.bFSToolStripMenuItem.Size = new System.Drawing.Size(200, 24);
            this.bFSToolStripMenuItem.Text = "BFS";
            this.bFSToolStripMenuItem.Click += new System.EventHandler(this.bFSToolStripMenuItem_Click);
            // 
            // removeVertexToolStripMenuItem
            // 
            this.removeVertexToolStripMenuItem.Name = "removeVertexToolStripMenuItem";
            this.removeVertexToolStripMenuItem.Size = new System.Drawing.Size(200, 24);
            this.removeVertexToolStripMenuItem.Text = "Удалить вершину";
            this.removeVertexToolStripMenuItem.Click += new System.EventHandler(this.removeVertexToolStripMenuItem_Click);
            // 
            // IsOrientedSwitch
            // 
            this.IsOrientedSwitch.AutoSize = true;
            this.IsOrientedSwitch.Location = new System.Drawing.Point(657, 42);
            this.IsOrientedSwitch.Name = "IsOrientedSwitch";
            this.IsOrientedSwitch.OffColor = System.Drawing.Color.Gainsboro;
            this.IsOrientedSwitch.OnColor = System.Drawing.Color.CornflowerBlue;
            this.IsOrientedSwitch.Size = new System.Drawing.Size(42, 21);
            this.IsOrientedSwitch.TabIndex = 11;
            this.IsOrientedSwitch.Text = "   ";
            this.IsOrientedSwitch.UseVisualStyleBackColor = true;
            this.IsOrientedSwitch.CheckedChanged += new System.EventHandler(this.IsOrientedSwitch_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(476, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Ориентированные рёбра";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(832, 453);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IsOrientedSwitch);
            this.Controls.Add(this.ResetBtn);
            this.Controls.Add(this.AddEdgeBtn);
            this.Controls.Add(this.RemoveVertexBtn);
            this.Controls.Add(this.AddVertexBtn);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Визуализатор графов";
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
        private System.Windows.Forms.Button ResetBtn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ImportToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dFSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bFSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeVertexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem алгоритмыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dFSToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem bFSToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem новыйФалйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem графToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem txtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem матрицаСмеожностиtxtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem видToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem цветВершинToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem цветВершинПриВыделенииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem размерВершинToolStripMenuItem;
        private ToggleSwitch IsOrientedSwitch;
        private System.Windows.Forms.Label label1;
    }
}

