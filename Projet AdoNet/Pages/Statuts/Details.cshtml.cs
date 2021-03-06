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
    public class DetailsModel : PageModel
    {
        private readonly Projet_AdoNet.Data.Projet_AdoNetContext _context;

        public DetailsModel(Projet_AdoNet.Data.Projet_AdoNetContext context)
        {
            _context = context;
        }

        public StatutProjet StatutProjet { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            StatutProjet = await _context.StatutProjet.FirstOrDefaultAsync(m => m.Id == id);

            if (StatutProjet == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
