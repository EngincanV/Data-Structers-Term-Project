//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OtelbilgiSistemi.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class OtelKayit
    {
        public int id { get; set; }
        public string otelAdi { get; set; }
        public string otelIl { get; set; }
        public string otelIlce { get; set; }
        public string otelAdres { get; set; }
        public string otelTel { get; set; }
        public string otelEPosta { get; set; }
        public int yildizSayisi { get; set; }
        public int odaSayisi { get; set; }
        public Nullable<double> otelPuani { get; set; }
        public Nullable<int> currentCalisan { get; set; }
    
        public virtual CalisanBilgi CalisanBilgi { get; set; }
        public virtual MusteriYorum MusteriYorum { get; set; }
    }
}
