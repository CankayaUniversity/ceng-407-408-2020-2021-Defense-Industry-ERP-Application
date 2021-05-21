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
    public class FqDetailsModel : PageModel
    {
        private readonly ERP_APP.Models.DB.ERPDBContext _context;

        public FqDetailsModel(ERP_APP.Models.DB.ERPDBContext context)
        {
            _context = context;
        }

        public TblFirstQuality TblFirstQuality { get; set; }
        public String UserRole { get; set; }
        public async Task<IActionResult> OnGetAsync(int? id)
        {
            UserRole = HttpContext.Session.GetString("UserRole");
            if (id == null)
            {
                return NotFound();
            }

            TblFirstQuality = await _context.TblFirstQualities
                .Include(t => t.Product).FirstOrDefaultAsync(m => m.PartId == id);

            if (TblFirstQuality == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
