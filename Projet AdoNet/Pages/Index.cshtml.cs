using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Projet_AdoNet.Data;
using Projet_AdoNet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projet_AdoNet.Pages
{
    public class IndexModel : PageModel
    {
       
        private readonly Projet_AdoNetContext databaseManager;

        public IndexModel(Projet_AdoNetContext databaseManagerContext)
        {
            try
            {
                // Settings.
                this.databaseManager = databaseManagerContext;
            }
            catch (Exception ex)
            {
                // Info
                Console.Write(ex);
            }
        }

        [BindProperty]
        public Manager LoginModel { get; set; }

        public IActionResult OnGet()
        {
            try
            {
                // Verification.
                if (this.User.Identity.IsAuthenticated)
                {
                    // Home Page.
                    return this.RedirectToPage("/Home/Index");
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

        public async Task<IActionResult> OnPostLogIn()
        {
            try
            {
                // Verification.
                if (ModelState.IsValid)
                {
                    // Initialization.
                    var loginInfo = await this.databaseManager.LoginByUsernamePasswordMethodAsync(this.LoginModel.Login, this.LoginModel.Password);

                    // Verification.
                    if (loginInfo != null && loginInfo.Count() > 0)
                    {
                        // Initialization.
                        var logindetails = loginInfo.First();

                        // Login In.
                        await this.SignInUser(logindetails.Login, false);

                        // Info.
                        return this.RedirectToPage("/Home/Index");
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

        private Task SignInUser(object username, bool v)
        {
            throw new NotImplementedException();
        }
    }
}
