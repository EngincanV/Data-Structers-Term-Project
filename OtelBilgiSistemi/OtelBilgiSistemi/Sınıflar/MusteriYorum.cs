using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelBilgiSistemi.Sınıflar
{
    public class MusteriYorum
    {
        public int Id { get; set; }
        public string Yorum { get; set; }
        public int CurrentMusteri { get; set; }
        public virtual MusteriKayit MusteriKayits { get; set; }
    }
}
