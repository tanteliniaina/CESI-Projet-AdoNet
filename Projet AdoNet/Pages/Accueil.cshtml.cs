using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Projet_AdoNet.Pages
{
    public class AccueilModel : PageModel
    {
        private readonly IHttpContextAccessor httpContextAccessor;
        private readonly ILogger<AccueilModel> _logger;
        public string message { get; set; }

        public AccueilModel(ILogger<AccueilModel> logger, IHttpContextAccessor httpContextAccessor)
        {
            _logger = logger;
            this.httpContextAccessor = httpContextAccessor;
        }

        public void OnGet()
        {
            if (HttpContext.Session.GetString("login") == null)
            {
                message = " bonjour";
                this.RedirectToPage("Index");
            }
        }
    }
    
}
