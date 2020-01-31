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
    public partial class Ürün_İşlemleri : Form
    {
        public Ürün_İşlemleri()
        {
            InitializeComponent();
        }
        //Ürünler datagridinin güncellenmesini sağlayan method:
        public void RefreshDataGridUrunler()
        {
            DatasetTableAdapters.urunlerTableAdapter adaptor = new DatasetTableAdapters.urunlerTableAdapter();
            dataGridView1.DataSource = adaptor.GetUrunler();
        }
        private void urunListeleButonu_Click(object sender, EventArgs e)
        {
            //Ürünlerin listelenmesi:
            RefreshDataGridUrunler();
            
        }

        private void UrunEkleButonu_Click(object sender, EventArgs e)
        {
            if (uruncesiditext.Text.Length == 0 || markatext.Text.Length == 0 || modeltext.Text.Length == 0 || stoktext.Text.Length == 0 || birimFiyattext.Text.Length == 0)
            {
                MessageBox.Show("Değerleri kontrol ediniz. Boş bıraktığınız alan mevcut!");
            }
            else
            {
                //Ürün ekleme işlemi:
                DatasetTableAdapters.urunlerTableAdapter adaptor = new DatasetTableAdapters.urunlerTableAdapter();
                dataGridView1.DataSource = adaptor.urunEkle(uruncesiditext.Text, markatext.Text, modeltext.Text, Convert.ToInt32(stoktext.Text), Convert.ToDouble(birimFiyattext.Text));
                RefreshDataGridUrunler();
                MessageBox.Show("Ürün ekleme işlemi başarıyla tamamlandı.");
                this.Close();
            }
            
        }

        private void UrunSilButonu_Click(object sender, EventArgs e)
        {
            //Ürün silme işlemi:
            if (MessageBox.Show("Seçilen ürün silinecek! Emin misiniz?", "Sil Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
            {
                DataGridViewRow seciliSatir = dataGridView1.CurrentRow;
                int uID = Convert.ToInt32(seciliSatir.Cells["urunID"].Value.ToString());
                DatasetTableAdapters.urunlerTableAdapter adaptor = new DatasetTableAdapters.urunlerTableAdapter();
                adaptor.urunSil(uID);
                RefreshDataGridUrunler();
            }
            else
            {
                MessageBox.Show("Silme işlemi iptal edildi!");
            }
        }

        private void datayiUrunGuncellemeyeHazrHaleGetirenButon_Click(object sender, EventArgs e)
        {
            //Seçilen Ürünün özelliklerini textlere yerleştirip güncelleme işelemine hazır hale getirme:
            DataGridViewRow seciliSatir = dataGridView1.CurrentRow;
            uruncesiditext.Text = seciliSatir.Cells["ürüncesidi"].Value.ToString();
            markatext.Text = seciliSatir.Cells["markaAd"].Value.ToString();
            modeltext.Text = seciliSatir.Cells["modelAd"].Value.ToString();
            stoktext.Text = seciliSatir.Cells["stok"].Value.ToString();
            birimFiyattext.Text = seciliSatir.Cells["birimFiyat"].Value.ToString();
            
        }

        private void urunKaydetButonu_Click(object sender, EventArgs e)
        {
            //Ürün güncelleştirme işlemi(ürün IDsine göre):
            DataGridViewRow seciliSatir = dataGridView1.CurrentRow;
            DatasetTableAdapters.urunlerTableAdapter adaptor = new DatasetTableAdapters.urunlerTableAdapter();
            int uID = Convert.ToInt32(seciliSatir.Cells["urunID"].Value.ToString());
            adaptor.urunGuncelle(uruncesiditext.Text, markatext.Text, modeltext.Text, Convert.ToInt32(stoktext.Text), Convert.ToDouble(birimFiyattext.Text), uID);
            DatasetTableAdapters.urunlerTableAdapter adaptor2 = new DatasetTableAdapters.urunlerTableAdapter();
            dataGridView1.DataSource = adaptor2.GetUrunler();
            RefreshDataGridUrunler();
            MessageBox.Show("Güncelleme işlemi başarıyla tamamlandı.");


        }

        private void Ürün_İşlemleri_Load(object sender, EventArgs e)
        {
            //Ürünlerin listelenmesi:
            RefreshDataGridUrunler();
        }
    }
}
