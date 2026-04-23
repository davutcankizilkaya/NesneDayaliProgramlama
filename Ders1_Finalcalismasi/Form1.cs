namespace Ders1_Finalcalismasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void hesapla_Click(object sender, EventArgs e)
        {
            int number1 = Convert.ToInt32(sayi1txt.Text);
            int number2 = Convert.ToInt32(sayi2txt.Text);

            int sum = number1 + number2;

            sonuc.Text = "Toplam: " + sum;
        }

        private void sonuc_Click(object sender, EventArgs e)
        {

        }
    }
}
