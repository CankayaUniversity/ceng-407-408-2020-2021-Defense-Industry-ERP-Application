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
    public class ADetailsModel : PageModel
    {
        private readonly ERP_APP.Models.DB.ERPDBContext _context;

        public ADetailsModel(ERP_APP.Models.DB.ERPDBContext context)
        {
            _context = context;
        }

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
            return Page();
        }
    }
}
