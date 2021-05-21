using System;
using System.Collections.Generic;

#nullable disable

namespace ERP_APP.Models.DB
{
    public partial class TblFirstQuality
    {

       /* public TblFirstQuality()
        {
            Product = new TblRecordProduct();
        }*/

        public int? ProductId { get; set; }
        public int PartId { get; set; }
        public string PartNo { get; set; }
        public string Nsn { get; set; }
        public int? PartPiece { get; set; }
        public int? PartRemainPiece { get; set; }
        public string PartPieceType { get; set; }
        public string LotBatchNo { get; set; }
        public string Remark { get; set; }

        public virtual TblRecordProduct Product { get; set; }
    }
}
