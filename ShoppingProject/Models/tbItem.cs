//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ShoppingProject.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbItem
    {
        public System.Guid It_Id { get; set; }
        public Nullable<int> Type_Id { get; set; }
        public string It_Code { get; set; }
        public string It_Name { get; set; }
        public string It_Des { get; set; }
        public Nullable<decimal> It_Price { get; set; }
        public string It_Img { get; set; }
        public Nullable<int> It_Unit { get; set; }
        public Nullable<bool> It_Delete { get; set; }
    }
}