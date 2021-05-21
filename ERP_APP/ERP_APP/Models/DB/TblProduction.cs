using System;
using System.Collections.Generic;

#nullable disable

namespace ERP_APP.Models.DB
{
    public partial class TblProduction
    {
        public int ProductionId { get; set; }
        public int? WarehouseId { get; set; }
        public int? ProductId { get; set; }
        public string SerialNum { get; set; }
        public string Status { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string ProductionType { get; set; }
        public string HarnessType { get; set; }
        public string Notification { get; set; }
        public string Place { get; set; }
        public string IsTest { get; set; }
        public string IsOuality { get; set; }
        public string IsFinal { get; set; }
        public string Remarks { get; set; }

        public virtual TblRecordProduct Product { get; set; }
        public virtual TblWarehouse Warehouse { get; set; }
    }
}
