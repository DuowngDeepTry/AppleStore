//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AppleStore.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Don_Hang
    {
        public Don_Hang()
        {
            this.Chi_Tiet_Don_Hang = new HashSet<Chi_Tiet_Don_Hang>();
        }
    
        public int id { get; set; }
        public string ten { get; set; }
        public string SDT { get; set; }
        public string email { get; set; }
        public string diachi { get; set; }
        public string tieude { get; set; }
        public Nullable<System.DateTime> ngaytao { get; set; }
        public Nullable<double> tongtien { get; set; }
        public Nullable<int> idtrangthai { get; set; }
        public Nullable<int> idNgDung { get; set; }
    
        public virtual ICollection<Chi_Tiet_Don_Hang> Chi_Tiet_Don_Hang { get; set; }
        public virtual Nguoi_Dung Nguoi_Dung { get; set; }
        public virtual Trang_Thai Trang_Thai { get; set; }
    }
}