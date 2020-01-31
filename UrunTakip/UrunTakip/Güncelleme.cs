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
    public partial class Güncelleme : Form
    {
        private readonly Form1 frm;
        public Güncelleme(Form1 frm1)
        {
            InitializeComponent();
            frm = frm1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Seçilen müşteri bilgilerinin güncelleme işlemleri(müşteri ıdsine göre):
            DatasetTableAdapters.musteriKayitTableAdapter adaptor = new DatasetTableAdapters.musteriKayitTableAdapter();
            adaptor.musteriGuncelle(Adsoyadtext.Text, TCtext.Text, Epostatext.Text, Telefontext.Text, Adrestext.Text, Verginotext.Text, VergiDairesitext.Text,Convert.ToInt32(label9.Text));
            DatasetTableAdapters.musteriKayitTableAdapter adaptor2 = new DatasetTableAdapters.musteriKayitTableAdapter();
            dataGridView1.DataSource = adaptor2.GetMusteriler();
            frm.RefreshDataGrid1();
            MessageBox.Show("Güncelleme işlemi başarıyla tamamlandı.");
            this.Close();
        }
    }
}
