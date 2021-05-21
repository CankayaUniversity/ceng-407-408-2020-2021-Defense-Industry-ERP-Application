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
    public class AccDeleteModel : PageModel
    {
        private readonly ERP_APP.Models.DB.ERPDBContext _context;

        public AccDeleteModel(ERP_APP.Models.DB.ERPDBContext context)
        {
            _context = context;
        }

        [BindProperty]
        public TblAcc TblAcc { get; set; }
        public String UserRole { get; set; }
        public async Task<IActionResult> OnGetAsync(int? id)
        {
            UserRole = HttpContext.Session.GetString("UserRole");
            if (id == null)
            {
                return NotFound();
            }

            TblAcc = await _context.TblAccs.FirstOrDefaultAsync(m => m.UserId == id);

            if (TblAcc == null)
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

            TblAcc = await _context.TblAccs.FindAsync(id);

            if (TblAcc != null)
            {
                _context.TblAccs.Remove(TblAcc);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Welcome");
        }
    }
}
