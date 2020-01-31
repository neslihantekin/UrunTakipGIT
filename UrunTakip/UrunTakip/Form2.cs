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
    public partial class Form2 : Form
    {
        decimal number1, number2,number3;
        public Form2()
        {
            
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text!="" && textBox2.Text!="")
            {
                number1 = Convert.ToDecimal(textBox1.Text);
                number2 = Convert.ToDecimal(textBox2.Text);
                number3 = number1 * number2;
                textBox3.Text=number3.ToString();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                number1 = Convert.ToDecimal(textBox1.Text);
                number2 = Convert.ToDecimal(textBox2.Text);
                number3 = number1 * number2;
                textBox3.Text = number3.ToString();

            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
           

        }
    }
}
