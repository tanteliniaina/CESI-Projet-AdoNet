using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Projet_AdoNet.Models;

namespace Projet_AdoNet.Pages.Operations
{
    public class FiltreProjetParDelaisModel : PageModel
    {
        private readonly ActionProjet _context;

        public FiltreProjetParDelaisModel(ActionProjet context)
        {
            _context = context;
        }

        readonly ActionProjet lt = new ActionProjet();

        public List<Projet> Projet { get; set; }


        public IActionResult OnGet(DateTime? creation, DateTime? finalisation)
        {
            if (creation == null)
            {
                return NotFound();
            }

            Projet = lt.ProjectPerDelay(creation, finalisation);

            if (Projet == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
