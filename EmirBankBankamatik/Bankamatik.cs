using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmirBankBankamatik
{
    public  class Bankamatik
    {
        private decimal _bakiye;

        public Bankamatik(decimal baslangicBakiyesi)
        {
            _bakiye = baslangicBakiyesi;
        }

        public decimal Bakiye
        {
            get { return _bakiye; }
            private set { _bakiye = value; } // Dışarıdan direkt değiştirilmesini önlüyoruz
        }

        public bool ParaCek(decimal cekilecekTutar, out string mesaj)
        {
            if (cekilecekTutar <= 0)
            {
                mesaj = "Çekmek istediğiniz tutar 0 veya daha küçük olamaz!";
                return false;
            }

            if (cekilecekTutar > _bakiye)
            {
                mesaj = "Yetersiz bakiye!";
                return false;
            }

            _bakiye -= cekilecekTutar;
            mesaj = $"İşleminiz gerçekleştirildi!\nÇekilen Tutar: {cekilecekTutar} ₺, Güncel bakiyeniz: {_bakiye} ₺";
            return true;
        }
    }
}
