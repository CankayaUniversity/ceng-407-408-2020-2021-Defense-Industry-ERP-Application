using System;
using System.Collections.Generic;

#nullable disable

namespace ERP_APP.Models.DB
{
    public partial class TblWarehouse
    {
        public TblWarehouse()
        {
            TblProductions = new HashSet<TblProduction>();
        }

        public int? ProductId { get; set; }
        public int WarehouseId { get; set; }
        public DateTime? Date { get; set; }
        public DateTime? GivenDate { get; set; }
        public string ReceiverName { get; set; }
        public string Place { get; set; }
        public string Remarks { get; set; }

        public virtual TblRecordProduct Product { get; set; }
        public virtual ICollection<TblProduction> TblProductions { get; set; }
    }
}
