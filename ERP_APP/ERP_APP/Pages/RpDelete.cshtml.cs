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
    public class RpDeleteModel : PageModel
    {
        private readonly ERP_APP.Models.DB.ERPDBContext _context;

        public RpDeleteModel(ERP_APP.Models.DB.ERPDBContext context)
        {
            _context = context;
        }

        [BindProperty]
        public TblRecordProduct TblRecordProduct { get; set; }
        public String UserRole { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            UserRole = HttpContext.Session.GetString("UserRole");
            if (id == null)
            {
                return NotFound();
            }

            TblRecordProduct = await _context.TblRecordProducts.FirstOrDefaultAsync(m => m.ProductId == id);

            if (TblRecordProduct == null)
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

            TblRecordProduct = await _context.TblRecordProducts.FindAsync(id);

            if (TblRecordProduct != null)
            {
                _context.TblRecordProducts.Remove(TblRecordProduct);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./RpDisplay");
        }
    }
}
