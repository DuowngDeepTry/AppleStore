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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class AppleStoreEntities : DbContext
    {
        public AppleStoreEntities()
            : base("name=AppleStoreEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Chi_Tiet_Don_Hang> Chi_Tiet_Don_Hang { get; set; }
        public DbSet<Don_Hang> Don_Hang { get; set; }
        public DbSet<Loai_San_Pham> Loai_San_Pham { get; set; }
        public DbSet<Nguoi_Dung> Nguoi_Dung { get; set; }
        public DbSet<San_Pham> San_Pham { get; set; }
        public DbSet<sysdiagram> sysdiagrams { get; set; }
        public DbSet<Trang_Thai> Trang_Thai { get; set; }
    }
}
