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
    public class WCreateModel : PageModel
    {
        private readonly ERP_APP.Models.DB.ERPDBContext _context;

        
        public WCreateModel(ERP_APP.Models.DB.ERPDBContext context)
        {
            _context = context;
        }

        [BindProperty]
        public TblRecordProduct Productid { get; set; }

        [BindProperty]
        public TblWarehouse Wh { get; set; }
        public TblRecordProduct TblRecordProducts { get; set; }

        public TblWarehouse TblWarehouse { get; set; }
        public String UserRole { get; set; }


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
       /* public async Task<IActionResult> OnGetAsync(int? id)
        {

           // ViewData["ProductId"] = new SelectList(_context.TblRecordProducts, "ProductId", "ProductId");
            TblRecordProducts = await _context.TblRecordProducts.FirstOrDefaultAsync(m => m.ProductId == id);
            return Page();
        }
       */
      

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {

            int id = Convert.ToInt32(Request.Form["pID"]);


            Wh.ProductId = id;


            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.TblWarehouses.Add(Wh);
            await _context.SaveChangesAsync();

            return RedirectToPage("./WDisplay");
        }

    }

}
