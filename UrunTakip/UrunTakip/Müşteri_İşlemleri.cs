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
    public partial class Müşteri_İşlemleri : Form
    {
        private readonly Form1 frm;
        public Müşteri_İşlemleri(Form1 frm1)  
        {
            InitializeComponent();
            frm = frm1;
        }

        private void button1_Click(object sender, EventArgs e)
        {   
            //Girilen değerlerin boş olup olmadığının kontrolü:
            if (Adsoyadtext.Text.Length==0 || TCtext.Text.Length == 0 || Epostatext.Text.Length == 0 || Telefontext.Text.Length == 0 || Adrestext.Text.Length == 0 )
            {
                MessageBox.Show("Değerleri kontrol ediniz. Boş bıraktığınız alan mevcut!");
            }
            else //Müşteri datasına veri ekleme işlemleri:
            {
                DatasetTableAdapters.musteriKayitTableAdapter adaptor = new DatasetTableAdapters.musteriKayitTableAdapter();
                adaptor.musteriEkle(Adsoyadtext.Text, TCtext.Text, Epostatext.Text, Telefontext.Text, Adrestext.Text, Verginotext.Text, VergiDairesitext.Text);
                Form1 f = new Form1();
                f.dataGridView1.DataSource = adaptor.GetMusteriler();
                frm.RefreshDataGrid1();
                this.Close();
            }
            
        }
    }
}
