using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Projet_AdoNet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Projet_AdoNet.Data;
using Microsoft.AspNetCore.Http;

namespace Projet_AdoNet.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public Manager manager { get; set; }

        public string Msg;


        private Projet_AdoNetContext _logger;


        public IndexModel(Projet_AdoNetContext logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            manager = new Manager();
        }

        public IActionResult OnPost()
        {
            var acc = login(manager.Login, manager.Password);
            if (acc == null)
            {
                Msg = "Diso  oo";
                return Page();
            }
            else
            {
                HttpContext.Session.SetString("login", acc.Nom);
                return RedirectToPage("Accueil");
            }
        }

        private Manager login(string login, string password)
        {
            var manager = _logger.Manager.SingleOrDefault(a => a.Login.Equals(login));
            if(manager != null)
            {
                if (password == manager.Password)
                {
                    return manager;
                }
                
            }
            return null;
        }
    }
}
