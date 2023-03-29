using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public enum UyelikTipleri { Standart, Premium }

public class Musteri
{
    public int MusteriID { get; set; }
    public string MusteriName { get; set; }
    public UyelikTipleri Uyelik { get; set; }

}

public class SiparisOnay
{
    public decimal FiyatHesaplama(decimal fiyat, Musteri musteri)
    {
        decimal sonuc = 0;
        switch (musteri.Uyelik)
        {
            case UyelikTipleri.Standart:
                sonuc = fiyat;
                break;
            case UyelikTipleri.Premium:
                sonuc = fiyat * (1 - 0.1M);
                break;
        }
        return sonuc;
    }
}