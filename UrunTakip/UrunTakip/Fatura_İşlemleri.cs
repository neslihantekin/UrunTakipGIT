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
    public partial class Fatura_İşlemleri : Form
    {
        public Fatura_İşlemleri()
        {
           
            InitializeComponent();

        }
        public void faturatutarHesaplama()
        {
            //kcv ve iskontoya göre fatura hesabı:
            DataGridViewRow seciliSatir = dataGridsiparisFatura.CurrentRow;
            int gelenTutar = Convert.ToInt32(seciliSatir.Cells["tutar"].Value.ToString());
            int kdvtutar = gelenTutar / 100 * Convert.ToInt32(textKdv.Text);
            int iskontoTutar = gelenTutar / 100 * Convert.ToInt32(textIskonto.Text);
            textFaturatutarı.Text = Convert.ToString(gelenTutar + kdvtutar - iskontoTutar);
        }
        public void bekleyensiparisGetir()
        {
            //Belirtilen müşteri IDsinin bekleyen sirapişlerin listelenmesi:
            DatasetTableAdapters.siparisTableAdapter adaptor = new DatasetTableAdapters.siparisTableAdapter();
            dataGridsiparisFatura.DataSource = adaptor.bekliyorGetir(Convert.ToInt32(label10.Text));
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void Fatura_İşlemleri_Load(object sender, EventArgs e)
        {
            //Sipariş oluşturlmadan fatura kesmek istendiğinde kontrolün yapılması durumunda önce sipariş oluşturulmasının sağlanması:
            DatasetTableAdapters.siparisTableAdapter adaptor = new DatasetTableAdapters.siparisTableAdapter();
            int bekleyenSayisi = Convert.ToInt32(adaptor.bekleyenSiparisSayisi(Convert.ToInt32(label10.Text)));
            if (bekleyenSayisi==0)
            {
                MessageBox.Show("Faturalandırılacak siparişiniz yok! Öncelikle sipariş oluşturunuz.");
                this.Close();
            }
            else
            {
                bekleyensiparisGetir();
            }
            
        }

        private void dataGridsiparisFatura_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {

        }

        private void textKdv_TextChanged(object sender, EventArgs e)
        {
            //Textdeki anlık değişime göre fatura hesabının yapılması
            //textboxın boş olmaması durumunda hesaplama işlemi yapılır
            if (textKdv.Text != "" && textIskonto.Text != "")
            {
                faturatutarHesaplama();
            }
        }

        private void textIskonto_TextChanged(object sender, EventArgs e)
        {
            //Textdeki anlık değişime göre fatura hesabının yapılması
            //textboxın boş olmaması durumunda hesaplama işlemi yapılır
            if (textKdv.Text != "" && textIskonto.Text != "")
            {
                faturatutarHesaplama();
            }
        }

        private void dataGridsiparisFatura_SelectionChanged(object sender, EventArgs e)
        {
            //KDV=18 ve iskonto=0 varsayılan değerleri için form yüklenir yüklenmez fatura hesabı yapılır
            DataGridViewRow seciliSatir = dataGridsiparisFatura.CurrentRow;
            int gelenTutar = Convert.ToInt32(seciliSatir.Cells["tutar"].Value.ToString());
            textKdv.Text = "18";
            textIskonto.Text = "0";
            int kdvtutar = gelenTutar / 100 * Convert.ToInt32(textKdv.Text);
            int iskontoTutar = gelenTutar / 100 * Convert.ToInt32(textIskonto.Text);
            textFaturatutarı.Text = Convert.ToString(gelenTutar + kdvtutar - iskontoTutar);

        }

        private void faturaKesButonu_Click(object sender, EventArgs e)
        {
            //Seçilen faturanın kesilmesinden önce bilgilerin fatura formunda görüntülenmesi:
            Fatura f = new Fatura();
            DataGridViewRow seciliSatir = dataGridsiparisFatura.CurrentRow;
            f.label6.Text = label13.Text;
            f.label14.Text = label17.Text;
            f.label15.Text = seciliSatir.Cells["siparisNo"].Value.ToString();
            f.label16.Text = dateTimePicker1.Text;
            f.label17.Text = label18.Text;
            f.label18.Text = label19.Text;
            f.label19.Text = seciliSatir.Cells["modelAd"].Value.ToString();
            f.label20.Text = seciliSatir.Cells["ürünAdedi"].Value.ToString();
            f.label21.Text = seciliSatir.Cells["birimFiyat"].Value.ToString();
            f.label24.Text = seciliSatir.Cells["birim"].Value.ToString();
            f.label22.Text = textKdv.Text;
            f.label23.Text = textFaturatutarı.Text;
            f.ShowDialog();
        }

        private void kesilmişFaturalarButonu_Click(object sender, EventArgs e)
        {
            //Kesilmiş tüm faturaların görüntülenmesi:
            Kesilmiş_Faturalar f = new Kesilmiş_Faturalar();
            DatasetTableAdapters.faturaTableAdapter adaptor = new DatasetTableAdapters.faturaTableAdapter();
            f.dataGridView1.DataSource = adaptor.faturaGetir();
            f.ShowDialog();

        }

        private void faturaislemleriKapatButonu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void siparisListesiYenileButonu_Click(object sender, EventArgs e)
        {
            //Fatura kesildikten sonra bu buton sayesinde bekleyen siparişler listesinin güncellenmesi sağlanacak
            bekleyensiparisGetir();
        }
    }
}