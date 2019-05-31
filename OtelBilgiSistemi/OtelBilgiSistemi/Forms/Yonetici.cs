using System;
using System.Windows.Forms;
using System.Linq;
namespace OtelBilgiSistemi.Forms
{
    public partial class Yonetici : MetroFramework.Forms.MetroForm
    {
        public Yonetici()
        {
            InitializeComponent();
        }

        private void Yonetici_Load(object sender, EventArgs e)
        {

        }

        private void Kayitbtn_Click(object sender, EventArgs e)
        {
            using (var db = new OtelDbcontext())
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
                    int per = Convert.ToInt32(personelPuanTbox.Text);

                    var query = new OtelCalisan
                    {
                        TCKimlik = TC,
                        Ad = ad,
                        Soyad = soyad,
                        Telefon = tel,
                        Adres = adres,
                        Eposta = ePosta,
                        Departman = departman,
                        personelpuan = per
                    };
                    db.OtelCalisans.Add(query);
                    db.SaveChanges();
                    MessageBox.Show("Insertion successfully!");
                }
                foreach (var item in db.OtelCalisans)
                {
                    //metroListView2.Items.Add(item.Id.ToString());
                }
            }
        }
        OtelDbcontext db = new OtelDbcontext();
        public void OtelCalisana ()
        {
            foreach (var item in db.OtelCalisans)
            {
                metroComboBox1.Items.Add(item.Id.ToString());
            }
        }
        public void OtelKayit()
        {
            foreach(var item in db.OtelKayits)
            {
                metroComboBox2.Items.Add(item.Id.ToString());
            }
        }
        
        private void metroButton1_Click(object sender, EventArgs e)
        {
            using (var db = new OtelDbcontext())
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
                        OtelAd = o_Ad,
                        Sehir = o_Il,
                        Ilce = o_Ilce,
                        OtelAdres = o_Adres,
                        Telefon = o_Tel,
                        EPosta = o_EPosta,
                        YildizSayisi = o_Yildiz,
                        OdaSayisi = o_Oda
                    };
                    db.OtelKayits.Add(query1);
                    db.SaveChanges();
                    MessageBox.Show("Insertion successfully");
                }
            }
        }

        private void Listele_Click(object sender, EventArgs e)
        {
            OtelCalisana();
        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var sorgu = from a in db.OtelCalisans where a.Id.ToString() == metroComboBox1.SelectedItem.ToString() select a;
            foreach (var item in sorgu)
            {
                personelTCtbox.Text = item.TCKimlik;
                personelTelTbox.Text = item.Telefon;
                personelSoyadTbox.Text = item.Soyad;
                personelAdTbox.Text = item.Ad;
                personelDepartmanTbox.Text = item.Departman;
                personelEpostaTbox.Text = item.Eposta;
                personelAdresTbox.Text = item.Adres;
            }
        }

        private void metroComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            var sorgu = from a in db.OtelKayits where a.Id.ToString() == metroComboBox2.SelectedItem.ToString() select a;
            foreach (var item in sorgu)
            {
                metroTextBox9.Text = item.OtelAd;
                metroTextBox8.Text = item.Sehir;
                metroTextBox6.Text = item.Ilce;
                metroTextBox7.Text = item.OtelAdres;
                metroTextBox3.Text = item.Telefon;
                metroTextBox2.Text = item.EPosta;
                metroTextBox1.Text = Convert.ToInt32(item.YildizSayisi).ToString();
                metroTextBox5.Text = Convert.ToInt32(item.OdaSayisi).ToString();
            }
        }

        private void listeleBtn_Click(object sender, EventArgs e)
        {
            OtelKayit();
        }

        private void PersonelGuncelleBtn_Click(object sender, EventArgs e)
        {
            var sorgu = from a in db.OtelCalisans where a.TCKimlik == personelTCtbox.Text select a;
            foreach(var item in sorgu)
            {
                item.TCKimlik = personelTCtbox.Text;
                item.Ad = personelAdTbox.Text;
                item.Adres = personelAdresTbox.Text;
                item.Departman = personelDepartmanTbox.Text;
                item.Eposta = personelEpostaTbox.Text;
                item.Telefon = personelTelTbox.Text;
                item.Soyad = personelSoyadTbox.Text;
            }
            db.SaveChanges();
            MessageBox.Show("Güncelleme Başarılı");
        }

        private void guncelleBtn_Click(object sender, EventArgs e)
        {
            var sorgu = from a in db.OtelKayits where a.OtelAd == metroTextBox9.Text select a;
            foreach(var item in sorgu)
            {
                metroTextBox9.Text = item.OtelAd;
                metroTextBox8.Text = item.Sehir;
                metroTextBox6.Text = item.Ilce;
                metroTextBox7.Text = item.OtelAdres;
                metroTextBox3.Text = item.Telefon;
                metroTextBox2.Text = item.EPosta;
                metroTextBox1.Text = Convert.ToInt32(item.YildizSayisi).ToString();
                metroTextBox5.Text = Convert.ToInt32(item.OdaSayisi).ToString();
            }
            db.SaveChanges();
            MessageBox.Show("Güncelleme Başarılı");
        }

        private void silbtn_Click(object sender, EventArgs e)
        {
            var sorgu = from a in db.OtelKayits where a.OtelAd == metroTextBox9.Text select a;
            foreach(var item in sorgu)
            {
                db.OtelKayits.Remove(item);
            }
            db.SaveChanges();
            MessageBox.Show("Silme Başarılı");
        }

        private void personelSilbtn_Click(object sender, EventArgs e)
        {
            var sorgu = from a in db.OtelCalisans where a.TCKimlik == personelTCtbox.Text select a;
            foreach (var item in sorgu)
            {
                db.OtelCalisans.Remove(item);
            }
            db.SaveChanges();
            MessageBox.Show("Silme Başarılı");
        }

        private void departmanBtn_Click(object sender, EventArgs e)
        {
            var sorgu = from a in db.OtelCalisans orderby a.Departman select a;
            foreach(var item in sorgu)
            {
                metroTextBox4.Text += item.Departman + " - " + item.Ad + "\n" + Environment.NewLine;
            }
        }

        private void puanBtn_Click(object sender, EventArgs e)
        {
            var sorgu = from a in db.OtelCalisans orderby a.personelpuan descending select a;
            foreach(var item in sorgu)
            {
                metroTextBox10.Text += item.personelpuan + " - " + item.Ad + "\n" + Environment.NewLine;
            }
        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            Giris g = new Giris();
            g.Show();
            this.Hide();
        }
    }
}
