namespace ders1_ornek2_finalcalismasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void hesaplabutton_Click(object sender, EventArgs e)
        {
            try
            {

                int number1, sonuc = 1;
                Console.WriteLine("Lütfen bir sayi giriniz :");
                number1 = Convert.ToInt32(sayigirstxt.Text);

                for (int i = 1; i <= number1; i++)
                {
                    sonuc *= i;
                }
                Sonuclbl.Text = ("Faktöriyeli alınan sayi: " + number1 + " ve sonucunuz : " + sonuc);
            }
            catch (Exception) 
            {
                Sonuclbl.Text = "Lütfen geçerli bir sayı giriniz! ";
            }
        }

        private void sayigirstxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblsayi_Click(object sender, EventArgs e)
        {

        }

        private void Sonuclbl_Click(object sender, EventArgs e)
        {

        }
    }
}
