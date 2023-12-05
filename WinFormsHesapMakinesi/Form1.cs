namespace WinFormsHesapMakinesi
{
    public partial class Form1 : Form
    {
        private char islem;
        private bool ekranTemizlensinMi;
        private double sayi1;
        private double sayi2;
        public Form1()
        {
            InitializeComponent();
        }

        private void rakam1Button_Click(object sender, EventArgs e)
        {
            if (ekranTemizlensinMi)
            {
                ekranLabel.Text = "";
                ekranTemizlensinMi = false;
            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";

            ekranLabel.Text += "1";
        }

        private void rakam2Button_Click(object sender, EventArgs e)
        {
            if (ekranTemizlensinMi)
            {
                ekranLabel.Text = "";
                ekranTemizlensinMi = false;
            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";

            ekranLabel.Text += "2";
        }

        private void rakam3Button_Click(object sender, EventArgs e)
        {
            if (ekranTemizlensinMi)
            {
                ekranLabel.Text = "";
                ekranTemizlensinMi = false;
            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";

            ekranLabel.Text += "3";
        }

        private void rakam4Button_Click(object sender, EventArgs e)
        {
            if (ekranTemizlensinMi)
            {
                ekranLabel.Text = "";
                ekranTemizlensinMi = false;
            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";

            ekranLabel.Text += "4";
        }

        private void rakam5Button_Click(object sender, EventArgs e)
        {
            if (ekranTemizlensinMi)
            {
                ekranLabel.Text = "";
                ekranTemizlensinMi = false;
            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";

            ekranLabel.Text += "5";
        }

        private void rakam6Button_Click(object sender, EventArgs e)
        {
            if (ekranTemizlensinMi)
            {
                ekranLabel.Text = "";
                ekranTemizlensinMi = false;
            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";

            ekranLabel.Text += "6";
        }

        private void rakam7Button_Click(object sender, EventArgs e)
        {
            if (ekranTemizlensinMi)
            {
                ekranLabel.Text = "";
                ekranTemizlensinMi = false;
            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";

            ekranLabel.Text += "7";
        }

        private void rakam8Button_Click(object sender, EventArgs e)
        {
            if (ekranTemizlensinMi)
            {
                ekranLabel.Text = "";
                ekranTemizlensinMi = false;
            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";

            ekranLabel.Text += "8";
        }

        private void rakam9Button_Click(object sender, EventArgs e)
        {
            if (ekranTemizlensinMi)
            {
                ekranLabel.Text = "";
                ekranTemizlensinMi = false;
            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";

            ekranLabel.Text += "9";
        }

        private void rakam0Button_Click(object sender, EventArgs e)
        {
            if (ekranTemizlensinMi)
            {
                ekranLabel.Text = "";
                ekranTemizlensinMi = false;
            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";

            ekranLabel.Text += "0";
        }

        private void artiButton_Click(object sender, EventArgs e)
        {
            islem = '+';
            ekranTemizlensinMi = true;
            sayi1 = double.Parse(ekranLabel.Text);
        }

        private void esittirButton_Click(object sender, EventArgs e)
        {
            sayi2 = double.Parse(ekranLabel.Text);
            double sonuc = 0;

            switch (islem)
            {
                case '+':
                    sonuc = sayi1 + sayi2;
                    break;
                case '-':
                    sonuc = sayi1 - sayi2;
                    break;
                case '*':
                    sonuc = sayi1 * sayi2;
                    break;
                case '/':
                    if (sayi2 != 0)
                        sonuc = sayi1 / sayi2;
                    else
                        MessageBox.Show("Bir sayýyý sýfýra bölemezsiniz!");
                    break;
                default:
                    break;
            }
            ekranLabel.Text = Convert.ToString(sonuc);
        }

        private void eksiButton_Click(object sender, EventArgs e)
        {
            islem = '-';
            ekranTemizlensinMi = true;
            sayi1 = double.Parse(ekranLabel.Text);
        }

        private void carpiButton_Click(object sender, EventArgs e)
        {
            islem = '*';
            ekranTemizlensinMi = true;
            sayi1 = double.Parse(ekranLabel.Text);
        }

        private void boluButton_Click(object sender, EventArgs e)
        {
            islem = '/';
            ekranTemizlensinMi = true;
            sayi1 = double.Parse(ekranLabel.Text);
        }

        private void temizlebutton_Click(object sender, EventArgs e)
        {
            ekranLabel.Text = "0";
        }
    }
}
