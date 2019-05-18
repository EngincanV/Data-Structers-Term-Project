using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace OtelbilgiSistemi.Veri_Yapıları
{
    public class Calisan
    {
        public int ID { get; set; }
        public string CalisanTC { get; set; }
        public string CalisanAd { get; set; }
        public string CalisanSoyad { get; set; }
        public string CalisanTel { get; set; }
        public string CalisanAdres { get; set; }
        public string CalisanEPosta { get; set; }
        public string CalisanDepartman { get; set; }
        public string CalisanPozisyon { get; set; }
    }
}
