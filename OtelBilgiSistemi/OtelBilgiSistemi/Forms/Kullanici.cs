using OtelBilgiSistemi.IkılıAgac;
using OtelBilgiSistemi.Sınıflar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtelBilgiSistemi.Forms
{
    public partial class Kullanici : MetroFramework.Forms.MetroForm
    {
        public Kullanici()
        {
            InitializeComponent();
        }
        OtelDbcontext db = new OtelDbcontext();
        private void Kullanici_Load(object sender, EventArgs e)
        {
            
        }

        private void AraBtn_Click(object sender, EventArgs e)
        {
            var query = from a in db.OtelKayits orderby a.OtelAd where metroComboBox2.SelectedItem == a.Sehir && metroComboBox3.SelectedItem == a.Ilce select a;
            foreach (var item in query)
            {
                txtId.Text = item.Id.ToString();
                lw_otelListesi.Items.Add("Yıldız Sayısı : " + item.YildizSayisi + "  Otel Adı: " + item.OtelAd + Environment.NewLine + "  Otel Şehri : " + item.Sehir + Environment.NewLine + "  Otel İlçe : " + item.Ilce);
                lw_otelListesi.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                lw_otelListesi.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                metroComboBox2.Items.Clear();
                metroComboBox3.Items.Clear();
            }
            var sorgu = from b in db.OtelKayits where b.OtelAd == Oteltxt.Text select b;
            foreach (var item in sorgu)
            {
                txtId.Text = item.Id.ToString();
                lw_otelListesi.Items.Add("Yıldız Sayısı : " + item.YildizSayisi + "  Otel Adı: " + item.OtelAd + Environment.NewLine + "  Otel Şehri : " + item.Sehir + Environment.NewLine + "  Otel İlçe : " + item.Ilce);
                lw_otelListesi.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                lw_otelListesi.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                Oteltxt.Text = "";
            }
            var sorgu2 = from a in db.OtelKayits.OrderBy(p=>p.YildizSayisi) where metroComboBox1.SelectedItem == a.YildizSayisi.ToString() select a;
            foreach (var item in sorgu2)
            {
                txtId.Text = item.Id.ToString();
                lw_otelListesi.Items.Add("Yıldız Sayısı : " + item.YildizSayisi + "  Otel Adı: " + item.OtelAd + Environment.NewLine + "  Otel Şehri : " + item.Sehir + Environment.NewLine + "  Otel İlçe : " + item.Ilce);
                lw_otelListesi.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                lw_otelListesi.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                metroComboBox1.Items.Clear();
            }
        }
        private void metroButton2_Click(object sender, EventArgs e)
        {
            var query = from a in db.musteriYorums select a;
            foreach (var item in query)
            {
                item.Yorum = metroTextBox1.Text;
                db.musteriYorums.Add(item);
            }
            db.SaveChanges();
            MessageBox.Show("Yorum kaydedildi.");
        }

        private void lw_otelListesi_SelectedIndexChanged(object sender, EventArgs e)
        {
            metroTextBox1.Enabled = true;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            using (var db = new OtelDbcontext())
            {
                var sorgu2 = from a in db.OtelKayits where a.Id.ToString() == txtId.Text.ToString() select a;
                foreach (var item in sorgu2)
                {
                    item.OtelPuani += metroComboBox4.SelectedIndex + 1;
                }
                db.SaveChanges();
                MessageBox.Show("Başarılı");
            }
        }

        private void Adabtn_Click(object sender, EventArgs e)
        {
            lw_otelListesi.Items.Clear();
            metroLabel2.Visible = false;
            metroLabel3.Visible = false;
            metroLabel4.Visible = false;
            metroComboBox1.Visible = false;
            metroComboBox2.Visible = false;
            metroComboBox3.Visible = false;
            Oteltxt.Visible = true;
            metroLabel6.Visible = true;
            metroComboBox5.Visible = false;
            metroButton7.Visible = false;
            metroLabel7.Visible = false;
            metroButton5.Visible = false;
        }

        private void Sehirbtn_Click(object sender, EventArgs e)
        {
            lw_otelListesi.Items.Clear();
            metroLabel2.Visible = true;
            metroLabel3.Visible = true;
            metroLabel4.Visible = false;
            metroComboBox1.Visible = false;
            metroComboBox2.Visible = true;
            metroComboBox3.Visible = true;
            Oteltxt.Visible = false;
            metroLabel6.Visible = false;
            metroComboBox5.Visible = false;
            metroButton7.Visible = false;
            metroLabel7.Visible = false;
            metroButton5.Visible = false;
        }

        private void yıldızbtn_Click(object sender, EventArgs e)
        {
            metroLabel2.Visible = false;
            metroLabel3.Visible = false;
            metroLabel4.Visible = true;
            metroComboBox1.Visible = true;
            metroComboBox2.Visible = false;
            metroComboBox3.Visible = false;
            Oteltxt.Visible = false;
            metroLabel6.Visible = false;
            metroComboBox5.Visible = false;
            metroButton5.Visible = false;
            metroButton7.Visible = false;
            metroLabel7.Visible = false;
            lw_otelListesi.Items.Clear();
        }

        private void IkılıAramabtn_Click(object sender, EventArgs e)
        {
            metroLabel2.Visible = false;
            metroLabel3.Visible = false;
            metroLabel4.Visible = false;
            metroComboBox1.Visible = false;
            metroComboBox2.Visible = false;
            metroComboBox3.Visible = false;
            metroComboBox5.Visible = false;
            Oteltxt.Visible = false;
            metroLabel6.Visible = false;
            metroComboBox5.Visible = true;
            metroLabel7.Visible = true;
            metroButton5.Visible = false;
            metroButton7.Visible = false;
            metroButton3.Visible = true;
            lw_otelListesi.Items.Clear();
            Sıralama();
        }
        IkiliAramaAgaci Ikili;
        OtelKayit o = new OtelKayit();
        public void Sıralama()
        {
            using (var db = new OtelDbcontext())
            {
                var sorgu = from a in db.OtelKayits.OrderByDescending(p => p.Id) select a;
                Ikili = new IkiliAramaAgaci();
                foreach (var item in sorgu)
                {
                    o = item;
                    Ikili.Ekle(o);
                }
                Ikili.InOrder();
                MessageBox.Show(Ikili.DugumleriYazdir());
            }
        }
        private void metroComboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            if (Ikili == null)
                MessageBox.Show("Agac uzerinde dolaşmak icin agaci olustur");
            else
            {
                switch (metroComboBox5.SelectedIndex)
                {
                    case 0:
                        Ikili.InOrder();
                        MessageBox.Show("Eleman Sayisi : " + Ikili.ElemanSayisi());
                        MessageBox.Show("Derinlik : " + Ikili.maxDepth());
                        break;
                    case 1:
                        Ikili.PreOrder();
                        MessageBox.Show("Eleman Sayisi : " + Ikili.ElemanSayisi());
                        MessageBox.Show("Derinlik : " + Ikili.maxDepth());
                        break;
                    case 2:
                        Ikili.PostOrder();
                        MessageBox.Show("Eleman Sayisi : " + Ikili.ElemanSayisi());
                        MessageBox.Show("Derinlik : " + Ikili.maxDepth());
                        break;
                    default:
                        break;
                }
                MessageBox.Show(Ikili.DugumleriYazdir());

            }

        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            metroLabel2.Visible = true;
            metroLabel3.Visible = true;
            metroLabel4.Visible = false;
            metroComboBox1.Visible = false;
            metroComboBox2.Visible = true;
            metroComboBox3.Visible = true;
            metroComboBox5.Visible = false;
            Oteltxt.Visible = false;
            metroLabel6.Visible = false;
            metroComboBox5.Visible = false;
            metroLabel7.Visible = false;
            metroButton3.Visible = false;
            metroButton5.Visible = true;
            metroButton7.Visible = false;
            lw_otelListesi.Items.Clear();
        }

        private void metroComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (metroComboBox2.SelectedIndex==0)
            {
                metroComboBox3.Items.Clear();
                metroComboBox3.Items.Add("Kemer");
                metroComboBox3.Items.Add("Belek");
                metroComboBox3.Items.Add("Konya Altı");
            }
            if (metroComboBox2.SelectedIndex == 1)
            {
                metroComboBox3.Items.Clear();
                metroComboBox3.Items.Add("Karşıyaka");
                metroComboBox3.Items.Add("Konak");
                metroComboBox3.Items.Add("Çeşme");
            }
            if (metroComboBox2.SelectedIndex == 2)
            {
                metroComboBox3.Items.Clear();
                metroComboBox3.Items.Add("Bodrum");
                metroComboBox3.Items.Add("Fethiye");
                metroComboBox3.Items.Add("Marmaris");
            }
            if (metroComboBox2.SelectedIndex == 3)
            {
                metroComboBox3.Items.Clear();
                metroComboBox3.Items.Add("Silifke");
                metroComboBox3.Items.Add("Tarsus");
                metroComboBox3.Items.Add("Tece");
            }
            if (metroComboBox2.SelectedIndex == 4)
            {
                metroComboBox3.Items.Clear();
                metroComboBox3.Items.Add("Seyhan");
                metroComboBox3.Items.Add("Ceyhan");
                metroComboBox3.Items.Add("Kozan");
            }
            if (metroComboBox2.SelectedIndex == 5)
            {
                metroComboBox3.Items.Clear();
                metroComboBox3.Items.Add("Fatih");
                metroComboBox3.Items.Add("Avcılar");
                metroComboBox3.Items.Add("Beşiktas");
            }
            if (metroComboBox2.SelectedIndex == 6)
            {
                metroComboBox3.Items.Clear();
                metroComboBox3.Items.Add("Şehitkamil");
                metroComboBox3.Items.Add("Karşıyaka");
                metroComboBox3.Items.Add("Yavuzeli");
            }
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            var query1 = from a in db.OtelKayits.OrderByDescending(p => p.YildizSayisi) where metroComboBox2.SelectedItem == a.Sehir || metroComboBox3.SelectedItem == a.Ilce select a;
            foreach (var item in query1)
            {
                lw_otelListesi.Items.Add("Yıldız Sayısı : " + item.YildizSayisi + "  Otel Adı: " + item.OtelAd + Environment.NewLine + "  Otel Şehri : " + item.Sehir + Environment.NewLine + "  Otel İlçe : " + item.Ilce);
                metroComboBox2.Items.Clear();
                metroComboBox3.Items.Clear();
            }
        }

        private void metroButton6_Click(object sender, EventArgs e)
        {
            metroLabel2.Visible = true;
            metroLabel3.Visible = true;
            metroLabel4.Visible = false;
            metroComboBox1.Visible = false;
            metroComboBox2.Visible = true;
            metroComboBox3.Visible = true;
            metroComboBox5.Visible = false;
            Oteltxt.Visible = false;
            metroLabel6.Visible = false;
            metroComboBox5.Visible = false;
            metroLabel7.Visible = false;
            metroButton3.Visible = false;
            metroButton5.Visible = true;
            lw_otelListesi.Items.Clear();
            metroButton7.Visible = true;
        }
        static Heap heap = new Heap(100);
        private void metroButton7_Click(object sender, EventArgs e)
        {
            using (var dbb = new OtelDbcontext())
            {
                var query = from a in dbb.OtelKayits select a;
                OtelKayit o = new OtelKayit();
                foreach (var item in query)
                {
                    o = item;
                    heap.Insert(o);
                }
                HeapSort heapSort = new HeapSort(heap.ReturnHeap());
                //heapler icinde en yuksek otel puanına gore asağıdaki sorted ın içine çeker dizi şeklinde
                HeapDugumu[] sorted = heapSort.Sort();
                foreach (var item in sorted)
                {
                    if (item == null)
                    {
                        break;
                    }
                    if (item.otelKayit.Sehir == metroComboBox2.SelectedItem.ToString() || item.otelKayit.Ilce == metroComboBox3.SelectedItem.ToString())
                    {
                        lw_otelListesi.Items.Add(item.otelKayit.OtelAd.ToString() + " " + item.otelKayit.OtelPuani.ToString());
                    }
                }
            }
        }
    }
}