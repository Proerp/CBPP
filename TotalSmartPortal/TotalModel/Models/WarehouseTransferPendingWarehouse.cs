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
    
    public partial class WarehouseTransferPendingWarehouse
    {
        public int WarehouseID { get; set; }
        public string WarehouseCode { get; set; }
        public int WarehouseReceiptID { get; set; }
        public string WarehouseReceiptCode { get; set; }
        public string WarehouseName { get; set; }
        public Nullable<bool> HasTransferOrder { get; set; }
        public string WarehouseReceiptName { get; set; }
        public int LocationReceiptID { get; set; }
        public int LocationIssuedID { get; set; }
    }
}
