namespace OtelBilgiSistemi
{
    public class IkiliAramaAgacDugumu
    {
        public OtelKayit veri;
        public IkiliAramaAgacDugumu sol;
        public IkiliAramaAgacDugumu sag;

        public IkiliAramaAgacDugumu() { }

        public IkiliAramaAgacDugumu (OtelKayit veri)
        {
            this.veri = veri;
            sol = null;
            sag = null;
        }
    }
}
