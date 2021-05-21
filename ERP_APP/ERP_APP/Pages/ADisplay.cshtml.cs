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
    public class ADisplayModel : PageModel
    {
        private readonly ERP_APP.Models.DB.ERPDBContext _context;

        public ADisplayModel(ERP_APP.Models.DB.ERPDBContext context)
        {
            _context = context;
        }

        public IList<TblAcc> TblAcc { get; set; }
        public IList<TblAccounting> TblAccounting { get;set; }
        public String UserRole { get; set; }

       // public TblAccounting TblAccounting { get; set; }

        public int Salary { get; set; }
        public TblAccounting A { get; set; }
        public TblAccounting TblAccountings { get; set; }
        public int sigortalar { get; set; }
        public int digergider { get; set; }
        // public int[] x = {3, 5};

        public int toplam;
        // public decimal ComputeTotalValue()
        // {
        // return itemCollection.Sum(e => (e.Item.Price + e.Item.Modifiers.Sum(m => m.Price)) * e.Quantity);
        //  }
        public async Task OnGetAsync()
        {

            //   var y = x.Sum(i => i + 1);
            //   toplam = TblAccounting.Count
            toplam = TblAccountings.Salary + TblAccountings.sigortalar);
                
            TblAccounting = await _context.TblAccountings
                .Include(t => t.HResource).ToListAsync();
            TblAcc = await _context.TblAccs.ToListAsync();
            UserRole = HttpContext.Session.GetString("UserRole");
        }
    }
}
