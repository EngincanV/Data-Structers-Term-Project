using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelBilgiSistemi.Sınıflar
{
    public class HeapDugumu
    {
        public OtelKayit otelKayit { get; set; }
        public HeapDugumu(OtelKayit otelKayit)
        {
            this.otelKayit = otelKayit;
        }
    }
}
