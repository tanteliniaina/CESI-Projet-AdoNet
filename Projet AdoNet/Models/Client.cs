using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Projet_AdoNet.Models
{
    public class Client
    {
        [Key]
        public int idClient { get; set; }
        public string nomClient { get; set; }
        public string prenomClient { get; set; }
    }
}
