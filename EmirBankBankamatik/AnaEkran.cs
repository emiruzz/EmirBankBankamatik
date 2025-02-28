namespace EmirBankBankamatik
{
    public partial class AnaEkran : Form
    {
        private readonly Kullanici _kullanici;

        public AnaEkran(Kullanici kullanici)
        {
            InitializeComponent();
            _kullanici = kullanici;
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bizi tercih ettiðinniz için teþekkür eder, iyi günler dileriz.");
            Application.Exit();

        }

        private void btnBakiye_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Güncel bakiyeniz : {_kullanici.Bakiye} TL.");
        }

        private void btnParaCek_Click(object sender, EventArgs e)
        {
            this.Hide();
            ParaCek form3 = new ParaCek(_kullanici);
            form3.Show();

        }

        private void btnParaYatir_Click(object sender, EventArgs e)
        {
            this.Hide();
            ParaYatir form2 = new ParaYatir(_kullanici);
            form2.Show();
        }

        private void btnYeniGirisYap_Click(object sender, EventArgs e)
        {
            this.Hide();
            GirisYap girisYap = new GirisYap();
            girisYap.Show();
        }
    }
}
