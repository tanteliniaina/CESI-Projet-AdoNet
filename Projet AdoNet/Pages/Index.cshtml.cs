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

        /*Action déclachée à l'initialisation de la page*/
        public void OnGet()
        {
            /*Restauration de la session à vide*/
            HttpContext.Session.Remove("login");
            
            manager = new Manager();
        }

        /*Action déclanchée lors de la méthode post*/
        public IActionResult OnPost()
        {
            var acc = login(manager.Login, manager.Password);
            if (acc == null)
            {
                Msg = "Erreur de Login ou de Mot de passe";
                return Page();
            }
            else
            {
                /*Remplissage de la session*/
                HttpContext.Session.SetString("login", acc.Prenom +" "+acc.Nom);
                /*Redirection vers la page d'accueil*/
                return RedirectToPage("Accueil");
                
            }
        }

        /*Méthode pour la test de login et de mot de passe dans la base de données*/
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
