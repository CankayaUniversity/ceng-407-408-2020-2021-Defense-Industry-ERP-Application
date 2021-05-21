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
    public class HDeleteModel : PageModel
    {
        private readonly ERP_APP.Models.DB.ERPDBContext _context;

        public HDeleteModel(ERP_APP.Models.DB.ERPDBContext context)
        {
            _context = context;
        }

        [BindProperty]
        public TblHumanR TblHumanR { get; set; }
        public String UserRole { get; set; }
        public async Task<IActionResult> OnGetAsync(int? id)
        {
            UserRole = HttpContext.Session.GetString("UserRole");
            if (id == null)
            {
                return NotFound();
            }

            TblHumanR = await _context.TblHumanRs.FirstOrDefaultAsync(m => m.HResourceId == id);

            if (TblHumanR == null)
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

            TblHumanR = await _context.TblHumanRs.FindAsync(id);

            if (TblHumanR != null)
            {
                _context.TblHumanRs.Remove(TblHumanR);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./HDisplay");
        }
    }
}
