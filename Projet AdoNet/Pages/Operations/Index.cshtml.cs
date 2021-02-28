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
        private readonly IMemoryCache _cache;
        public CommercialComparaison commerialComp { get; set; }


        public IndexModel(ActionCommercial ctrait, IMemoryCache cache)
        {
            _cache = cache;
            _ct = ctrait;
            /*pour la comparaison*/
        }
        

        public void OnGet()
        {
            ProjetPC = _ct.AllCommercial();
            commerialComp = new CommercialComparaison();
        }
        
        public IActionResult OnPost()
        {
            _cache.Set("id1", Request.Form["id11"]);
            _cache.Set("id2", Request.Form["id11"]);
            _cache.Set("id3", Request.Form["id11"]);
            _cache.Set("id4", Request.Form["id11"]);
            _cache.Set("id5", Request.Form["id11"]);
            
            return RedirectToPage("ComparaisonCommerciaux");
        }


        //public IActionResult OnPost()
        //{
        //    if (true)
        //    {
        //        HttpContext.Session.SetString("id1", Request.Form["id11"]);
        //        HttpContext.Session.SetString("id2", Request.Form["id22"]);
        //        HttpContext.Session.SetString("id3", Request.Form["id33"]);
        //        HttpContext.Session.SetString("id4", Request.Form["id44"]);
        //        HttpContext.Session.SetString("id5", Request.Form["id55"]);


        //        HttpContext.Session.SetString("test", "Je suis un test");

        //        return RedirectToPage("ComparaisonCommerciaux");
        //    }
            
        //}
    }
}
