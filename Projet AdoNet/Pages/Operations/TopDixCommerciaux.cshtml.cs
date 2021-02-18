using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Projet_AdoNet.Models;

namespace Projet_AdoNet.Pages.Operations
{
    public class TopDixCommerciauxModel : PageModel
    {
        private readonly ActionCommercial _context;

        public TopDixCommerciauxModel(ActionCommercial context)
        {
            _context = context;
        }

        readonly ActionCommercial lt = new ActionCommercial();

        public List<ProjetParCommerciaux> ClientP { get; set; }

        public void OnGet()
        {
            ClientP = lt.TopTenCommercials();
        }

    }
}
