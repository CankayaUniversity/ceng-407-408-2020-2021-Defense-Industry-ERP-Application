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
    public class SEditModel : PageModel
    {
        private readonly ERP_APP.Models.DB.ERPDBContext _context;

        public SEditModel(ERP_APP.Models.DB.ERPDBContext context)
        {
            _context = context;
        }

        [BindProperty]
        public TblShipment TblShipment { get; set; }
        public String UserRole { get; set; }
        public TblShipment S { get; set; }



        public TblProduction TblProductions { get; set; }
        public async Task<IActionResult> OnGetAsync(int? id)
        {
            UserRole = HttpContext.Session.GetString("UserRole");
            if (id == null)
            {
                return NotFound();
            }
           
            TblShipment = await _context.TblShipments
                .Include(t => t.Product).FirstOrDefaultAsync(m => m.ShipmentId == id);

            if (TblShipment == null)
            {
                return NotFound();
            }
          // ViewData["ProductId"] = new SelectList(_context.TblRecordProducts, "ProductId", "ProductId");
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

            _context.Attach(TblShipment).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TblShipmentExists(TblShipment.ShipmentId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./SDisplay");
        }

        private bool TblShipmentExists(int id)
        {
            return _context.TblShipments.Any(e => e.ShipmentId == id);
        }
    }
}
