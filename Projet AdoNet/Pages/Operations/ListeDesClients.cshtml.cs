using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Projet_AdoNet.Models;

namespace Projet_AdoNet.Pages.Operations
{
    public class ListeDesClientsModel : PageModel
    {
        readonly ActionClient lt = new ActionClient();

        public List<ProjetParClients> ProjetPC { get; set; }

        private readonly ActionClient _ct;

        public ListeDesClientsModel(ActionClient ctrait)
        {
            _ct = ctrait;
        }

        public void OnGet()
        {
            ProjetPC = _ct.AllCustomer();
        }
    }
}
