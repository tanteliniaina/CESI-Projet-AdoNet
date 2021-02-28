using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Projet_AdoNet.Models;

namespace Projet_AdoNet.Pages.Operations
{
    public class ComparaisonCommerciauxModel : PageModel
    {

        private readonly ActionCommercial _context;

        public ComparaisonCommerciauxModel(ActionCommercial context)
        {
            _context = context;
        }

        readonly ActionCommercial lt = new ActionCommercial();

        public List<ProjetParCommerciaux> Projetcc { get; set; }


        public IActionResult OnGet(int? id1, int? id2, int? id3, int? id4, int? id5)
        {

            Projetcc = lt.Comparaison(id1, id2, id3, id4, id5);
            
            if (Projetcc == null)
            {
                return NotFound();
            }
            return Page();
            
        }
        
    }
}
