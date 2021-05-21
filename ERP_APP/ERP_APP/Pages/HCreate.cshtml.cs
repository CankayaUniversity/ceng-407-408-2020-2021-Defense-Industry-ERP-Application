using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ERP_APP.Models.DB;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace ERP_APP.Pages
{
    public class HCreateModel : PageModel
    {
        private readonly ERP_APP.Models.DB.ERPDBContext _context;

        public HCreateModel(ERP_APP.Models.DB.ERPDBContext context)
        {
            _context = context;
        }
        [BindProperty]
        public TblHumanR TblHumanR { get; set; }
        public TblHumanR H { get; set; }
        public String UserRole { get; set; }

        
         public IActionResult OnGet()
         {
             UserRole = HttpContext.Session.GetString("UserRole");
             return Page();
         }
      /* public async Task<IActionResult> OnGetAsync(int? id)
        {
            UserRole = HttpContext.Session.GetString("UserRole");
            if (id == null)
            {
                return NotFound();
            }


            H = await _context.TblHumanRs.FirstOrDefaultAsync(m => m.HResourceId == id);


            //  Frs.ProductId = TblRecordProducts.ProductId;

            if (TblHumanR == null)
            {
                return NotFound();
            }
            return Page();
        }
        */
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            

            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.TblHumanRs.Add(TblHumanR);
            await _context.SaveChangesAsync();

            return RedirectToPage("./HDisplay");
        }
    }
}
