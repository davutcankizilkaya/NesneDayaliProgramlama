using System.Diagnostics.Eventing.Reader;

namespace kapsülleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string isim;
        string soyisim;
        int tc;
        double hesapMiktari;

        KisilerBilgiler kb = new KisilerBilgiler();
        HesapBilgileri hb = new HesapBilgileri();
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                isim = Ad.Text;
                soyisim = Soyad.Text;
                tc = Convert.ToInt32(TCNo.Text);
                hesapMiktari = Convert.ToDouble(lblHesapMiktari.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (isim == kb.Ad && soyisim == kb.Soyad && tc == kb.TcNo)
            {
                MessageBox.Show("Kullanici Bilgileri Doğru");
                kb.Bilgiler = true;
                lblHesapMiktari.Text = hb.HesapToplami.ToString();
            }
            else
            {
                MessageBox.Show("Kullanici Bilgileri Yanlış,Tekrar Deneyiniz!");
                kb.Bilgiler = false;
            }

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (kb.Bilgiler == true)
            {
                double paraGonder = Convert.ToDouble(ParaMiktari.Text);

                if (paraGonder < hesapMiktari)
                {
                    hb.HesapToplami -= paraGonder;
                    lblHesapMiktari.Text = hb.HesapToplami.ToString();
                    MessageBox.Show("Para Gönderme İşlemi Başarılı! " + paraGonder + " Miktarda para gönderildi!");
                }
                else
                {
                    MessageBox.Show("Yetersiz Bakiye!");
                }
            }
            else
            {
                MessageBox.Show("Lütfen Kullanici Bilgilerini Dogru Giriniz!");
            }

        }
    }
}
