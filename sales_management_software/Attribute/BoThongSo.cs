//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class BoThongSo
    {
        public string MaLSP { get; set; }
        public string MaTS { get; set; }
    
        public virtual ThongSoKyThuat ThongSoKyThuat { get; set; }
    }
}