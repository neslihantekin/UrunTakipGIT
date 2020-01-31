namespace UrunTakip
{
    partial class Form1
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
            this.FaturaislemleriButonu = new System.Windows.Forms.Button();
            this.SiparisislemleriButonu = new System.Windows.Forms.Button();
            this.UrunFormuGösterme = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.MusteriSilButonu = new System.Windows.Forms.Button();
            this.MusteriGüncelleButonu = new System.Windows.Forms.Button();
            this.MusteriEkleButonu = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Aramatext = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.raporlarButonu = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // FaturaislemleriButonu
            // 
            this.FaturaislemleriButonu.Location = new System.Drawing.Point(221, 151);
            this.FaturaislemleriButonu.Name = "FaturaislemleriButonu";
            this.FaturaislemleriButonu.Size = new System.Drawing.Size(188, 27);
            this.FaturaislemleriButonu.TabIndex = 15;
            this.FaturaislemleriButonu.Text = "Fatura İşlemleri";
            this.FaturaislemleriButonu.UseVisualStyleBackColor = true;
            this.FaturaislemleriButonu.Click += new System.EventHandler(this.FaturaislemleriButonu_Click);
            // 
            // SiparisislemleriButonu
            // 
            this.SiparisislemleriButonu.Location = new System.Drawing.Point(27, 151);
            this.SiparisislemleriButonu.Name = "SiparisislemleriButonu";
            this.SiparisislemleriButonu.Size = new System.Drawing.Size(188, 27);
            this.SiparisislemleriButonu.TabIndex = 14;
            this.SiparisislemleriButonu.Text = "Sipariş İşlemleri";
            this.SiparisislemleriButonu.UseVisualStyleBackColor = true;
            this.SiparisislemleriButonu.Click += new System.EventHandler(this.SiparisislemleriButonu_Click);
            // 
            // UrunFormuGösterme
            // 
            this.UrunFormuGösterme.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UrunFormuGösterme.Location = new System.Drawing.Point(455, 79);
            this.UrunFormuGösterme.Name = "UrunFormuGösterme";
            this.UrunFormuGösterme.Size = new System.Drawing.Size(209, 46);
            this.UrunFormuGösterme.TabIndex = 13;
            this.UrunFormuGösterme.Text = "ÜRÜN İŞLEMLERİ";
            this.UrunFormuGösterme.UseVisualStyleBackColor = true;
            this.UrunFormuGösterme.Click += new System.EventHandler(this.UrunFormuGösterme_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.MusteriSilButonu);
            this.groupBox2.Controls.Add(this.MusteriGüncelleButonu);
            this.groupBox2.Controls.Add(this.MusteriEkleButonu);
            this.groupBox2.Location = new System.Drawing.Point(27, 82);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(292, 52);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Müşteri İşlemleri";
            // 
            // MusteriSilButonu
            // 
            this.MusteriSilButonu.Location = new System.Drawing.Point(103, 18);
            this.MusteriSilButonu.Name = "MusteriSilButonu";
            this.MusteriSilButonu.Size = new System.Drawing.Size(81, 25);
            this.MusteriSilButonu.TabIndex = 3;
            this.MusteriSilButonu.Text = "SİL";
            this.MusteriSilButonu.UseVisualStyleBackColor = true;
            this.MusteriSilButonu.Click += new System.EventHandler(this.MusteriSilButonu_Click);
            // 
            // MusteriGüncelleButonu
            // 
            this.MusteriGüncelleButonu.Location = new System.Drawing.Point(190, 18);
            this.MusteriGüncelleButonu.Name = "MusteriGüncelleButonu";
            this.MusteriGüncelleButonu.Size = new System.Drawing.Size(81, 25);
            this.MusteriGüncelleButonu.TabIndex = 2;
            this.MusteriGüncelleButonu.Text = "GÜNCELLE";
            this.MusteriGüncelleButonu.UseVisualStyleBackColor = true;
            this.MusteriGüncelleButonu.Click += new System.EventHandler(this.MusteriGüncelleButonu_Click);
            // 
            // MusteriEkleButonu
            // 
            this.MusteriEkleButonu.Location = new System.Drawing.Point(16, 18);
            this.MusteriEkleButonu.Name = "MusteriEkleButonu";
            this.MusteriEkleButonu.Size = new System.Drawing.Size(81, 25);
            this.MusteriEkleButonu.TabIndex = 0;
            this.MusteriEkleButonu.Text = "EKLE";
            this.MusteriEkleButonu.UseVisualStyleBackColor = true;
            this.MusteriEkleButonu.Click += new System.EventHandler(this.MusteriEkleButonu_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.Aramatext);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(652, 53);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Arama";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Tümü",
            "TC",
            "İsim Soyisim",
            "Tel No",
            "E-posta"});
            this.comboBox1.Location = new System.Drawing.Point(306, 17);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // Aramatext
            // 
            this.Aramatext.Location = new System.Drawing.Point(7, 17);
            this.Aramatext.Multiline = true;
            this.Aramatext.Name = "Aramatext";
            this.Aramatext.Size = new System.Drawing.Size(293, 21);
            this.Aramatext.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(454, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 21);
            this.button1.TabIndex = 1;
            this.button1.Text = "Ara";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 194);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(652, 312);
            this.dataGridView1.TabIndex = 10;
            // 
            // raporlarButonu
            // 
            this.raporlarButonu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.raporlarButonu.Location = new System.Drawing.Point(455, 132);
            this.raporlarButonu.Name = "raporlarButonu";
            this.raporlarButonu.Size = new System.Drawing.Size(209, 46);
            this.raporlarButonu.TabIndex = 16;
            this.raporlarButonu.Text = "RAPORLAR";
            this.raporlarButonu.UseVisualStyleBackColor = true;
            this.raporlarButonu.Click += new System.EventHandler(this.raporlarButonu_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 518);
            this.Controls.Add(this.raporlarButonu);
            this.Controls.Add(this.FaturaislemleriButonu);
            this.Controls.Add(this.SiparisislemleriButonu);
            this.Controls.Add(this.UrunFormuGösterme);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button SiparisislemleriButonu;
        private System.Windows.Forms.Button MusteriSilButonu;
        private System.Windows.Forms.Button MusteriGüncelleButonu;
        private System.Windows.Forms.Button MusteriEkleButonu;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox Aramatext;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.Button FaturaislemleriButonu;
        public System.Windows.Forms.Button UrunFormuGösterme;
        public System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Button raporlarButonu;
    }
}

