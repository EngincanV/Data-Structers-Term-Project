using OtelbilgiSistemi.Data;
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

        }

        private void Kayitbtn_Click(object sender, EventArgs e)
        {
            using(var db = new OtelBilgiEntities())
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
    }
}
