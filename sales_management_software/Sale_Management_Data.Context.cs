﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace sales_management_software
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class Sale_ManagementEntities : DbContext
    {
        public Sale_ManagementEntities()
            : base("name=Sale_ManagementEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<DON_HANG> DON_HANG { get; set; }
        public virtual DbSet<HOA_DON> HOA_DON { get; set; }
        public virtual DbSet<KHACH_HANG> KHACH_HANG { get; set; }
        public virtual DbSet<KHO_HANG> KHO_HANG { get; set; }
        public virtual DbSet<LOAI_SAN_PHAM> LOAI_SAN_PHAM { get; set; }
        public virtual DbSet<NHA_CUNG_CAP> NHA_CUNG_CAP { get; set; }
        public virtual DbSet<NHAN_VIEN> NHAN_VIEN { get; set; }
        public virtual DbSet<SAN_PHAM> SAN_PHAM { get; set; }
        public virtual DbSet<SHIPPER> SHIPPERs { get; set; }
        public virtual DbSet<THONG_SO_KY_THUAT> THONG_SO_KY_THUAT { get; set; }
    
        public virtual int Insert_sp(string masp, string tensp, Nullable<int> dongia, Nullable<int> soluong, string maNCC, string maloai, Nullable<bool> deleted)
        {
            var maspParameter = masp != null ?
                new ObjectParameter("masp", masp) :
                new ObjectParameter("masp", typeof(string));
    
            var tenspParameter = tensp != null ?
                new ObjectParameter("tensp", tensp) :
                new ObjectParameter("tensp", typeof(string));
    
            var dongiaParameter = dongia.HasValue ?
                new ObjectParameter("dongia", dongia) :
                new ObjectParameter("dongia", typeof(int));
    
            var soluongParameter = soluong.HasValue ?
                new ObjectParameter("soluong", soluong) :
                new ObjectParameter("soluong", typeof(int));
    
            var maNCCParameter = maNCC != null ?
                new ObjectParameter("maNCC", maNCC) :
                new ObjectParameter("maNCC", typeof(string));
    
            var maloaiParameter = maloai != null ?
                new ObjectParameter("maloai", maloai) :
                new ObjectParameter("maloai", typeof(string));
    
            var deletedParameter = deleted.HasValue ?
                new ObjectParameter("deleted", deleted) :
                new ObjectParameter("deleted", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Insert_sp", maspParameter, tenspParameter, dongiaParameter, soluongParameter, maNCCParameter, maloaiParameter, deletedParameter);
        }
    
        public virtual ObjectResult<Select_kho_Result> Select_kho()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Select_kho_Result>("Select_kho");
        }
    
        public virtual ObjectResult<Select_lsp_Result> Select_lsp()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Select_lsp_Result>("Select_lsp");
        }
    
        public virtual ObjectResult<Select_ncc_Result> Select_ncc()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Select_ncc_Result>("Select_ncc");
        }
    
        public virtual ObjectResult<Select_sp_Result> Select_sp()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Select_sp_Result>("Select_sp");
        }
    
        public virtual int Update_sp(string masp, string tensp, Nullable<int> dongia, Nullable<int> soluong, string maNCC, string maloai, Nullable<bool> deleted)
        {
            var maspParameter = masp != null ?
                new ObjectParameter("masp", masp) :
                new ObjectParameter("masp", typeof(string));
    
            var tenspParameter = tensp != null ?
                new ObjectParameter("tensp", tensp) :
                new ObjectParameter("tensp", typeof(string));
    
            var dongiaParameter = dongia.HasValue ?
                new ObjectParameter("dongia", dongia) :
                new ObjectParameter("dongia", typeof(int));
    
            var soluongParameter = soluong.HasValue ?
                new ObjectParameter("soluong", soluong) :
                new ObjectParameter("soluong", typeof(int));
    
            var maNCCParameter = maNCC != null ?
                new ObjectParameter("maNCC", maNCC) :
                new ObjectParameter("maNCC", typeof(string));
    
            var maloaiParameter = maloai != null ?
                new ObjectParameter("maloai", maloai) :
                new ObjectParameter("maloai", typeof(string));
    
            var deletedParameter = deleted.HasValue ?
                new ObjectParameter("deleted", deleted) :
                new ObjectParameter("deleted", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Update_sp", maspParameter, tenspParameter, dongiaParameter, soluongParameter, maNCCParameter, maloaiParameter, deletedParameter);
        }
    }
}
