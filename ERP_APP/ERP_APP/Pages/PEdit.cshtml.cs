using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ERP_APP.Models.DB;
using Microsoft.AspNetCore.Http;

namespace ERP_APP.Pages
{
    public class PEditModel : PageModel
    {
        private readonly ERP_APP.Models.DB.ERPDBContext _context;

        public PEditModel(ERP_APP.Models.DB.ERPDBContext context)
        {
            _context = context;
        }

        [BindProperty]
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
           ViewData["ProductId"] = new SelectList(_context.TblRecordProducts, "ProductId", "ProductId");
           ViewData["WarehouseId"] = new SelectList(_context.TblWarehouses, "WarehouseId", "WarehouseId");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(TblProduction).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TblProductionExists(TblProduction.ProductionId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./PDisplay");
        }

        private bool TblProductionExists(int id)
        {
            return _context.TblProductions.Any(e => e.ProductionId == id);
        }
    }
}
