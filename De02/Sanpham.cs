//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace De02
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;

    public partial class Sanpham
    {
        public string MaSP { get; set; }
        public string TenSP { get; set; }
        public Nullable<System.DateTime> Ngaynhap { get; set; }
        public string MaLoai { get; set; }
        [Browsable(false)]    
        
        public virtual LoaiSP LoaiSP { get; set; }
    }
}
