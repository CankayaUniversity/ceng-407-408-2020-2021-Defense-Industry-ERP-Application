using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ERP_APP.Models.DB;
using Microsoft.AspNetCore.Http;

namespace ERP_APP.Pages
{
    public class SDisplayModel : PageModel
    {
        private readonly ERP_APP.Models.DB.ERPDBContext _context;

        public SDisplayModel(ERP_APP.Models.DB.ERPDBContext context)
        {
            _context = context;
        }

        public IList<TblShipment> TblShipment { get;set; }
        public String UserRole { get; set; }
        public IList<TblAcc> TblAcc { get; set; }
        public async Task OnGetAsync()
        {
            TblShipment = await _context.TblShipments.Include(t => t.Product).ToListAsync();
            TblAcc = await _context.TblAccs.ToListAsync();
            UserRole = HttpContext.Session.GetString("UserRole");
        }
    }
}
