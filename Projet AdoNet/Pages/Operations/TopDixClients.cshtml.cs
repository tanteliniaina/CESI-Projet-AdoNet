using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Projet_AdoNet.Models;

namespace Projet_AdoNet.Pages.Operations
{
    public class TopDixClientsModel : PageModel
    {
        private readonly ActionClient _context;

        public TopDixClientsModel(ActionClient context)
        {
            _context = context;
        }

        readonly ActionClient lt = new ActionClient();

        public List<ProjetParClients> ClientP { get; set; }

        public void OnGet()
        {
            ClientP = lt.TopTenCustomers();
        }

    }
}
