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
    public class HDisplayModel : PageModel
    {
        private readonly ERP_APP.Models.DB.ERPDBContext _context;

        public HDisplayModel(ERP_APP.Models.DB.ERPDBContext context)
        {
            _context = context;
        }

        public IList<TblHumanR> TblHumanR { get;set; }
        public String UserRole { get; set; }

        public async Task OnGetAsync()
        {
            TblHumanR = await _context.TblHumanRs.ToListAsync();
            UserRole = HttpContext.Session.GetString("UserRole");
        }
    }
}
