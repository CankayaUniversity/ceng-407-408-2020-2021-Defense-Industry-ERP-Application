using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ERP_APP.Models.DB;
using Microsoft.AspNetCore.Http;

namespace ERP_APP.Pages
{
    public class AccCreateModel : PageModel
    {
        private readonly ERP_APP.Models.DB.ERPDBContext _context;

        public AccCreateModel(ERP_APP.Models.DB.ERPDBContext context)
        {
            _context = context;
        }
        public String UserRole { get; set; }
        public IActionResult OnGet()
        {
            UserRole = HttpContext.Session.GetString("UserRole");
            return Page();
        }

        [BindProperty]
        public TblAcc TblAcc { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.TblAccs.Add(TblAcc);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Welcome");
        }
    }
}
