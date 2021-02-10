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
        public int idProjet { get; set; }
        public string nomProjet { get; set; }
        public DateTime dateCreation { get; set; }
        public DateTime dateFinalisation { get; set; }
        public string villeProjet { get; set; }
        public int idStatutProjet { get; set; }
        public int idCommercial { get; set; }
        public int idClient { get; set; }

    }
}
