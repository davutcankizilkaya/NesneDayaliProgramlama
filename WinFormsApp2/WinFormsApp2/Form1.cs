using System;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //KLavyeden okutulan iki sayının toplamını veren program
        private void hesapla_Click(object sender, EventArgs e)
        {


            try
            {
                int number1 = Convert.ToInt32(textBox1.Text);
                int number2 = Convert.ToInt32(textBox2.Text);

                int sum = number1 + number2;

                label3.Text = "Toplam: " + sum;
            }
            catch
            {
                MessageBox.Show("Lütfen geçerli bir sayı girin.");
            }
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
