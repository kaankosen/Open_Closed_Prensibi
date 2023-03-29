using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Open_Closed_Prensibi
{
    public class Musteri
    {
        public int MusteriID { get; set; }
        public string Name { get; set; }
        public UyelikTipi Uyelik { get; set; }
    }

    public abstract class UyelikTipi
    {
        public abstract decimal Hesapla(decimal urunFiyatı);

    }

    public class StandartUyelikTipi : UyelikTipi
    {
        public override decimal Hesapla(decimal urunFiyatı)
        {
            return urunFiyatı;
        }


    }
    public class PremiumUyelikTipi : UyelikTipi
    {
        public override decimal Hesapla(decimal urunFiyatı)
        {
            return urunFiyatı * (1 - 0.1M);
        }


    }

    public class SiparisOnay
    {
        public decimal FiyatHesapla(decimal fiyat, Musteri musteri)
        {
            return musteri.Uyelik.Hesapla(fiyat);
        }
    }
}