//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OrnekWeb.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Faturalars
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Faturalars()
        {
            this.FaturaKalems = new HashSet<FaturaKalems>();
        }
    
        public int Faturaid { get; set; }
        public string FaturaSeriNo { get; set; }
        public string FaturaSıraNo { get; set; }
        public System.DateTime Tarih { get; set; }
        public string VergiDairesi { get; set; }
        public string Saat { get; set; }
        public string TeslimEden { get; set; }
        public string TeslimAlan { get; set; }
        public decimal Toplam { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FaturaKalems> FaturaKalems { get; set; }
    }
}