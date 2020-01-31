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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Müşteri datagridinin güncellenmesini sağlayan method:
        public void RefreshDataGrid1()
        {
            DatasetTableAdapters.musteriKayitTableAdapter adaptor = new DatasetTableAdapters.musteriKayitTableAdapter();
            dataGridView1.DataSource = adaptor.GetMusteriler();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string comboDegeri = comboBox1.Text;
            if (comboDegeri == "Tümü")
            {
                DatasetTableAdapters.musteriKayitTableAdapter adaptor = new DatasetTableAdapters.musteriKayitTableAdapter();
                dataGridView1.DataSource = adaptor.GetMusteriler();
            }
            
            else
            {   //Arama textinin boş olup olmama kontrolü:
                if (string.IsNullOrWhiteSpace(Aramatext.Text))
                {
                    MessageBox.Show("Arama kısmını boş bıraktınız! Lütfen uygun olarak doldurunuz.");
                }
                //Comboboxda seçilen değere göre müşteri verilerini getirme:       
                if (comboDegeri == "TC")
                {
                    DatasetTableAdapters.musteriKayitTableAdapter adaptor = new DatasetTableAdapters.musteriKayitTableAdapter();
                    dataGridView1.DataSource = adaptor.TcyeAitMusteriGetir(Aramatext.Text);
                }
                else if (comboDegeri == "İsim Soyisim")
                {
                    DatasetTableAdapters.musteriKayitTableAdapter adaptor = new DatasetTableAdapters.musteriKayitTableAdapter();
                    dataGridView1.DataSource = adaptor.adsoyadaAitMusteriGetir(Aramatext.Text);
                }
                else if (comboDegeri == "E-posta")
                {
                    DatasetTableAdapters.musteriKayitTableAdapter adaptor = new DatasetTableAdapters.musteriKayitTableAdapter();
                    dataGridView1.DataSource = adaptor.epostayaAitMusteriGetir(Aramatext.Text);
                }
                else if (comboDegeri == "Tel No")
                {
                    DatasetTableAdapters.musteriKayitTableAdapter adaptor = new DatasetTableAdapters.musteriKayitTableAdapter();
                    dataGridView1.DataSource = adaptor.telnoyaAitMusteriGetir(Aramatext.Text);
                }
                else //Comboboxın boş olup olmama kontrolü:
                {
                    MessageBox.Show("Yanlış seçtiniz veya boş bıraktınız! Lütfen uygun olarak doldurunuz.");
                }
            }
            
        }

        private void MusteriEkleButonu_Click(object sender, EventArgs e)
        {   
            //Ana sayfadaki müşteri ekleme butonuna tıklandığında müşteri işlemlerinin formunu açılması:
            Müşteri_İşlemleri goster = new Müşteri_İşlemleri(this);
            goster.Show();
        }

        private void MusteriGüncelleButonu_Click(object sender, EventArgs e)
        {
            //Anasayfa formunda seçili olan müşteri bilgilerini güncelleme formuna getirme:
            DataGridViewRow seciliSatir = dataGridView1.CurrentRow;
            Güncelleme f = new Güncelleme(this);
            f.Adsoyadtext.Text = seciliSatir.Cells["ADSOYAD"].Value.ToString();
            f.TCtext.Text = seciliSatir.Cells["TC"].Value.ToString();
            f.Epostatext.Text = seciliSatir.Cells["EPOSTA"].Value.ToString();
            f.Telefontext.Text = seciliSatir.Cells["TELEFON"].Value.ToString();
            f.Adrestext.Text = seciliSatir.Cells["ADRES"].Value.ToString();
            f.Verginotext.Text = seciliSatir.Cells["VERGINO"].Value.ToString();
            f.VergiDairesitext.Text = seciliSatir.Cells["VERGIDAIRESI"].Value.ToString();
            f.label9.Text = seciliSatir.Cells["musteriID"].Value.ToString();
            f.ShowDialog();
        }

        private void MusteriSilButonu_Click(object sender, EventArgs e)
        {
            //Müşteri silme işlemi:
            if (MessageBox.Show("Müşteri silinecek! Emin misiniz?","Sil Onayı",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)==System.Windows.Forms.DialogResult.Yes)
            {
                DataGridViewRow seciliSatir = dataGridView1.CurrentRow;
                int mID = Convert.ToInt32(seciliSatir.Cells["musteriID"].Value.ToString());
                DatasetTableAdapters.musteriKayitTableAdapter adaptor = new DatasetTableAdapters.musteriKayitTableAdapter();
                adaptor.musteriSil(mID);
                RefreshDataGrid1();
            }
            else
            {
                MessageBox.Show("Silme işlemi iptal edildi!");
            }
        }

        private void UrunFormuGösterme_Click(object sender, EventArgs e)
        {
            Ürün_İşlemleri goster = new Ürün_İşlemleri();
            goster.Show();
        }

        private void SiparisislemleriButonu_Click(object sender, EventArgs e)
        {
            //Seçilen müşterinin bilgilerini sipariş işlemleri formuna açılır açılmaz yerleştirme işlemi:
            DataGridViewRow seciliSatir = dataGridView1.CurrentRow;
            Sipariş_İşlemleri f = new Sipariş_İşlemleri();
            f.label10.Text = seciliSatir.Cells["musteriID"].Value.ToString();
            f.label13.Text = seciliSatir.Cells["ADSOYAD"].Value.ToString();
            f.label14.Text = seciliSatir.Cells["TC"].Value.ToString();
            f.label15.Text = seciliSatir.Cells["EPOSTA"].Value.ToString();
            f.label16.Text = seciliSatir.Cells["TELEFON"].Value.ToString();
            f.label17.Text = seciliSatir.Cells["ADRES"].Value.ToString();
            f.label18.Text = seciliSatir.Cells["VERGINO"].Value.ToString();
            f.label19.Text = seciliSatir.Cells["VERGIDAIRESI"].Value.ToString();
            f.ShowDialog();
        }

        private void FaturaislemleriButonu_Click(object sender, EventArgs e)
        {
            //Seçilen müşterinin bilgilerini fatura işlemleri formuna aktarılması: 
            DataGridViewRow seciliSatir = dataGridView1.CurrentRow;
            Fatura_İşlemleri f = new Fatura_İşlemleri();
            f.label10.Text = seciliSatir.Cells["musteriID"].Value.ToString();
            f.label13.Text = seciliSatir.Cells["ADSOYAD"].Value.ToString();
            f.label14.Text = seciliSatir.Cells["TC"].Value.ToString();
            f.label15.Text = seciliSatir.Cells["EPOSTA"].Value.ToString();
            f.label16.Text = seciliSatir.Cells["TELEFON"].Value.ToString();
            f.label17.Text = seciliSatir.Cells["ADRES"].Value.ToString();
            f.label18.Text = seciliSatir.Cells["VERGINO"].Value.ToString();
            f.label19.Text = seciliSatir.Cells["VERGIDAIRESI"].Value.ToString();
            f.ShowDialog();
        }

        private void raporlarButonu_Click(object sender, EventArgs e)
        {
            Raporlar goster = new Raporlar();
            goster.ShowDialog();
        }
    }
}
