using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelBilgiSistemi.Sınıflar
{
    public class HeapSort
    {
        private HeapDugumu[] dizi;
        public HeapSort(HeapDugumu[] dizi)
        {
            this.dizi = dizi;
        }

        public HeapDugumu[] Sort()
        {
            Heap h = new Heap(dizi.Length);
            HeapDugumu[] sorted = new HeapDugumu[dizi.Length];
            //Heap Ağacı Oluştur
            foreach (var item in dizi)
            {
                if (item == null)
                    break;
                h.Insert(item.otelKayit);

            }
            int i = 0;
            //Ağaçtaki maksimum elemanı al ve yeni diziye ekle
            while (!h.IsEmpty())
                sorted[i++] = h.RemoveMax();
            return sorted;
        }
    }
}
