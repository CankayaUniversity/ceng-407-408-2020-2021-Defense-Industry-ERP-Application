using System;
using System.Collections.Generic;

#nullable disable

namespace ERP_APP.Models.DB
{
    public partial class TblAcc
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string AccName { get; set; }
        public string UserPass { get; set; }
        public string UserRole { get; set; }
    }
}
