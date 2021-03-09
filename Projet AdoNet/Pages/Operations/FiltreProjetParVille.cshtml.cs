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
        /*d�but d'initialisation*/
        readonly ActionProjet lt = new ActionProjet();

        public List<ProjetParVille> ProjetPC { get; set; }

        private readonly ActionProjet _ct;

        /*fin d'initialisation*/

        public FiltreProjetParVilleModel(ActionProjet ctrait)
        {
            _ct = ctrait;
        }

        /*appelle � la m�thode FilterByCity dans ActionProjet.cs*/
        public void OnGet()
        {
            /*affectation des r�susltats des requ�tes dans la variable ProjetPC*/
            ProjetPC = _ct.FilterByCity();
        }
    }
}
