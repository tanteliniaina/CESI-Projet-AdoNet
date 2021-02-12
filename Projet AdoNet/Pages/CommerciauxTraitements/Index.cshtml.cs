using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Projet_AdoNet.Models;

namespace Projet_AdoNet.Pages.CommerciauxTraitements
{
    public class IndexModel : PageModel
    {
        public CommercialTraitement _ct;
        public DataTable dt_ct = new DataTable();

        public IndexModel(CommercialTraitement ctrait)
        {
            _ct = ctrait;
        }

        public void OnGet()
        {
            dt_ct = _ct.Load_Groups();
        }
    }
}
