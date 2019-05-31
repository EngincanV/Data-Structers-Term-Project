using System.Collections.Generic;

namespace OtelBilgiSistemi.Sınıflar
{
    public class MusteriKayit
    {
        public int Id { get; set; }
        public string Eposta { get; set; }
        public string Sifre { get; set; }
        public int TCKimlik { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int telefon { get; set; }
        public bool IsTrue { get; set; }
        public bool IsFalse { get; set; }
        public virtual ICollection<MusteriYorum> MusteriYorum { get; set; }
        public OtelKayit OtelKayit_ıd { get; set; }
    }
}
