using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UrunTakip
{
    public partial class Sipariş_Ekleme : Form
    {
        public Sipariş_Ekleme()
        {
            InitializeComponent();
        }

        private void Sipariş_Ekleme_Load(object sender, EventArgs e)
        {


            
            
        }

        private void SipariseUrunEklemeButonu_Click(object sender, EventArgs e)
        {
            /*Sipariş_İşlemleri Siparisfrm = new Sipariş_İşlemleri();
            DataGridViewRow seciliSatir = Siparisfrm.dataGridUrunler.CurrentRow;
            string secilenUrununID = Siparisfrm.dataGridUrunler.CurrentRow.Cells["urunID"].Value.ToString();
            DatasetTableAdapters.urunlerTableAdapter adaptor = new DatasetTableAdapters.urunlerTableAdapter();
            dataGridUrunler.DataSource = adaptor.secilenUrununstok(Convert.ToInt32(secilenUrununID));
            DataGridViewRow seciliSatirSiparis = dataGridSiparisler.CurrentRow;
            int seclenUrununstok = Convert.ToInt32(dataGridSiparisler.CurrentRow.Cells["stok"].Value.ToString());
            
            
            //Ürün adediyle stok miktarının karşılaştırılması:
            int urunAdedi = Convert.ToInt32(Siparisfrm.texturunAdedi.Text);
            
            
            if (urunAdedi > seclenUrununstok)
            {
                MessageBox.Show("Stok müsait değil! Ürün adedini kontrol ediniz.");
            }

            this.Close();*/
        }
    }
}
