using OtelBilgiSistemi.Sınıflar;
using System.Data.Entity;

namespace OtelBilgiSistemi
{
    public class OtelDbcontext : DbContext
    {
        public OtelDbcontext():base("OtelBilgileridb")
        {

        }
        public DbSet<OtelKayit> OtelKayits { get; set; }
        public DbSet<OtelCalisan> OtelCalisans{ get; set; }
        public DbSet<MusteriKayit> musteriKayits { get; set; }
        public DbSet<MusteriYorum> musteriYorums { get; set; }
    }
}
