namespace OtelBilgiSistemi
{
    public class OtelCalisan
    {
        public int Id { get; set; }
        public string TCKimlik { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Telefon { get; set; }
        public int personelpuan { get; set; }
        public string Adres { get; set; }
        public string Eposta { get; set; }
        public string Departman { get; set; }
        public OtelKayit OtelKayits { get; set; }
    }
}
