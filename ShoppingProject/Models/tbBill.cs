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
    
    public partial class tbBill
    {
        public int Bill_Id { get; set; }
        public Nullable<int> OrderId { get; set; }
        public string ItemName { get; set; }
        public Nullable<decimal> Bill_Qty { get; set; }
        public decimal Bill_Price { get; set; }
        public Nullable<decimal> Bill_Total { get; set; }
        public string UserName { get; set; }
        public Nullable<System.DateTime> Bill_Date { get; set; }
        public string OrderNo { get; set; }
    }
}
