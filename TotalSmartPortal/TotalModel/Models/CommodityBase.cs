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
    
    public partial class CommodityBase
    {
        public int CommodityID { get; set; }
        public string CommodityCode { get; set; }
        public string CommodityName { get; set; }
        public int CommodityTypeID { get; set; }
        public decimal ListedPrice { get; set; }
        public decimal GrossPrice { get; set; }
        public decimal DiscountPercent { get; set; }
        public decimal TradeDiscountRate { get; set; }
        public decimal VATPercent { get; set; }
        public Nullable<int> BomID { get; set; }
        public string BomCode { get; set; }
        public string BomName { get; set; }
        public Nullable<decimal> BlockUnit { get; set; }
        public Nullable<decimal> BlockQuantity { get; set; }
        public Nullable<int> MoldID { get; set; }
        public string MoldCode { get; set; }
        public string MoldName { get; set; }
        public Nullable<decimal> MoldQuantity { get; set; }
        public int PiecePerPack { get; set; }
        public decimal QuantityAvailables { get; set; }
    }
}