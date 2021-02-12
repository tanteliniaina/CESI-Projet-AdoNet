using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Projet_AdoNet.Pages.Home
{
    [Authorize]
    public class IndexModel : PageModel
    {
        public void OnGet()
        {
            try
            {
            }
            catch (Exception ex)
            {
                // Info
                Console.Write(ex);
            }
        }
        public async Task<IActionResult> OnPostLogOff()
        {
            try
            {
                // Setting.
                var authenticationManager = Request.HttpContext;

                // Sign Out.
                await authenticationManager.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            }
            catch (Exception ex)
            {
                // Info
                throw ex;
            }

            // Info.
            return this.RedirectToPage("/Index");
        }



    }
}
