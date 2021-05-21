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
    public class WDeleteModel : PageModel
    {
        private readonly ERP_APP.Models.DB.ERPDBContext _context;

        public WDeleteModel(ERP_APP.Models.DB.ERPDBContext context)
        {
            _context = context;
        }

        [BindProperty]
        public TblWarehouse TblWarehouse { get; set; }
        public String UserRole { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            UserRole = HttpContext.Session.GetString("UserRole");
            if (id == null)
            {
                return NotFound();
            }

            TblWarehouse = await _context.TblWarehouses
                .Include(t => t.Product).FirstOrDefaultAsync(m => m.WarehouseId == id);

            if (TblWarehouse == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            TblWarehouse = await _context.TblWarehouses.FindAsync(id);

            if (TblWarehouse != null)
            {
                _context.TblWarehouses.Remove(TblWarehouse);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./WDisplay");
        }
    }
}
