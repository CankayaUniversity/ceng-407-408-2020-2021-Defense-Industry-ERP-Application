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
    public class PCreateModel : PageModel
    {
        private readonly ERP_APP.Models.DB.ERPDBContext _context;

        public PCreateModel(ERP_APP.Models.DB.ERPDBContext context)
        {
            _context = context;
        }
        [BindProperty]
        public TblWarehouse Productid { get; set; }
        public TblRecordProduct TblRecordProducts { get; set; }
        [BindProperty]
        public TblProduction TblProduction { get; set; }

        [BindProperty]
        public TblWarehouse TblWarehouses { get; set; }

        [BindProperty]
        public TblProduction P { get; set; }
        public String UserRole { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            UserRole = HttpContext.Session.GetString("UserRole");
            if (id == null)
            {
                return NotFound();
            }


            TblWarehouses = await _context.TblWarehouses.FirstOrDefaultAsync(m => m.ProductId == id);


            //  Frs.ProductId = TblRecordProducts.ProductId;

            if (TblWarehouses == null)
            {
                return NotFound();
            }
            return Page();
        }

        /* public IActionResult OnGet()
         {
         ViewData["ProductId"] = new SelectList(_context.TblRecordProducts, "ProductId", "ProductId");
         ViewData["WarehouseId"] = new SelectList(_context.TblWarehouses, "WarehouseId", "WarehouseId");
             return Page();
         }*/



        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {

            int id = Convert.ToInt32(Request.Form["proID"]);


            P.ProductId = id;

            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.TblProductions.Add(P);
            await _context.SaveChangesAsync();

            return RedirectToPage("./PDisplay");
        }
    }
}
