using System;
using System.Collections.Generic;

#nullable disable

namespace ERP_APP.Models.DB
{
    public partial class TblRecordProduct
    {
        public TblRecordProduct()
        {
            TblFirstQualities = new HashSet<TblFirstQuality>();
            TblProductions = new HashSet<TblProduction>();
            TblShipments = new HashSet<TblShipment>();
            TblWarehouses = new HashSet<TblWarehouse>();
        }

        public int ProductId { get; set; }
        public string StokNo { get; set; }
        public string OrderNo { get; set; }
        public string WorkOrderNo { get; set; }
        public int? Piece { get; set; }
        public int? RemainPiece { get; set; }
        public string PieceType { get; set; }
        public DateTime? Date { get; set; }
        public string CompanyName { get; set; }
        public string Remarks { get; set; }

        public string tanim { get; set; }
        public virtual ICollection<TblFirstQuality> TblFirstQualities { get; set; }
        public virtual ICollection<TblProduction> TblProductions { get; set; }
        public virtual ICollection<TblShipment> TblShipments { get; set; }
        public virtual ICollection<TblWarehouse> TblWarehouses { get; set; }
    }
}
