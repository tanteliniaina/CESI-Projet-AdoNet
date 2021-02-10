using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Projet_AdoNet.Models
{
    public class Manager
    {
        [Key]
        public int idManager { get; set; }
        public string nomManager { get; set; }
        public string prenomManager { get; set; }
        public string userManager { get; set; }
    }
}
