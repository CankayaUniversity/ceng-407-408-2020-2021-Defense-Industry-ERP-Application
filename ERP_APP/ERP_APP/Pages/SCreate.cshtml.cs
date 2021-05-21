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
    public class SCreateModel : PageModel
    {
        private readonly ERP_APP.Models.DB.ERPDBContext _context;
        [BindProperty]
        public TblProduction TblProductions { get; set; }
        public TblRecordProduct TblRecordProducts { get; set; }

        [BindProperty]
        public TblShipment TblShipment { get; set; }
        public String UserRole { get; set; }

        [BindProperty]
        public TblShipment S { get; set; }
        public SCreateModel(ERP_APP.Models.DB.ERPDBContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> OnGetAsync(int? id)
        {
            UserRole = HttpContext.Session.GetString("UserRole");
            if (id == null)
            {
                return NotFound();
            }


            TblProductions = await _context.TblProductions.FirstOrDefaultAsync(m => m.ProductId == id);


            //  Frs.ProductId = TblRecordProducts.ProductId;

            if (TblProductions == null)
            {
                return NotFound();
            }
            return Page();
        }
       /* public IActionResult OnGet()
        {
        ViewData["ProductId"] = new SelectList(_context.TblRecordProducts, "ProductId", "ProductId");
            return Page();
        }
       */
      
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            int id = Convert.ToInt32(Request.Form["pID2"]);
            S.ProductId = id;

            
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.TblShipments.Add(S);
            await _context.SaveChangesAsync();

            return RedirectToPage("./SDisplay");
        }
    }
}
