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
    public class PDetailsModel : PageModel
    {
        private readonly ERP_APP.Models.DB.ERPDBContext _context;

        public PDetailsModel(ERP_APP.Models.DB.ERPDBContext context)
        {
            _context = context;
        }

        public TblProduction TblProduction { get; set; }
        public String UserRole { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            UserRole = HttpContext.Session.GetString("UserRole");
            if (id == null)
            {
                return NotFound();
            }

            TblProduction = await _context.TblProductions
                .Include(t => t.Product)
                .Include(t => t.Warehouse).FirstOrDefaultAsync(m => m.ProductionId == id);

            if (TblProduction == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
