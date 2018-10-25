//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TotalModel.Models
{
    using System;
    
    public partial class CustomerBase
    {
        public int CustomerID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string CodeAndName { get; set; }
        public string OfficialName { get; set; }
        public Nullable<System.DateTime> Birthday { get; set; }
        public string VATCode { get; set; }
        public string Telephone { get; set; }
        public string BillingAddress { get; set; }
        public string ShippingAddress { get; set; }
        public int CustomerCategoryID { get; set; }
        public string CustomerCategoryName { get; set; }
        public bool ShowDiscount { get; set; }
        public int TerritoryID { get; set; }
        public string EntireTerritoryEntireName { get; set; }
        public int PaymentTermID { get; set; }
        public int PriceCategoryID { get; set; }
        public string PriceCategoryCode { get; set; }
        public int SalespersonID { get; set; }
        public string SalespersonName { get; set; }
        public int WarehouseID { get; set; }
        public string WarehouseCode { get; set; }
        public string WarehouseName { get; set; }
    }
}
