using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Caching.Memory;
using Projet_AdoNet.Models;

namespace Projet_AdoNet.Pages.Operations
{
    public class IndexModel : PageModel
    {
        /*
        public CommercialTraitement _ct;
        public DataTable dt_ct = new DataTable();
        */
        readonly ActionCommercial lt = new ActionCommercial();


        public List<ProjetParCommerciaux> ProjetPC { get; set; }

        private readonly ActionCommercial _ct;


        public IndexModel(ActionCommercial ctrait, IMemoryCache cache)
        {
            _ct = ctrait;
            /*pour la comparaison*/
        }
        

        public void OnGet()
        {
            ProjetPC = _ct.AllCommercial();
        }
        
        public IActionResult OnPost()
        {
            return RedirectToPage("ComparaisonCommerciaux");
        }
    }
}
