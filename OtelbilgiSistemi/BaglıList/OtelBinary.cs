using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OtelbilgiSistemi.Data;

namespace OtelbilgiSistemi.Veri_Yapıları
{
    public class OtelBinary
    {
        public int Id { get; set; }
        public string OtelAd { get; set; }
        public string Otelil { get; set; }
        public string OtelIlce { get; set; }
        public string OtelAdres { get; set; }
        public string OtelTel { get; set; }
        public string OtelEposta { get; set; }
        public int yildizSayi { get; set; }
        public int OdaSayisi { get; set; }
        public float OtelPuani { get; set; }

        public static implicit operator OtelBinary(OtelKayit v)
        {
            throw new NotImplementedException();
        }
    }
}
