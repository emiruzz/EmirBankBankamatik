using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmirBankBankamatik
{
    public class Bankamatik
    {
        private readonly Kullanici _kullanici;

        public Bankamatik(Kullanici kullanici,decimal baslangicBakiyesi)
        {
            _kullanici = kullanici;
            _kullanici.Bakiye = baslangicBakiyesi;
            
        }

        public decimal Bakiye
        {
            get { return _kullanici.Bakiye; }
            private set { _kullanici.Bakiye = value; } // Dışarıdan direkt değiştirilmesini önlüyoruz
        }

        public bool ParaCek(decimal cekilecekTutar, out string mesaj)
        {
            if (cekilecekTutar <= 0)
            {
                mesaj = "Çekmek istediğiniz tutar 0 veya daha küçük olamaz!";
                return false;
            }

            if (cekilecekTutar > _kullanici.Bakiye)
            {
                mesaj = "Yetersiz bakiye!";
                return false;
            }

            _kullanici.Bakiye -= cekilecekTutar;
            mesaj = $"İşleminiz gerçekleştirildi!\nÇekilen Tutar: {cekilecekTutar} ₺, Güncel bakiyeniz: {_kullanici.Bakiye} ₺";
            return true;
        }
    }
}
