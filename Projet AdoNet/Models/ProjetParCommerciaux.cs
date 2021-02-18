using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Projet_AdoNet.Models
{
    public class ProjetParCommerciaux
    {
        /*Utiliser pour la liste des projets par commerciaux*/
        [Key]
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public int NombreProjet { get; set; }
    }
}
