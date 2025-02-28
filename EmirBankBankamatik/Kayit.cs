using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmirBankBankamatik
{
    public partial class Kayit : Form
    {
        
        private string _gelenSifre;
        string _realPass = "";

        public Kayit(string gelenSifre)
        {
            InitializeComponent();
            _gelenSifre = gelenSifre;                              
        }

        /// <summary>
        /// Kayıt formu yüklendiğinde, gerekli başlangıç ayarlarını yapar:
        /// - Kullanıcı giriş alanlarını devre dışı bırakır.
        /// - Şifre giriş kutularını temizler.
        /// - Şifre doğrulaması ve otomatik geçiş için gerekli olayları tanımlar.
        /// </summary>
        /// <param name="sender">Olayı tetikleyen nesne (Form)</param>
        /// <param name="e">Olay verisi</param>
        private void Kayit_Load(object sender, EventArgs e)
        {
            // şifre alanı hariç kullanıcı giriş alanlarını devre dışı bırakıyoruz
            txtKullaniciAdi.Enabled = false;
            txtSifre.Enabled = false;
            txtSifreTekrar.Enabled = false;
            chcOnayliyorum.Enabled = false;

            // şifre girilecek textboxları temizliyoruz
            txtFirst.Text = "";                  
            txtSecond.Text = "";
            txtThird.Text = "";
            txtFourth.Text = "";
            txtFifth.Text = "";
            txtSixth.Text = "";

            // kullanıcının 6 hanelik şifreyi tamamladığında kullanıcı giriş alanlarının açılabilmesi için olayları ekliyoruz.
            txtFirst.TextChanged += realPass_TextChanged;
            txtSecond.TextChanged += realPass_TextChanged;
            txtThird.TextChanged += realPass_TextChanged;
            txtFourth.TextChanged += realPass_TextChanged;
            txtFifth.TextChanged += realPass_TextChanged;
            txtSixth.TextChanged += realPass_TextChanged;

            // textchanged olaylarını ekliyoruz
            txtFirst.TextChanged += txtBox_TextChanged;
            txtSecond.TextChanged += txtBox_TextChanged;
            txtThird.TextChanged += txtBox_TextChanged;
            txtFourth.TextChanged += txtBox_TextChanged;
            txtFifth.TextChanged += txtBox_TextChanged;
            txtSixth.TextChanged += txtBox_TextChanged;

            // keydown olaylarını ekliyoruz
            txtFirst.KeyDown += txtBox_KeyDown;
            txtSecond.KeyDown += txtBox_KeyDown;
            txtThird.KeyDown += txtBox_KeyDown;
            txtFourth.KeyDown += txtBox_KeyDown;
            txtFifth.KeyDown += txtBox_KeyDown;
            txtSixth.KeyDown += txtBox_KeyDown;

        }

        /// <summary>
        /// Kullanıcının bir TextBox'a girdiği karakter sayısı, maksimum karakter sayısına ulaştığında 
        /// otomatik olarak bir sonraki TextBox'a geçiş yapar.
        /// </summary>
        /// <param name="sender">Olayı tetikleyen TextBox nesnesi</param>
        /// <param name="e">Olay verisi</param>
        private void txtBox_TextChanged(object sender, EventArgs e)
        {
            TextBox currentTextBox = sender as TextBox;

            if (currentTextBox.Text.Length == currentTextBox.MaxLength)
            {
                this.SelectNextControl(currentTextBox, true, true, true, true);
            }
        }

        /// <summary>
        /// Kullanıcının geri tuşuna (Backspace) basması durumunda, önceki TextBox'a geçiş yapar.
        /// Eğer mevcut TextBox boşsa, bir önceki TextBox'a odaklanır.
        /// </summary>
        /// <param name="sender">Olayı tetikleyen TextBox nesnesi</param>
        /// <param name="e">Tuş olay verisi</param>
        private void txtBox_KeyDown(object sender, KeyEventArgs e)
        {
            TextBox currentTextBox = sender as TextBox;

            if (e.KeyCode == Keys.Back && currentTextBox.Text.Length == 0)
            {
                this.SelectNextControl(currentTextBox, false, true, true, true);
            }
        }

        /// <summary>
        /// Kullanıcının girdiği 6 haneli kodu kontrol eder. 
        /// Eğer kullanıcı 6 hanelik şifreyi eksiksiz girdiyse, giriş alanlarını aktif hale getirir.
        /// Eksikse, giriş alanlarını devre dışı bırakır.
        /// </summary>
        /// <param name="sender">Olayı tetikleyen buton nesnesi</param>
        /// <param name="e">Olay verisi</param>
        private void realPass_TextChanged(object sender, EventArgs e)
        {

            _realPass = txtFirst.Text + txtSecond.Text + txtThird.Text + txtFourth.Text + txtFifth.Text + txtSixth.Text; 

            if (_realPass.Length == 6 && _gelenSifre == _realPass)
            {
                txtKullaniciAdi.Enabled = true;
                txtSifre.Enabled = true;
                txtSifreTekrar.Enabled = true;
                chcOnayliyorum.Enabled = true;

            }
            else if(_realPass.Length == 6 && _gelenSifre != _realPass)
            {
                MessageBox.Show("Lütfen şifreyi kontrol ediniz!");
                txtKullaniciAdi.Enabled = false;
                txtSifre.Enabled = false;
                txtSifreTekrar.Enabled = false;
                chcOnayliyorum.Enabled = false;
            }
            else
            {

                txtKullaniciAdi.Enabled = false;
                txtSifre.Enabled = false;
                txtSifreTekrar.Enabled = false;
                chcOnayliyorum.Enabled = false;
            }
        }
        /// <summary>
        /// Kullanıcının kayıt işlemini gerçekleştirir. 
        /// - Girilen şifre ile sistemdeki şifreyi doğrular. 
        /// - Tüm zorunlu alanların doldurulduğunu kontrol eder.
        /// - "Onaylıyorum" kutusunun işaretli olup olmadığını kontrol eder.
        /// - Şifre ve şifre tekrarının eşleştiğini kontrol eder.
        /// - Kayıt başarılı olursa giriş ekranına yönlendirir.
        /// </summary>
        /// <param name="sender">Olayı tetikleyen buton nesnesi</param>
        /// <param name="e">Olay verisi</param>
        private void btnKayit_Click(object sender, EventArgs e)
        {
            try
            {                       
                foreach (var item in pnlKayit.Controls)
                {
                    if (item is TextBox && string.IsNullOrWhiteSpace(((TextBox)(item)).Text))
                    {
                        MessageBox.Show("Lütfen bütün bilgileri doldurunuz!");
                        return;
                    }
                }

                if (!chcOnayliyorum.Checked)
                {
                    MessageBox.Show("Lütfen onaylıyorum butonunu işaretleyiniz!");
                }
                else
                {
                    if (txtSifre.Text == txtSifreTekrar.Text)
                    {
                        Kullanici yeniKullanici = new Kullanici(txtKullaniciAdi.Text, txtSifre.Text);
                        KullaniciVeriTabani.KullaniciListesi.Add(yeniKullanici);

                        MessageBox.Show("Kaydınız başarıyla oluşturuldu. Emirbank ailesine hoşgeldiniz!");
                        this.Hide();
                        GirisYap girisYap = new GirisYap(1000);
                        girisYap.Show();
                    }
                    else
                    {
                        MessageBox.Show("Şifre doğrulaması hatalı! Lütfen kontrol ederek tekrar deneyiniz.");
                        txtSifre.Clear();
                        txtSifreTekrar.Clear();
                        chcOnayliyorum.Checked = false;
                    }
                }   
            }
            catch (Exception ex)
            {
                MessageBox.Show("Beklenmeyen bir hata oluştu!" + ex.Message);
            }
        }
    }
}
