using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Projet_AdoNet.Models
{
    public class Commercial
    {
        [Key]
        public int idCommercial { get; set; }
        public string nomCommercial { get; set; }
        public string prenomCommercial { get; set; }
    }
}
