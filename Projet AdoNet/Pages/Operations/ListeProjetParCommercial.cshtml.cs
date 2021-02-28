using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Projet_AdoNet.Models;

namespace Projet_AdoNet.Pages.Operations
{
    public class ListeProjetParCommercialModel : PageModel
    {
        private readonly ActionCommercial _context;

        public ListeProjetParCommercialModel(ActionCommercial context)
        {
            _context = context;
        }

        readonly ActionCommercial lt = new ActionCommercial();

        public List<Projet> Projet { get; set; }


        public IActionResult OnGet(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Projet = lt.DetailProjectCommercial(id);

            if (Projet == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
