﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Projet_AdoNet.Data;
using Projet_AdoNet.Models;

namespace Projet_AdoNet.Pages.Statuts
{
    public class IndexModel : PageModel
    {
        private readonly Projet_AdoNet.Data.Projet_AdoNetContext _context;

        public IndexModel(Projet_AdoNet.Data.Projet_AdoNetContext context)
        {
            _context = context;
        }

        public IList<StatutProjet> StatutProjet { get;set; }

        public async Task OnGetAsync()
        {
            StatutProjet = await _context.StatutProjet.ToListAsync();
        }
    }
}
