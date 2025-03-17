using System.Net;
using System.Net.Mail;

namespace EmirBankBankamatik
{
    public partial class MailKontrol : Form
    {


        public MailKontrol()
        {

            InitializeComponent();
        }

        /// <summary>
        /// Kullanıcının e-posta adresine rastgele bir şifre gönderir.
        /// - Onay kutusu işaretlenmemişse uyarı verir.
        /// - Geçerli bir e-posta adresi girilmemişse uyarı verir.
        /// - Rastgele şifre oluşturur ve e-posta ile gönderir.
        /// - Şifre başarıyla gönderildiyse, kullanıcıyı kayıt ekranına yönlendirir.
        /// </summary>
        /// <param name="sender">Olayı tetikleyen buton</param>
        /// <param name="e">Olay verisi</param>
        private void btnSifreAl_Click(object sender, EventArgs e)
        {
            try
            {
                if (!chcOnayliyorum.Checked)
                {
                    MessageBox.Show("Lütfen işleminize devam edebilmek için onay veriniz!");
                    return;
                }

                string girilenMail = txtMail.Text.Trim();

                if (string.IsNullOrWhiteSpace(girilenMail))
                {
                    MessageBox.Show("Lütfen mail adresinizi tuşlayınız!");
                    return;
                }

                if (!girilenMail.Contains("@"))
                {
                    MessageBox.Show("Lütfen @ işaretini tuşlayarak mail adresinizi giriniz!");
                    return;
                }

                if(!girilenMail.EndsWith(".com"))
                {
                    MessageBox.Show("Lütfen mail adresinizin sonuna .com ekleyiniz!");
                    return;
                }

                string yeniSifre = RastgeleSifreOlustur();
                bool mailGonderildi = SifreyiMailGonder(girilenMail, yeniSifre);

                if (mailGonderildi)
                {
                    MessageBox.Show("Şifreniz gönderildi! Lütfen mail adresinizi kontrol ediniz.");
                    this.Hide();
                    Kayit kayit = new Kayit(yeniSifre);
                    kayit.Show();
                }
                else
                {
                    MessageBox.Show("Mail gönderme işlemi başarısız oldu. Lütfen daha sonra tekrar deneyin.");
                    
                }
              
            }
            catch (Exception ex)
            {
                MessageBox.Show("Beklenmeyen bir hata oluştu!");
            }
        }

        /// <summary>
        /// 6 haneli rastgele bir şifre oluşturur.
        /// - Şifre, 100000 ile 999999 arasında rastgele bir sayıdan oluşur.
        /// - Sayısal değer olarak üretilen şifre, string olarak döndürülür.
        /// </summary>
        /// <returns>Oluşturulan 6 haneli rastgele şifre</returns>
        private string RastgeleSifreOlustur()
        {
            Random rnd = new Random();
            int gelenSifre = rnd.Next(100000, 999999);
            return gelenSifre.ToString();
        }

        /// <summary>
        /// Belirtilen alıcı e-posta adresine, gelen şifreyi içeren bir e-posta gönderir.
        /// - Gmail SMTP sunucusunu kullanarak e-posta gönderme işlemi gerçekleştirir.
        /// - Şifre talep eden kullanıcıya, 6 haneli şifreyi içeren bir mesaj yollar.
        /// - Mail gönderimi başarılı olursa `true`, hata oluşursa `false` döndürür.
        /// </summary>
        /// <param name="aliciMail">Şifrenin gönderileceği e-posta adresi</param>
        /// <param name="gelenSifre">Kullanıcıya gönderilecek rastgele şifre</param>
        /// <returns>Mail başarıyla gönderildiyse `true`, hata oluşursa `false`</returns>           
        private bool SifreyiMailGonder(string aliciMail, string gelenSifre)
        {
            try
            {
                string gonderenMail = "emiruz.yzl@gmail.com";
                string gonderenSifre = "***************";

                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                smtp.Credentials = new NetworkCredential(gonderenMail, gonderenSifre);
                smtp.EnableSsl = true;

                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(gonderenMail);
                mail.To.Add(aliciMail);
                mail.Subject = "Şifre Talebi";
                mail.Body = "Merhaba,\n\nTalep ettiğiniz 6 haneli şifreniz: " + gelenSifre + "\n\nİyi günler dileriz!";
                mail.IsBodyHtml = false;

                smtp.Send(mail);
                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Mail gönderme hatası: " + ex.Message);
                return false;
            }
        }
    }
}

