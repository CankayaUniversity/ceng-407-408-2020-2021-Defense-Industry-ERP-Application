﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ERP_APP.Models.DB;
using Microsoft.AspNetCore.Http;

namespace ERP_APP.Pages
{
    public class WEditModel : PageModel
    {
        private readonly ERP_APP.Models.DB.ERPDBContext _context;

        public WEditModel(ERP_APP.Models.DB.ERPDBContext context)
        {
            _context = context;
        }

        [BindProperty]
        public TblWarehouse TblWarehouse { get; set; }
        public String UserRole { get; set; }
       

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            UserRole = HttpContext.Session.GetString("UserRole");
            if (id == null)
            {
                return NotFound();
            }
          
         TblWarehouse = await _context.TblWarehouses
              .Include(t => t.Product).FirstOrDefaultAsync(m => m.WarehouseId == id);

            if (TblWarehouse == null)
            {
                return NotFound();
            }
          // ViewData["ProductId"] = new SelectList(_context.TblRecordProducts, "ProductId", "ProductId");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {

            UserRole = HttpContext.Session.GetString("UserRole");

            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(TblWarehouse).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TblWarehouseExists(TblWarehouse.WarehouseId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./WDisplay");
        }

        private bool TblWarehouseExists(int id)
        {
            return _context.TblWarehouses.Any(e => e.WarehouseId == id);
        }
    }
}
