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
    public partial class Raporlar : Form
    {
        public Raporlar()
        {
            InitializeComponent();
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {   //Müşteri sayılarının gösterilmesi:
            DatasetTableAdapters.musteriKayitTableAdapter adaptor = new DatasetTableAdapters.musteriKayitTableAdapter();
            dataGridRapor.DataSource = adaptor.GetMusteriler();
            labelBilgi.Text = Convert.ToString(adaptor.musteriSayilar());

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox2_Click(object sender, EventArgs e)
        {
            //Sipariş sayılarının gösterilmesi:
            DatasetTableAdapters.siparisTableAdapter adaptor = new DatasetTableAdapters.siparisTableAdapter();
            dataGridRapor.DataSource = adaptor.GetSiparis();
            labelBilgi.Text = Convert.ToString(adaptor.siparisSayilar());
        }

        private void toolStripTextBox3_Click(object sender, EventArgs e)
        {
            //Fatura sayılarının gösterilmesi:
            DatasetTableAdapters.faturaTableAdapter adaptor = new DatasetTableAdapters.faturaTableAdapter();
            dataGridRapor.DataSource = adaptor.faturaGetir();
            labelBilgi.Text = Convert.ToString(adaptor.faturaSayilar());
        }
    }
}
