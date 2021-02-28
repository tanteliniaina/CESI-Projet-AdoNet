using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Projet_AdoNet.Models
{
    public class CommercialComparaison
    {
        [Key]
        public int Id1 { get; set; }
        public string Nom1 { get; set; }
        public string Prenom1 { get; set; }
        public int NombreProjet1 { get; set; }

        [Key]
        public int Id2 { get; set; }
        public string Nom2 { get; set; }
        public string Prenom2 { get; set; }
        public int NombreProjet2 { get; set; }

        [Key]
        public int Id3 { get; set; }
        public string Nom3 { get; set; }
        public string Prenom3 { get; set; }
        public int NombreProjet3 { get; set; }

        [Key]
        public int Id4 { get; set; }
        public string Nom4 { get; set; }
        public string Prenom4 { get; set; }
        public int NombreProjet4 { get; set; }

        [Key]
        public int Id5 { get; set; }
        public string Nom5 { get; set; }
        public string Prenom5 { get; set; }
        public int NombreProjet5 { get; set; }

    }
}
