using System;
using System.Collections.Generic;

#nullable disable

namespace ERP_APP.Models.DB
{
    public partial class TblHumanR
    {
        public TblHumanR()
        {
            TblAccountings = new HashSet<TblAccounting>();
        }

        public int HResourceId { get; set; }
        public string WorkerName { get; set; }
        public string WorkerSurname { get; set; }
        public int? WorkerId { get; set; }
        public string WorkerSertificate { get; set; }
        public string WorkPerformance { get; set; }
        public string Remarks { get; set; }

        public virtual ICollection<TblAccounting> TblAccountings { get; set; }
    }
}
