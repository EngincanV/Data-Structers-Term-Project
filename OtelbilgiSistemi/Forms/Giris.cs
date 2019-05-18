using OtelbilgiSistemi.Data;
using OtelbilgiSistemi.Forms;
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
    public partial class Giris : MetroFramework.Forms.MetroForm
    {
        public Giris()
        {
            InitializeComponent();
        }

        private void kayitBtn_Click(object sender, EventArgs e)
        {
            Kayit ky = new Kayit();
            ky.Show();
            this.Hide();
        }

        Yonetici yon = new Yonetici();
        Kullanici kul = new Kullanici();

        private void girisBtn_Click(object sender, EventArgs e)
        {
            using (var db = new OtelBilgiEntities())
            {
                string eposta = girisEpostaTbox.Text, sifre = girisSifreTbox.Text;
                if (string.IsNullOrWhiteSpace(girisEpostaTbox.Text) || string.IsNullOrWhiteSpace(girisSifreTbox.Text))
                {
                    MessageBox.Show("You must fill in the all empty fields");
                }
                else
                {
                    MusteriKayit kd = new MusteriKayit();
                    var sorgu2 = from a in db.MusteriKayits where a.musteriEPosta == eposta select a.musteriEPosta;
                    var sorgu3 = from a in db.MusteriKayits where a.musteriSifre == sifre select a.musteriSifre;
                    var sorgu = from a in db.MusteriKayits where a.musteriEPosta == eposta && a.musteriSifre == sifre select a.isTrue;
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
                        foreach (int item in sorgu)
                        {
                            if (item == 1)
                            {
                                yon.Show();
                                this.Hide();
                                kul.Hide();
                            }
                            else if (item == 0)
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
    }
}

