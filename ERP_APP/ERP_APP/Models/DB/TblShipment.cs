using System;
using System.Collections.Generic;

#nullable disable

namespace ERP_APP.Models.DB
{
    public partial class TblShipment
    {
        public int? ProductId { get; set; }
        public int ShipmentId { get; set; }
        public DateTime? Date { get; set; }
        public string InvoiceNo { get; set; }
        public int? Piece { get; set; }
        public string Remarks { get; set; }
        public string seriNo { get; set; }
        public string dokRev { get; set; }
        public string eyes { get; set; }
        public string elektrik { get; set; }
        public string paket { get; set; }

        public virtual TblRecordProduct Product { get; set; }
    }
}
