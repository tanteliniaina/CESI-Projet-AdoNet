using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
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

        public IndexModel(ActionCommercial ctrait)
        {
            _ct = ctrait;
        }

        public void OnGet()
        {
            ProjetPC = _ct.CountProjectPerCommercial();
        }
    }
}
