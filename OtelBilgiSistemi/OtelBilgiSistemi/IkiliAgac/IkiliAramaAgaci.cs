using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelBilgiSistemi.IkılıAgac
{
    public class IkiliAramaAgaci
    {
        private IkiliAramaAgacDugumu kok;
        private string dugumler;

        public IkiliAramaAgaci() { }

        public IkiliAramaAgaci(IkiliAramaAgacDugumu kok)
        {
            this.kok = kok;
        }

        public string DugumleriYazdir()
        {
            return dugumler;
        }

        //Gezinme Islemleri 
        public void PreOrder()
        {
            dugumler = "";
            PreOrderInt(kok);
        }
        private void PreOrderInt(IkiliAramaAgacDugumu dugum)
        {
            if (dugum == null)
                return;
            Ziyaret(dugum);
            PreOrderInt(dugum.sol);
            PreOrderInt(dugum.sag);
        }
        public void InOrder()
        {
            dugumler = "";
            InOrderInt(kok);
        }
        private void InOrderInt(IkiliAramaAgacDugumu dugum)
        {
            if (dugum == null)
                return;
            InOrderInt(dugum.sol);
            Ziyaret(dugum);
            InOrderInt(dugum.sag);
        }
        private void Ziyaret(IkiliAramaAgacDugumu dugum)
        {
            dugumler += dugum.veri.Id + " ";
        }
        public void PostOrder()
        {
            dugumler = "";
            PostOrderInt(kok);
        }
        private void PostOrderInt(IkiliAramaAgacDugumu dugum)
        {
            if (dugum == null)
                return;
            PostOrderInt(dugum.sol);
            PostOrderInt(dugum.sag);
            Ziyaret(dugum);
        }

        public int ElemanSayisi()
        {
            return ElemanSayisi(kok);
        }
        public int maxDepth()
        {
            return maxDepth(kok);
        }

        private int maxDepth(IkiliAramaAgacDugumu node)
        {
            if (node == null)
                return 0;
            else
            {
                /* compute the depth of each subtree */
                int lDepth = maxDepth(node.sol);
                int rDepth = maxDepth(node.sag);

                /* use the larger one */
                if (lDepth > rDepth)
                    return (lDepth + 1);
                else
                    return (rDepth + 1);
            }
        }

        private int ElemanSayisi(IkiliAramaAgacDugumu dugum)
        {
            int count = 0;
            if(dugum != null)
            {
                count = 1;
                count += ElemanSayisi(dugum.sol);
                count += ElemanSayisi(dugum.sag);
            }
            return count;
        }

        //Ekleme Islemi

        public string Ekle(OtelKayit otel) 
        {
            //Yeni eklenecek dugum icin parent olustur
            IkiliAramaAgacDugumu tempParent = new IkiliAramaAgacDugumu();

            //Kokten basla ve ilerle
            IkiliAramaAgacDugumu tempSearch = kok;

            while(tempSearch != null)
            {
                //null olana kadar parent a at
                tempParent = tempSearch;

                //deger varsa ekleme cik
                if ((int)tempSearch.veri.Id > otel.Id)
                    tempSearch = tempSearch.sol;
                else
                    tempSearch = tempSearch.sag;
            }

            //Eklenecek degeri belirt
            IkiliAramaAgacDugumu eklenecek = new IkiliAramaAgacDugumu(otel);

            //agac bos ise koke ata
            if (kok == null)
                kok = eklenecek;
            else if ((int)tempParent.veri.Id > otel.Id)
                tempParent.sol = eklenecek;
            else
                tempParent.sag = eklenecek;
            return dugumler += eklenecek.veri.Id.ToString() + " ";
        }
    }
}
