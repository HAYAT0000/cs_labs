namespace lab9
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pnkt1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pnkt2 = new System.Windows.Forms.ToolStripMenuItem();
            this.ppnkt1_1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ppnkt1_2 = new System.Windows.Forms.ToolStripMenuItem();
            this.ppnkt2_1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ppnkt2_2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pnkt1,
            this.pnkt2});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pnkt1
            // 
            this.pnkt1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ppnkt1_1,
            this.ppnkt1_2});
            this.pnkt1.Name = "pnkt1";
            this.pnkt1.Size = new System.Drawing.Size(61, 20);
            this.pnkt1.Text = "Пункт 1";
            this.pnkt1.Click += new System.EventHandler(this.pnkt1_Click);
            // 
            // pnkt2
            // 
            this.pnkt2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ppnkt2_1,
            this.ppnkt2_2});
            this.pnkt2.Name = "pnkt2";
            this.pnkt2.Size = new System.Drawing.Size(61, 20);
            this.pnkt2.Text = "Пункт 2";
            this.pnkt2.Click += new System.EventHandler(this.pnkt2_Click);
            // 
            // ppnkt1_1
            // 
            this.ppnkt1_1.Name = "ppnkt1_1";
            this.ppnkt1_1.Size = new System.Drawing.Size(180, 22);
            this.ppnkt1_1.Text = "Подпункт 1.1";
            this.ppnkt1_1.Click += new System.EventHandler(this.ppnkt1_1_Click);
            // 
            // ppnkt1_2
            // 
            this.ppnkt1_2.Name = "ppnkt1_2";
            this.ppnkt1_2.Size = new System.Drawing.Size(180, 22);
            this.ppnkt1_2.Text = "Подпункт 1.2";
            this.ppnkt1_2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.ppnkt1_2.Click += new System.EventHandler(this.ppnkt1_2_Click);
            // 
            // ppnkt2_1
            // 
            this.ppnkt2_1.Name = "ppnkt2_1";
            this.ppnkt2_1.Size = new System.Drawing.Size(180, 22);
            this.ppnkt2_1.Text = "Подпункт 2.1";
            this.ppnkt2_1.Click += new System.EventHandler(this.ppnkt2_1_Click);
            // 
            // ppnkt2_2
            // 
            this.ppnkt2_2.Name = "ppnkt2_2";
            this.ppnkt2_2.Size = new System.Drawing.Size(180, 22);
            this.ppnkt2_2.Text = "Подпункт 2.2";
            this.ppnkt2_2.Click += new System.EventHandler(this.ppnkt2_2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pnkt1;
        private System.Windows.Forms.ToolStripMenuItem ppnkt1_1;
        private System.Windows.Forms.ToolStripMenuItem ppnkt1_2;
        private System.Windows.Forms.ToolStripMenuItem pnkt2;
        private System.Windows.Forms.ToolStripMenuItem ppnkt2_1;
        private System.Windows.Forms.ToolStripMenuItem ppnkt2_2;
    }
}

