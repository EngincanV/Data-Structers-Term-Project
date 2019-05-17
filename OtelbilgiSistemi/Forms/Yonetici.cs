using OtelbilgiSistemi.Data;
using OtelbilgiSistemi.Veri_Yapıları;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtelbilgiSistemi
{
    public partial class Yonetici : Form
    {
        public Yonetici()
        {
            InitializeComponent();
        }

        private void silbtn_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            using (var db = new OtelBilgiEntities3())
            {
                if (string.IsNullOrWhiteSpace(oteladTbox.Text) || string.IsNullOrWhiteSpace(ilTbox.Text) || string.IsNullOrWhiteSpace(ilceTbox.Text) ||
                    string.IsNullOrWhiteSpace(adresTxt.Text) || string.IsNullOrWhiteSpace(telefonTbox.Text) || string.IsNullOrWhiteSpace(epostaTbox.Text) ||
                    string.IsNullOrWhiteSpace(yildizTbox.Text) || string.IsNullOrWhiteSpace(odaTbox.Text))
                {
                    MessageBox.Show("You must fill in the all empty fields");
                }
                else
                {
                    string o_Ad = oteladTbox.Text, o_Il = ilTbox.Text, o_Ilce = ilceTbox.Text, o_Adres = adresTxt.Text,
                           o_Tel = telefonTbox.Text, o_EPosta = epostaTbox.Text;
                    int o_Yildiz = Convert.ToInt32(yildizTbox.Text), o_Oda = Convert.ToInt32(odaTbox.Text);
                    var query1 = new OtelKayit
                    {
                        otelAdi = o_Ad,
                        otelIl = o_Il,
                        otelIlce = o_Ilce,
                        otelAdres = o_Adres,
                        otelTel = o_Tel,
                        otelEPosta = o_EPosta,
                        yildizSayisi = o_Yildiz,
                        odaSayisi = o_Oda
                    };
                    db.OtelKayits.Add(query1);
                    db.SaveChanges();
                    MessageBox.Show("Insertion successfully!");
                }
            }
        }

        private void Kayitbtn_Click(object sender, EventArgs e)
        {
            using(var db = new OtelBilgiEntities3())
            {
                LinkedList ll = new LinkedList();
                var query = from a in db.CalisanBilgis select a;

                OtelBinary o = new OtelBinary();

                foreach(var item in query)
                {
                    o = item;
                    ll.InsertLast(o);
                }
                MessageBox.Show(ll.DisplayElements());

            }
            using (var db = new OtelBilgiEntities3())
            {
                if (string.IsNullOrWhiteSpace(TcNotbox.Text) || string.IsNullOrWhiteSpace(Adtbox.Text) || string.IsNullOrWhiteSpace(soyadtbox.Text) ||
                    string.IsNullOrWhiteSpace(adrestbox.Text) || string.IsNullOrWhiteSpace(Departmantbox.Text) || string.IsNullOrWhiteSpace(teltbox.Text) ||
                    string.IsNullOrWhiteSpace(Pozisyontbox.Text) || string.IsNullOrWhiteSpace(epostotbox.Text))
                {
                    MessageBox.Show("You must fill in the all empty fields");
                }
                else
                {
                    string TC = TcNotbox.Text, ad = Adtbox.Text, soyad = soyadtbox.Text,
                           tel = teltbox.Text, adres = adrestbox.Text;
                    string ePosta = epostotbox.Text, departman = Departmantbox.Text,
                           pozisyon = Pozisyontbox.Text;

                    var query = new CalisanBilgi
                    {
                        calisanTC = TC,
                        calisanAd = ad,
                        calisanSoyad = soyad,
                        calisanTel = tel,
                        calisanAdres = adres,
                        calisanEPosta = ePosta,
                        calisanDepartaman = departman,
                        calisanPozisyon = pozisyon
                    };
                    db.CalisanBilgis.Add(query);
                    db.SaveChanges();
                    MessageBox.Show("Insertion successfully!");
                }
            }
        }

        private void Yonetici_Load(object sender, EventArgs e)
        {
            using (var db = new OtelBilgiEntities3())
            {
                var sorgu = from a in db.CalisanBilgis.OrderBy(p=>p.calisanTC) select a;

                foreach (var item in sorgu)
                {
                    metroComboBox1.Items.Add(item.calisanTC);
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            OtelBilgiEntities3 db = new OtelBilgiEntities3();
            var sorgu = from a in db.CalisanBilgis where a.calisanTC == metroComboBox1.SelectedItem.ToString() select a;
            foreach (var item in sorgu)
            {
                personelAdresTbox.Text = item.calisanAdres;
                personelAdTbox.Text = item.calisanAd;
                personelTCtbox.Text = item.calisanTC;
                personelSoyadTbox.Text = item.calisanSoyad;
                personelTelTbox.Text = item.calisanTel;
                personelDepartmanTbox.Text = item.calisanDepartaman;
                personelEpostaTbox.Text = item.calisanEPosta;
                personelPozisyonTbox.Text = item.calisanPozisyon;
                MessageBox.Show("Başarılı");
            }
        }

        private void personelSilbtn_Click(object sender, EventArgs e)
        {
            OtelBilgiEntities3 db = new OtelBilgiEntities3();
        }
    }
}
