using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ERP_APP.Models.DB;

namespace ERP_APP.Pages
{
    public class PDeleteModel : PageModel
    {
        private readonly ERP_APP.Models.DB.ERPDBContext _context;

        public PDeleteModel(ERP_APP.Models.DB.ERPDBContext context)
        {
            _context = context;
        }

        [BindProperty]
        public TblProduction TblProduction { get; set; }
        public String UserRole { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            TblProduction = await _context.TblProductions.FindAsync(id);

            if (TblProduction != null)
            {
                _context.TblProductions.Remove(TblProduction);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./PDisplay");
        }
    }
}
