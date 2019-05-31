using OtelBilgiSistemi.Sınıflar;
using System.Collections.Generic;

namespace OtelBilgiSistemi
{
    public class OtelKayit
    {
        public int Id { get; set; }
        public string OtelAd { get; set; }
        public string OtelAdres { get; set; }
        public string Sehir { get; set; }
        public string Ilce { get; set; }
        public string Telefon { get; set; }
        public string EPosta { get; set; }
        public int YildizSayisi { get; set; }
        public int OdaSayisi { get; set; }
        public int OtelPuani { get; set; }
        public virtual ICollection<OtelCalisan> OtelCalisans{ get; set; }
        public virtual ICollection<MusteriKayit> MusteriKayits{ get; set; }
    }
}
