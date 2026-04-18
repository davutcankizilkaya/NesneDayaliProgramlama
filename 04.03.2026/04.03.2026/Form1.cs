using System;
using System.Windows.Forms;

namespace _04._03._2026
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int sayi1 = Convert.ToInt32(textBox1.Text);
                int sayi2 = Convert.ToInt32(textBox2.Text);

                int sonuc = sayi1 + sayi2;

                MessageBox.Show("Toplam Sonuç: " + sonuc);
            }
            catch
            {
                MessageBox.Show("Lütfen geçerli bir sayı giriniz!");
            }
        }
    }
}