using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelbilgiSistemi.Veri_Yapıları
{
    public class Otel
    {
        public int ID { get; set; }
        public string OtelAdi { get; set; }
        public string OtelIl { get; set; }
        public string OtelIlce { get; set; }
        public string OtelAdres { get; set; }
        public string OtelTel { get; set; }
        public string OtelEPosta { get; set; }
        public int YildizSayisi { get; set; }
        public int OdaSayisi { get; set; }
        public float OtelPuani { get; set; }
        public int CurrentCalisan { get; set; }
    }
}
