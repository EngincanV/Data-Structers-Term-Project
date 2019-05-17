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
    public partial class Kayit : Form
    {
        public Kayit()
        {
            InitializeComponent();
        }
        private void Kayitbtn_Click(object sender, EventArgs e)
        {
            using (var db = new OtelBilgiEntities())
            {
                if (string.IsNullOrWhiteSpace(TcNotbox.Text) || string.IsNullOrWhiteSpace(Adtbox.Text) || string.IsNullOrWhiteSpace(soyadtbox.Text) ||
                    string.IsNullOrWhiteSpace(epostotbox.Text) || string.IsNullOrWhiteSpace(sifreTbox.Text) || string.IsNullOrWhiteSpace(teltbox.Text))
                {
                    MessageBox.Show("You must fill in the all empty fields");
                }
                else
                {
                    string ad, soyad, telefon, eposta, sifre;
                    string TcNo;
                    TcNo = TcNotbox.Text;
                    ad = Adtbox.Text;
                    soyad = soyadtbox.Text;
                    telefon = teltbox.Text;
                    eposta = epostotbox.Text;
                    sifre = sifreTbox.Text;
                    var query = new MusteriKayit
                    {
                        musteriAd = ad,
                        musteriTel = telefon,
                        musteriEPosta = eposta,
                        musteriSifre = sifre,
                        musteriSoyad = soyad,
                        musteriTC = TcNo,
                        isTrue=0
                    };
                    db.MusteriKayits.Add(query);
                    db.SaveChanges();
                    MessageBox.Show("Başarılı Kayıt");
                    Giris frm = new Giris();
                    frm.Show();
                    this.Hide();
                }
            }
        }
    }
}
