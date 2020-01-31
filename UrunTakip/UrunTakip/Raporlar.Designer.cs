namespace UrunTakip
{
    partial class Raporlar
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
            this.labelBilgi = new System.Windows.Forms.Label();
            this.dataGridRapor = new System.Windows.Forms.DataGridView();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripTextBox3 = new System.Windows.Forms.ToolStripTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRapor)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelBilgi
            // 
            this.labelBilgi.Location = new System.Drawing.Point(104, 387);
            this.labelBilgi.Name = "labelBilgi";
            this.labelBilgi.Size = new System.Drawing.Size(98, 12);
            this.labelBilgi.TabIndex = 5;
            // 
            // dataGridRapor
            // 
            this.dataGridRapor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridRapor.Location = new System.Drawing.Point(12, 30);
            this.dataGridRapor.Name = "dataGridRapor";
            this.dataGridRapor.Size = new System.Drawing.Size(727, 327);
            this.dataGridRapor.TabIndex = 4;
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.ReadOnly = true;
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBox1.Text = "Müşteriler";
            this.toolStripTextBox1.Click += new System.EventHandler(this.toolStripTextBox1_Click);
            // 
            // toolStripTextBox2
            // 
            this.toolStripTextBox2.Name = "toolStripTextBox2";
            this.toolStripTextBox2.ReadOnly = true;
            this.toolStripTextBox2.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBox2.Text = "Siparişler";
            this.toolStripTextBox2.Click += new System.EventHandler(this.toolStripTextBox2_Click);
            // 
            // toolStripTextBox3
            // 
            this.toolStripTextBox3.Name = "toolStripTextBox3";
            this.toolStripTextBox3.ReadOnly = true;
            this.toolStripTextBox3.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBox3.Text = "Faturalar";
            this.toolStripTextBox3.Click += new System.EventHandler(this.toolStripTextBox3_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox1,
            this.toolStripTextBox2,
            this.toolStripTextBox3});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(745, 27);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 387);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Toplam:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Raporlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 425);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelBilgi);
            this.Controls.Add(this.dataGridRapor);
            this.Controls.Add(this.menuStrip1);
            this.MaximizeBox = false;
            this.Name = "Raporlar";
            this.Text = "Raporlar";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRapor)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelBilgi;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.DataGridView dataGridRapor;
        private System.Windows.Forms.Label label1;
    }
}