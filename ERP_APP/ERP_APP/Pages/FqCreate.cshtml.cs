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
    public class FqCreateModel : PageModel
    {
        private readonly ERP_APP.Models.DB.ERPDBContext _context;
        public String UserRole { get; set; }
  
        public FqCreateModel(ERP_APP.Models.DB.ERPDBContext context)
        {
            _context = context;
        }
        [BindProperty]
        public TblRecordProduct Productid { get; set; }

        [BindProperty]
        public TblFirstQuality Frs { get; set; }
        [BindProperty]
        public TblFirstQuality Fq { get; set; }
        public TblRecordProduct TblRecordProducts { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            UserRole = HttpContext.Session.GetString("UserRole");
            if (id == null)
            {
                return NotFound();
            }

            
            TblRecordProducts = await _context.TblRecordProducts.FirstOrDefaultAsync(m => m.ProductId == id);


            //  Frs.ProductId = TblRecordProducts.ProductId;

            if (TblRecordProducts == null)
            {
                return NotFound();
            }
            return Page();
        }

        /*public IActionResult OnGet()
        {
           
            ViewData["ProductId"] = new SelectList(_context.TblRecordProducts, "ProductId", "ProductId");
            return Page();
        }
        */
      

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
           int id = Convert.ToInt32(Request.Form["productID"]);

           
           Fq.ProductId = id;

            if (!ModelState.IsValid)
            {
                return Page();
            }

            
            // TblFirstQuality.ProductId = TblRecordProducts.ProductId;


            _context.TblFirstQualities.Add(Fq);
            await _context.SaveChangesAsync();
            

            return RedirectToPage("./FqDisplay");
        }
    }
}
