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
    public class IndexModel : PageModel
    {
        private readonly ERP_APP.Models.DB.ERPDBContext _context;

        public IndexModel(ERP_APP.Models.DB.ERPDBContext context)
        {
            _context = context;
        }

        public IList<TblAcc> TblAcc { get; set; }

        public async Task OnGetAsync()
        {
            TblAcc = await _context.TblAccs.ToListAsync();
        }
        [BindProperty]
        public string AccName { get; set; }
        [BindProperty]
        public string UserPass { get; set; }

        public string Msg { get; set; }
        private bool TblLoginExists(string AccName, string UserPass)
        {
            bool usern = false, pass = false;
            usern = _context.TblAccs.Any(e => e.AccName == AccName);
            pass = _context.TblAccs.Any(e => e.UserPass == UserPass);
            if (usern == true && pass == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /*     private bool AdminExists(int id, string password)
             {
                 bool admin = false, apass = false;
                 admin = _acontext.Admin.Any(e => e.Id == id);
                 apass = _acontext.Admin.Any(e => e.Password == password);
                 if (admin == true && apass == true)
                 {
                     return true;
                 }
                 else
                 {
                     return false;
                 }
             }*/
        public IActionResult OnPost()
        {
            if (TblLoginExists(AccName, UserPass))
            {

                //HttpContext.Session.SetString("username", Username);
                var cust = _context.TblAccs.Single(a => a.AccName == AccName);
                HttpContext.Session.SetString("AccName", cust.AccName);
                HttpContext.Session.SetString("UserRole", cust.UserRole);
                return RedirectToPage("Welcome");

            }


            /*else if (AdminExists(Convert.ToInt32(Username), Password))
            {
                // var cust = _acontext.Customers.Single(a => a.Username == Username);
                HttpContext.Session.SetString("username", Username);
                // securityManager.SignIn(HttpContext, cust);
                return RedirectToPage("WelcomeAdmin");
            }*/
            else
            {
                Msg = "Invalid";
                return Page();
            }
        }


    }
}

