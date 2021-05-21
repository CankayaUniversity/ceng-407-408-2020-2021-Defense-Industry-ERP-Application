using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ERP_APP.Pages
{
    public class WelcomeModel : PageModel
    {
        public string UserRole { get; set; }
        public string AccName { get; set; }
        public string UserId;

        public void OnGet()
        {
            // UserId = User.FindFirst(ClaimTypes.Name).Value;
            UserRole = HttpContext.Session.GetString("UserRole");
            AccName = HttpContext.Session.GetString("AccName");
        }
        public IActionResult OnGetLogout()
        {
            HttpContext.Session.Remove("UserRole");
            HttpContext.Session.Remove("AccName");

            return RedirectToPage("Index");
        }
    }
}