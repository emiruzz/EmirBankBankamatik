﻿using System;
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
    public partial class ParaYatir : Form
    {
        private decimal _bakiye;

        public ParaYatir(decimal bakiye)
        {
            
            InitializeComponent();
            _bakiye = bakiye;
        }

        private void btnParayiYatir_Click(object sender, EventArgs e)
        {
            try
            {
                if (!chcOnayliyorum.Checked)
                {
                    MessageBox.Show("İşlemi gerçekleştirmek için onay kutusunu işaretleyiniz!");
                    return;
                }

                string girilenTutar = txtYatirilacakTutar.Text.Trim();

                if (string.IsNullOrWhiteSpace(girilenTutar))
                {
                    MessageBox.Show("Lütfen yatırmak istediğiniz tutarı tuşlayınız!");
                    return;
                }

                if (decimal.TryParse(girilenTutar, out decimal yatirilacakTutar))
                {
                    if (yatirilacakTutar <= 0)
                    {
                        MessageBox.Show("Yatırmak istediğiniz tutar 0 veya daha küçük olamaz!");
                        return;
                    }

                    MessageBox.Show($"İşleminiz gerçekleştirildi!\nYatırılan Tutar: {yatirilacakTutar} ₺, Güncel bakiyeniz: {_bakiye + yatirilacakTutar} ₺");
                    _bakiye += yatirilacakTutar;

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
