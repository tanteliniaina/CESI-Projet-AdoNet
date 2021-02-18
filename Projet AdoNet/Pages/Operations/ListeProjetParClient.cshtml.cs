using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Projet_AdoNet.Models;

namespace Projet_AdoNet.Pages.Operations
{
    public class ListeProjetParClientModel : PageModel
    {
        private readonly ActionClient _context;

        public ListeProjetParClientModel(ActionClient context)
        {
            _context = context;
        }

        readonly ActionClient lt = new ActionClient();

        public List<Projet> Projet { get; set; }


        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Projet = lt.DetailProjectClient(id);

            if (Projet == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
