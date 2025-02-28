using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmirBankBankamatik
{
    public class Kullanici
    {
        public decimal Bakiye { get; set; }
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }

        public Kullanici (string kullaniciAdi, string sifre,decimal bakiye)
        {
            KullaniciAdi = kullaniciAdi;
            Sifre = sifre;
            Bakiye = bakiye;
        }
    }
}
