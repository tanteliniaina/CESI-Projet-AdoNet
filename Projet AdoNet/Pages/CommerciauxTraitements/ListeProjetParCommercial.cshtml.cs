using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Projet_AdoNet.Models;

namespace Projet_AdoNet.Pages.CommerciauxTraitements
{
    public class ListeProjetParCommercialModel : PageModel
    {
        private readonly CommercialListeProjet _context;

        public ListeProjetParCommercialModel(CommercialListeProjet context)
        {
            _context = context;
        }

        readonly CommercialListeProjet lt = new CommercialListeProjet();

        public List<Projet> Projet { get; set; }


        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Projet = lt.GetProject(id);

            if (Projet == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
