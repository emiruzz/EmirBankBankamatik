using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmirBankBankamatik
{
    public partial class GirisYap : Form
    {
        private decimal _bakiye;

        public GirisYap(decimal bakiye)
        {
            InitializeComponent();
            _bakiye = bakiye;
        }

        /// <summary>
        /// "Kayıt Ol" butonuna basıldığında, mevcut formu gizleyerek "MailKontrol" formunu açar.
        /// - Kullanıcıyı mail doğrulama sürecine yönlendirir.
        /// - Mevcut form kapanmaz, sadece gizlenir.
        /// - "MailKontrol" formu kapatılana kadar diğer işlemler bekletilir.
        /// </summary>
        /// <param name="sender">Olayı tetikleyen nesne</param>
        /// <param name="e">Olay verileri</param>
        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            this.Hide(); // Mevcut formu gizle
            MailKontrol mailKontrol = new MailKontrol();
            mailKontrol.ShowDialog(); // Mail kontrol formunu aç 

            //AnaEkran anaEkran = new(_bakiye);
            //anaEkran.ShowDialog();
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            string girilenKullaniciAdi = txtKullaniciAdi.Text;
            string girilenSifre = txtSifre.Text;

            // Kullanıcı listesinde arama yapıyor!!!!!!!!!
            var kullanici = KullaniciVeriTabani.KullaniciListesi.FirstOrDefault(k =>
                k.KullaniciAdi == girilenKullaniciAdi && k.Sifre == girilenSifre);

            if (kullanici != null)
            {
                MessageBox.Show("Giriş başarılı! Hoşgeldiniz " + kullanici.KullaniciAdi);
                this.Hide();
                AnaEkran anaEkran = new AnaEkran(_bakiye);
                anaEkran.Show();
            }
            else
            {
                MessageBox.Show("Hatalı kullanıcı adı veya şifre! Lütfen tekrar deneyiniz.");
            }
        }
    }
}
