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
    public partial class Sipariş_İşlemleri : Form
    {
        public Sipariş_İşlemleri()
        {
            InitializeComponent();
        }
        //Sipariş datagridinin güncellenmesini sağlayan method:
        public void RefreshSiparis()
        {
            DatasetTableAdapters.siparisTableAdapter adaptor = new DatasetTableAdapters.siparisTableAdapter();
            dataGridSiparisler.DataSource = adaptor.musteriIDyeAitSiparisGetir(Convert.ToInt32(label10.Text));
        }

        private void Sipariş_İşlemleri_Load(object sender, EventArgs e)
        {
            //Siparis formu yüklenir yüklenmez seçili müşteriye ait siparişlerin görüntülenmesi:
            RefreshSiparis();
            
        }

        private void SipariseUrunEklemeButonu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(texturunAdedi.Text))
            {
                MessageBox.Show("Ürün adedini boş bıraktınız! Lütfen uygun olarak doldurunuz.");
            }
            else
            {
                //Ürün adedi stok karşılaştırılması:
                int urunAdedi = Convert.ToInt32(texturunAdedi.Text);
                DataGridViewRow seciliSatir = dataGridUrunler.CurrentRow;
                int secilenUrununStok = Convert.ToInt32(seciliSatir.Cells["stok"].Value.ToString());
                if (urunAdedi > secilenUrununStok)
                {
                    MessageBox.Show("Stokta yeterli ürün yok! Uygun değer giriniz.");
                }
                else
                {   //Ürün adedi textinin boş olmama kontrolü:
                    if (string.IsNullOrWhiteSpace(texturunAdedi.Text))
                    {
                        MessageBox.Show("Ürün adedini boş bıraktınız! Lütfen uygun olarak doldurunuz.");
                    }
                    else
                    {   //Sipariş oluşturma:
                        int secilenUrununFiyat = Convert.ToInt32(seciliSatir.Cells["birimFiyat"].Value.ToString());
                        int tutarHesabi = urunAdedi * secilenUrununFiyat;
                        DatasetTableAdapters.siparisTableAdapter adaptor = new DatasetTableAdapters.siparisTableAdapter();
                        dataGridSiparisler.DataSource = adaptor.SiparisEkle(seciliSatir.Cells["markaAd"].Value.ToString(),
                            seciliSatir.Cells["modelAd"].Value.ToString(), urunAdedi, Convert.ToDouble(seciliSatir.Cells["birimFiyat"].Value.ToString()), tutarHesabi,
                            Convert.ToInt32(label10.Text), Convert.ToInt32(seciliSatir.Cells["urunID"].Value.ToString()));
                        RefreshSiparis();
                    }
                }
            }
            
        }

        private void comboUruncesidi_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Seçilin ürün çeşidinin özelliklerinin gösterilmesi:
            string comboDegeri = comboUruncesidi.Text;
            if (comboDegeri == "mouse")
            {
                DatasetTableAdapters.urunlerTableAdapter adaptor = new DatasetTableAdapters.urunlerTableAdapter();
                dataGridUrunler.DataSource = adaptor.mouseGetir();
            }
            else if (comboDegeri == "klavye")
            {
                DatasetTableAdapters.urunlerTableAdapter adaptor = new DatasetTableAdapters.urunlerTableAdapter();
                dataGridUrunler.DataSource = adaptor.klavyeGetir();
            }
            else if (comboDegeri == "harddisk")
            {
                DatasetTableAdapters.urunlerTableAdapter adaptor = new DatasetTableAdapters.urunlerTableAdapter();
                dataGridUrunler.DataSource = adaptor.harddiskGetir();
            }
            else if (comboDegeri == "işlemci")
            {
                DatasetTableAdapters.urunlerTableAdapter adaptor = new DatasetTableAdapters.urunlerTableAdapter();
                dataGridUrunler.DataSource = adaptor.islemciGetir();
            }
            else if (comboDegeri == "işletim sistemi")
            {
                DatasetTableAdapters.urunlerTableAdapter adaptor = new DatasetTableAdapters.urunlerTableAdapter();
                dataGridUrunler.DataSource = adaptor.isletimsistemiGetir();
            }
        }

        private void SiparisSilmeButonu_Click(object sender, EventArgs e)
        {
            //Sipariş silme işlemi:
            if (MessageBox.Show("Sipariş silinecek! Emin misiniz?", "Sil Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
            {
                DataGridViewRow seciliSatir = dataGridSiparisler.CurrentRow;
                int sID = Convert.ToInt32(seciliSatir.Cells["siparisNo"].Value.ToString());
                DatasetTableAdapters.siparisTableAdapter adaptor = new DatasetTableAdapters.siparisTableAdapter();
                adaptor.SiparisSil(sID);
                RefreshSiparis();
            }
            else
            {
                MessageBox.Show("Silme işlemi iptal edildi!");
            }
        }

        private void SiparislweiBitirmeButonu_Click(object sender, EventArgs e)
        {
            //Seçilen ürünün sipariş olarak eklenip ürün stoğunun azaltılması:
            int urunAdedi = Convert.ToInt32(texturunAdedi.Text);
            DataGridViewRow seciliSatir = dataGridUrunler.CurrentRow;
            int seclenUrununID = Convert.ToInt32(dataGridUrunler.CurrentRow.Cells["urunID"].Value);
            DatasetTableAdapters.urunlerTableAdapter adaptor = new DatasetTableAdapters.urunlerTableAdapter();
            adaptor.stokAzalt(Convert.ToString(urunAdedi),seclenUrununID);
            this.Close();
        }
    }
}
