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
    
    public partial class SalesReturnPendingGoodsIssue
    {
        public int GoodsIssueID { get; set; }
        public string GoodsIssueReference { get; set; }
        public System.DateTime GoodsIssueEntryDate { get; set; }
        public string DeliveryAdviceReferences { get; set; }
        public string CustomerCode { get; set; }
        public string CustomerName { get; set; }
        public string ShippingAddress { get; set; }
        public string Description { get; set; }
        public Nullable<int> TradePromotionID { get; set; }
        public string TradePromotionSpecs { get; set; }
        public decimal TradeDiscountRate { get; set; }
        public decimal VATPercent { get; set; }
        public decimal TotalQuantity { get; set; }
        public decimal TotalFreeQuantity { get; set; }
        public decimal TotalGrossAmount { get; set; }
    }
}
