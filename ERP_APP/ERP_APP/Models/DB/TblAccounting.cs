using System;
using System.Collections.Generic;

#nullable disable

namespace ERP_APP.Models.DB
{
    public partial class TblAccounting
    {
        public int? HResourceId { get; set; }
        public int AccId { get; set; }
        public string aylar { get; set; }
        public int? Salary { get; set; }
        public int? sigortalar { get; set; }
        public int? digergider { get; set; }
        public int? gelir { get; set; }
        public string vergidurumu { get; set; }
        public string Remarks { get; set; }

   
        public virtual TblHumanR HResource { get; set; }

        public static implicit operator TblAccounting(List<TblAccounting> v)
        {
            throw new NotImplementedException();
        }
    }
}
