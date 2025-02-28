namespace EmirBankBankamatik
{
    public partial class AnaEkran : Form
    {

        public decimal _bakiye;
        public AnaEkran(decimal bakiye)
        {
            InitializeComponent();
            _bakiye = bakiye;
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bizi tercih ettiðinniz için teþekkür eder, iyi günler dileriz.");
            Application.Exit();

        }

        private void btnBakiye_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Güncel bakiyeniz : {_bakiye} TL.");
        }

        private void btnParaCek_Click(object sender, EventArgs e)
        {
            this.Hide();
            ParaCek form3 = new ParaCek(_bakiye);
            form3.Show();

        }

        private void btnParaYatir_Click(object sender, EventArgs e)
        {
            this.Hide();
            ParaYatir form2 = new ParaYatir(_bakiye);
            form2.Show();
        }

        private void btnYeniGirisYap_Click(object sender, EventArgs e)
        {
            this.Hide();
            GirisYap girisYap = new GirisYap(_bakiye);
            girisYap.Show();
        }
    }
}
