using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Projet_AdoNet.Models;

namespace Projet_AdoNet.Pages.Operations
{
    public class FiltreProjetParVilleModel : PageModel
    {
        /*début d'initialisation*/
        readonly ActionProjet lt = new ActionProjet();

        public List<ProjetParVille> ProjetPC { get; set; }

        private readonly ActionProjet _ct;

        /*fin d'initialisation*/

        public FiltreProjetParVilleModel(ActionProjet ctrait)
        {
            _ct = ctrait;
        }

        /*appelle à la méthode FilterByCity dans ActionProjet.cs*/
        public void OnGet()
        {
            /*affectation des résusltats des requêtes dans la variable ProjetPC*/
            ProjetPC = _ct.FilterByCity();
        }
    }
}
