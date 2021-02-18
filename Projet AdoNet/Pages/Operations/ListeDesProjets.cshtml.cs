using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Projet_AdoNet.Models;

namespace Projet_AdoNet.Pages.Operations
{
    public class ListeDesProjetsModel : PageModel
    {
        readonly ActionProjet lt = new ActionProjet();

        public List<Projet> ProjetPC { get; set; }

        private readonly ActionProjet _ct;

        public ListeDesProjetsModel(ActionProjet ctrait)
        {
            _ct = ctrait;
        }

        public void OnGet()
        {
            ProjetPC = _ct.AllProject();
        }
    }
}
