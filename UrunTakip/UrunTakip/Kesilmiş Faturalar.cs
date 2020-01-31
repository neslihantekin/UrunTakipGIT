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
    public partial class Kesilmiş_Faturalar : Form
    {
        public Kesilmiş_Faturalar()
        {
            InitializeComponent();
        }

        private void kapatButonu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Listeden seçilen faturanın alt taraftaki labellarda bilgilerinin gösterilmesi:
            DataGridViewRow seciliSatir = dataGridView1.CurrentRow;
            label6.Text= seciliSatir.Cells["ADSOYAD"].Value.ToString();
            label14.Text = seciliSatir.Cells["ADRES"].Value.ToString();
            label15.Text = seciliSatir.Cells["siparisNo"].Value.ToString();
            label16.Text = seciliSatir.Cells["tarih"].Value.ToString();
            label17.Text = seciliSatir.Cells["VERGINO"].Value.ToString();
            label18.Text = seciliSatir.Cells["VERGIDAIRESI"].Value.ToString();
            label19.Text = seciliSatir.Cells["modelAd"].Value.ToString();
            label20.Text = seciliSatir.Cells["ürünAdedi"].Value.ToString();
            label21.Text = seciliSatir.Cells["birimFiyat"].Value.ToString();
            label22.Text = seciliSatir.Cells["KDV"].Value.ToString();
            label23.Text = seciliSatir.Cells["toplamTutar"].Value.ToString();
            label24.Text = seciliSatir.Cells["birim"].Value.ToString();


        }

        private void Kesilmiş_Faturalar_Load(object sender, EventArgs e)
        {

        }
    }
}
