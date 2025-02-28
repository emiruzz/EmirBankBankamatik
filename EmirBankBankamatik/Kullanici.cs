using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmirBankBankamatik
{
    internal class Kullanici
    {

        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }

        public Kullanici (string kullaniciAdi, string sifre)
        {
            KullaniciAdi = kullaniciAdi;
            Sifre = sifre;
        }
    }
}
