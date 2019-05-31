using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelBilgiSistemi.Hash
{
    public class HashEntry
    {
        private int anahtar;

        private OtelKayit deger;

        public OtelKayit Deger
        {
            get { return deger; }
            set { deger = value; }
        }
        public int Anahtar
        {
            get { return anahtar; }
            set { anahtar = value; }
        }
        public HashEntry(int anahtar, OtelKayit deger)
        {
            this.anahtar = anahtar;
            this.deger = deger;
        }

    }
}
