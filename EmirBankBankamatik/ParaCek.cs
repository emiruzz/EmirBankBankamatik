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
    public partial class ParaCek : Form
    {
        private  decimal _bakiye;

        public ParaCek(decimal bakiye)
        {
            InitializeComponent();
            _bakiye = bakiye;
        }

        private void btnParayiCek_Click(object sender, EventArgs e)
        {
            try
            {
                if (!chcOnayliyorumParaCek.Checked)
                {
                    MessageBox.Show("İşlemi gerçekleştirmek için onay kutusunu işaretleyiniz!");
                    return;
                }

                string girilenTutar = txtCekilecekTutar.Text.Trim();

                if (string.IsNullOrWhiteSpace(girilenTutar))
                {
                    MessageBox.Show("Lütfen çekmek istediğiniz tutarı tuşlayınız!");
                    return;
                }

                if (decimal.TryParse(girilenTutar, out decimal cekilecekTutar))
                {
                    if(cekilecekTutar>_bakiye)
                    {
                        MessageBox.Show("Yetersiz bakiye!");
                        return;
                    }
                    if (cekilecekTutar <= 0)
                    {
                        MessageBox.Show("Çekmek istediğiniz tutar 0 veya daha küçük olamaz!");
                        return;
                    }

                    MessageBox.Show($"İşleminiz gerçekleştirildi!\nÇekilen Tutar: {cekilecekTutar} ₺, Güncel bakiyeniz: {_bakiye-cekilecekTutar} ₺");

                    _bakiye -= cekilecekTutar;

                    this.Hide();

                    AnaEkran form1 = new AnaEkran(_bakiye);
                    form1.ShowDialog();

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Geçersiz bir tutar girdiniz! Lütfen sadece rakam giriniz.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Beklenmeyen bir hata oluştu.\n{ex.Message}");
            }
        }
    }
}
