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
    public class AEditModel : PageModel
    {
        private readonly ERP_APP.Models.DB.ERPDBContext _context;

        public AEditModel(ERP_APP.Models.DB.ERPDBContext context)
        {
            _context = context;
        }

        [BindProperty]
        public TblAccounting TblAccounting { get; set; }

        public String UserRole { get; set; }
        public async Task<IActionResult> OnGetAsync(int? id)
        {
            UserRole = HttpContext.Session.GetString("UserRole");
            if (id == null)
            {
                return NotFound();
            }

            TblAccounting = await _context.TblAccountings
                .Include(t => t.HResource).FirstOrDefaultAsync(m => m.AccId == id);

            if (TblAccounting == null)
            {
                return NotFound();
            }
           ViewData["HResourceId"] = new SelectList(_context.TblHumanRs, "HResourceId", "HResourceId");
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

            _context.Attach(TblAccounting).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TblAccountingExists(TblAccounting.AccId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./ADisplay");
        }

        private bool TblAccountingExists(int id)
        {
            return _context.TblAccountings.Any(e => e.AccId == id);
        }
    }
}
