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
    public partial class Fatura : Form
    {
        
        public Fatura()
        {
            InitializeComponent();
            
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void Fatura_Load(object sender, EventArgs e)
        {
            
        }

        private void onaylaButonu_Click(object sender, EventArgs e)
        {
            //Seçilen siparişe fatura kesilmesi:
            DatasetTableAdapters.faturaTableAdapter adaptor = new DatasetTableAdapters.faturaTableAdapter();
            adaptor.faturaEkle(Convert.ToInt32(label15.Text), label6.Text, label14.Text, label16.Text, label17.Text, 
                label18.Text, label19.Text, Convert.ToInt32(label20.Text), Convert.ToInt32(label23.Text), 
                Convert.ToInt32(label22.Text), Convert.ToInt32(label21.Text));
            DatasetTableAdapters.siparisTableAdapter adaptor2 = new DatasetTableAdapters.siparisTableAdapter();
            adaptor2.tamamlandıYap(Convert.ToInt32(label15.Text));
            MessageBox.Show("Fatura Kesildi!");
            this.Close();
           
            
        }
    }
}
