﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Projet_AdoNet.Data;
using Projet_AdoNet.Models;

namespace Projet_AdoNet.Pages.Clients
{
    public class DeleteModel : PageModel
    {
        private readonly Projet_AdoNet.Data.Projet_AdoNetContext _context;

        public DeleteModel(Projet_AdoNet.Data.Projet_AdoNetContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Client Client { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Client = await _context.Client.FirstOrDefaultAsync(m => m.Id == id);

            if (Client == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Client = await _context.Client.FindAsync(id);

            if (Client != null)
            {
                _context.Client.Remove(Client);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
