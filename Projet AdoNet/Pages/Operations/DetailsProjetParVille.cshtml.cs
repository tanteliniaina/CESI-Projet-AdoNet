using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Projet_AdoNet.Models;

namespace Projet_AdoNet.Pages.Operations
{
    public class DetailsProjetParVilleModel : PageModel
    {
        private readonly ActionProjet _context;

        public DetailsProjetParVilleModel(ActionProjet context)
        {
            _context = context;
        }

        readonly ActionProjet lt = new ActionProjet();

        public List<Projet> Projet { get; set; }


        public IActionResult OnGet(string ville)
        {
            if (ville == "")
            {
                return NotFound();
            }

            Projet = lt.ProjectPerCity(ville);

            if (Projet == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
