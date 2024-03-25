
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
            this.AddVertexBtn = new System.Windows.Forms.Button();
            this.RemoveVertexBtn = new System.Windows.Forms.Button();
            this.AddEdgeBtn = new System.Windows.Forms.Button();
            this.DfsBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddVertexBtn
            // 
            this.AddVertexBtn.Location = new System.Drawing.Point(12, 12);
            this.AddVertexBtn.Name = "AddVertexBtn";
            this.AddVertexBtn.Size = new System.Drawing.Size(150, 40);
            this.AddVertexBtn.TabIndex = 1;
            this.AddVertexBtn.Text = "Добавить вершину";
            this.AddVertexBtn.UseVisualStyleBackColor = true;
            this.AddVertexBtn.Click += new System.EventHandler(this.AddVertexBtn_Click);
            // 
            // RemoveVertexBtn
            // 
            this.RemoveVertexBtn.Location = new System.Drawing.Point(177, 12);
            this.RemoveVertexBtn.Name = "RemoveVertexBtn";
            this.RemoveVertexBtn.Size = new System.Drawing.Size(150, 40);
            this.RemoveVertexBtn.TabIndex = 2;
            this.RemoveVertexBtn.Text = "Удалить вершину";
            this.RemoveVertexBtn.UseVisualStyleBackColor = true;
            this.RemoveVertexBtn.Click += new System.EventHandler(this.RemoveVertexBtn_Click);
            // 
            // AddEdgeBtn
            // 
            this.AddEdgeBtn.Location = new System.Drawing.Point(345, 12);
            this.AddEdgeBtn.Name = "AddEdgeBtn";
            this.AddEdgeBtn.Size = new System.Drawing.Size(150, 40);
            this.AddEdgeBtn.TabIndex = 3;
            this.AddEdgeBtn.Text = "Добавить ребро";
            this.AddEdgeBtn.UseVisualStyleBackColor = true;
            this.AddEdgeBtn.Click += new System.EventHandler(this.AddEdgeBtn_Click);
            // 
            // DfsBtn
            // 
            this.DfsBtn.Location = new System.Drawing.Point(513, 12);
            this.DfsBtn.Name = "DfsBtn";
            this.DfsBtn.Size = new System.Drawing.Size(150, 40);
            this.DfsBtn.TabIndex = 4;
            this.DfsBtn.Text = "DFS";
            this.DfsBtn.UseVisualStyleBackColor = true;
            this.DfsBtn.Click += new System.EventHandler(this.DfsBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(832, 453);
            this.Controls.Add(this.DfsBtn);
            this.Controls.Add(this.AddEdgeBtn);
            this.Controls.Add(this.RemoveVertexBtn);
            this.Controls.Add(this.AddVertexBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form_MouseClick);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button AddVertexBtn;
        private System.Windows.Forms.Button RemoveVertexBtn;
        private System.Windows.Forms.Button AddEdgeBtn;
        private System.Windows.Forms.Button DfsBtn;
    }
}

