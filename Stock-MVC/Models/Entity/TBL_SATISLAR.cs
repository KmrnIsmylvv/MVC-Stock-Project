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
    
    public partial class TBL_SATISLAR
    {
        public int SATISID { get; set; }
        public Nullable<int> MEHSUL { get; set; }
        public Nullable<int> MUSTERI { get; set; }
        public Nullable<byte> EDED { get; set; }
        public Nullable<decimal> QIYMET { get; set; }
    
        public virtual TBL_MEHSULLAR TBL_MEHSULLAR { get; set; }
        public virtual TBL_MUSTERILER TBL_MUSTERILER { get; set; }
    }
}
