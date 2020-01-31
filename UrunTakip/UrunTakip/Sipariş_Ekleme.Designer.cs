namespace UrunTakip
{
    partial class Sipariş_Ekleme
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridSiparisler = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridUrunler = new System.Windows.Forms.DataGridView();
            this.SipariseUrunEklemeButonu = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSiparisler)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUrunler)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridSiparisler);
            this.groupBox3.Location = new System.Drawing.Point(411, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(377, 451);
            this.groupBox3.TabIndex = 84;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Siparişler";
            // 
            // dataGridSiparisler
            // 
            this.dataGridSiparisler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSiparisler.Location = new System.Drawing.Point(6, 42);
            this.dataGridSiparisler.Name = "dataGridSiparisler";
            this.dataGridSiparisler.Size = new System.Drawing.Size(365, 394);
            this.dataGridSiparisler.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridUrunler);
            this.groupBox2.Location = new System.Drawing.Point(4, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(389, 451);
            this.groupBox2.TabIndex = 85;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ürünler";
            // 
            // dataGridUrunler
            // 
            this.dataGridUrunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridUrunler.Location = new System.Drawing.Point(6, 42);
            this.dataGridUrunler.Name = "dataGridUrunler";
            this.dataGridUrunler.Size = new System.Drawing.Size(377, 394);
            this.dataGridUrunler.TabIndex = 0;
            // 
            // SipariseUrunEklemeButonu
            // 
            this.SipariseUrunEklemeButonu.Location = new System.Drawing.Point(707, 469);
            this.SipariseUrunEklemeButonu.Name = "SipariseUrunEklemeButonu";
            this.SipariseUrunEklemeButonu.Size = new System.Drawing.Size(75, 23);
            this.SipariseUrunEklemeButonu.TabIndex = 86;
            this.SipariseUrunEklemeButonu.Text = "Ekle";
            this.SipariseUrunEklemeButonu.UseVisualStyleBackColor = true;
            this.SipariseUrunEklemeButonu.Click += new System.EventHandler(this.SipariseUrunEklemeButonu_Click);
            // 
            // Sipariş_Ekleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 508);
            this.Controls.Add(this.SipariseUrunEklemeButonu);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Sipariş_Ekleme";
            this.Text = "Sipariş_Ekleme";
            this.Load += new System.EventHandler(this.Sipariş_Ekleme_Load);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSiparisler)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUrunler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.DataGridView dataGridSiparisler;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridUrunler;
        private System.Windows.Forms.Button SipariseUrunEklemeButonu;
    }
}