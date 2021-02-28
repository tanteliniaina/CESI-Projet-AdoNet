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


        public IActionResult OnGet(int id1, int id2, int id3, int id4, int id5)
        {
            //var tempId1 = HttpContext.Session.GetInt32("id1");
            // var tempId2 = HttpContext.Session.GetInt32("id2");
            // var tempId3 = HttpContext.Session.GetInt32("id3");
            // var tempId4 = HttpContext.Session.GetInt32("id4");
            // var tempId5 = HttpContext.Session.GetInt32("id5");

            // id1 = (int)tempId1;
            // id2 = (int)tempId2;
            // id3 = (int)tempId3;
            // id4 = (int)tempId4;
            // id5 = (int)tempId5;

            id1 = 1;
            id2 = 2;
            id3 = 1;
            id4 = 4;
            id5 = 2;
           /*  
            if (id1 != 0)
            {
                return NotFound();
            }
           */
            Projetcc = lt.Comparaison(id1, id2, id3, id4, id5);
            /*
            if (Projetcc == null)
            {
                return NotFound();
            }*/
            return Page();
            
        }
        
    }
}
