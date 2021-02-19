using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Projet_AdoNet.Data;
using Projet_AdoNet.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;


namespace Projet_AdoNet.Pages
{
    public class IndexModel : PageModel
    {

       
       // private readonly Projet_AdoNetContext databaseManager;
        private readonly Projet_AdoNet.Data.Projet_AdoNetContext _context;


        private readonly ILogger<IndexModel> _logger;


        public IndexModel(Projet_AdoNetContext databaseManagerContext)
        {
            try
            {
                // Settings.
                this._context = databaseManagerContext;
            }
            catch (Exception ex)
            {
                // Info
                Console.Write(ex);
            }
        }


        [BindProperty]
        public Manager LoginModel { get; set; }
        public IList<Manager> Manager { get; set; }

        // [Obsolete]
        public async Task<IActionResult> OnPostLogIn()
        {
            try
            {
                // Verification.
                if (ModelState.IsValid)
                {
                    // Initialization.
                    Manager = await _context.Manager.ToListAsync();
                    var queryLondonCustomers = from cust in Manager
                                               where cust.Login == this.LoginModel.Login && cust.Password== this.LoginModel.Password
                                               select cust;
                    //var loginInfo = queryLondonCustomers.ToList();
                   // var loginInfo = await _context.Manager.FirstOrDefaultAsync(m => m.Login == this.LoginModel.Login
                   //);
                    var loginInfo = await this._context.LoginByUsernamePasswordMethodAsync(this.LoginModel.Login, this.LoginModel.Password);

                   
                    // Verification.
                    if (loginInfo != null )//&& loginInfo.Count() > 0)
                    {
                        // Initialization.
                        var logindetails = loginInfo.First();

                        // Login In.
                        await this.SignInUser(logindetails.Login, false);

                        // Info.
                        return this.RedirectToPage("/BI");
                    }
                    else
                    {
                        // Setting.
                        ModelState.AddModelError(string.Empty, "Invalid username or password.");
                    }
                }
            }
            catch (Exception ex)
            {
                // Info
                Console.Write(ex);
            }

            // Info.
            return this.Page();
        }

        public IActionResult OnGet()
        {
            try
            {
                // Verification.
                if (this.User.Identity.IsAuthenticated)
                {
                    // Home Page.
                    return this.RedirectToPage("/BI");
                }
            }
            catch (Exception ex)
            {
                // Info
                Console.Write(ex);
            }

            // Info.
            return this.Page();
        }


        private async Task SignInUser(string username, bool isPersistent)
        {
            // Initialization.
            var claims = new List<Claim>();

            try
            {
                // Setting
                claims.Add(new Claim(ClaimTypes.Name, username));
                var claimIdenties = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                var claimPrincipal = new ClaimsPrincipal(claimIdenties);
                var authenticationManager = Request.HttpContext;

                // Sign In.
                await authenticationManager.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, claimPrincipal, new AuthenticationProperties() { IsPersistent = isPersistent });
            }
            catch (Exception ex)
            {
                // Info
                throw ex;
            }
        }
    }
}
