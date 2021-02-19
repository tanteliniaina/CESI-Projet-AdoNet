using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Projet_AdoNet.Models
{
    public class Projet
    {
        [Key]
        public int Id { get; set; }
        public string Nom { get; set; }
        public DateTime DateCreation { get; set; }
        public DateTime DateFinalisation { get; set; }
        public string Ville { get; set; }
        public int IdStatut { get; set; }
        public int IdCommercial { get; set; }
        public int IdClient { get; set; }

    }
}
