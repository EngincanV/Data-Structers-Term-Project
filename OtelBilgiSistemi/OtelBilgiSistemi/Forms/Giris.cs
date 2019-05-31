using OtelBilgiSistemi.Forms;
using OtelBilgiSistemi.LinkList;
using OtelBilgiSistemi.Sınıflar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using OtelBilgiSistemi.IkılıAgac;
using OtelBilgiSistemi.Hash;

namespace OtelBilgiSistemi
{
    public partial class Giris : MetroFramework.Forms.MetroForm
    {
        public Giris()
        {
            InitializeComponent();
        }
        Yonetici yon = new Yonetici();
        Kullanici kul = new Kullanici();
        private void girisBtn_Click(object sender, EventArgs e)
        {
            using (var db = new OtelDbcontext())
            {
                string eposta = girisEpostaTbox.Text, sifre = girisSifreTbox.Text;
                if (string.IsNullOrWhiteSpace(girisEpostaTbox.Text) || string.IsNullOrWhiteSpace(girisSifreTbox.Text))
                {
                    MessageBox.Show("You must fill in the all empty fields");
                }
                else
                {
                    MusteriKayit kd = new MusteriKayit();
                    var sorgu2 = from a in db.musteriKayits where a.Eposta == eposta select a.Eposta;
                    var sorgu3 = from a in db.musteriKayits where a.Sifre== sifre select a.Sifre;
                    var sorgu = from a in db.musteriKayits where a.Eposta== eposta && a.Sifre== sifre select a.IsTrue;
                    string sorgu4 = "", sorgu5 = "";
                    foreach (string item in sorgu2)
                    {
                        sorgu4 = item;
                    }
                    foreach (string item in sorgu3)
                    {
                        sorgu5 = item;
                    }
                    if (sorgu4 == eposta && sorgu5 == sifre)
                    {
                        foreach (bool item in sorgu)
                        {
                            if (item == true)
                            {
                                yon.Show();
                                this.Hide();
                                kul.Hide();
                            }
                            else if (item == false)
                            {
                                kul.Show();
                                this.Hide();
                                yon.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Hatalı Giriş");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Hatalı Giriş");
                    }
                }
            }
        }

        private void kayitBtn_Click(object sender, EventArgs e)
        {
            Kayit ky = new Kayit();
            ky.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var db = new OtelDbcontext())
            {
                var sorgu = from a in db.OtelCalisans.OrderByDescending(p => p.Id) select a;
                OtelCalisan o = new OtelCalisan();
                LinkedList lin = new LinkedList();
                foreach (var item in sorgu)
                {
                    o = item;
                    lin.InsertFirst(o);
                }
                MessageBox.Show(lin.DisplayElements());
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {       
            

        }
        private void Giris_Load(object sender, EventArgs e)
        {
            using (var db = new OtelDbcontext())
            {
                var query = from a in db.OtelKayits.OrderBy(p => p.OtelAd) select a;
                OtelKayit o = new OtelKayit();
                IkiliAramaAgaci ikili = new IkiliAramaAgaci();
                foreach (var item in query)
                {
                    o = item;
                    ikili.Ekle(o);
                }
            }
            Heap heap = new Heap(100);

            using (var db = new OtelDbcontext())
            {
                int size = 0;
                int count = (from a in db.OtelKayits select a).Count();
                var query = from a in db.OtelKayits select a;
                HashMap h = new HashMap(count);
                OtelKayit o = new OtelKayit();
                foreach(var item in query)
                {
                    if (size == count)
                        break;
                    o = item;
                    h.AddOtel(size, o);
                    heap.Insert(o);
                    MessageBox.Show(h.GetOtel(size).ToString());
                    size++;
                }
                HeapSort heapSort = new HeapSort(heap.ReturnHeap());
                //heapler icinde en yuksek otel puanına gore asağıdaki sorted ın içine çeker dizi şeklinde
                HeapDugumu[] sorted = heapSort.Sort();
            }
        }
    }
}
