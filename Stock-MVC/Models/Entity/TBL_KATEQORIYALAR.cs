//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Stock_MVC.Models.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class TBL_KATEQORIYALAR
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBL_KATEQORIYALAR()
        {
            this.TBL_MEHSULLAR = new HashSet<TBL_MEHSULLAR>();
        }
    
        public int KATEQORIYAID { get; set; }
        public string KATEQORIYAAD { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBL_MEHSULLAR> TBL_MEHSULLAR { get; set; }
    }
}
