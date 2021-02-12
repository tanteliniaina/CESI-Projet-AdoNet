using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projet_AdoNet.Models
{
    public class LoginByPseudoPassword
    {
        public int Id { get; set; }
        public string Pseudo { get; set; }
        public string Password { get; set; }
    }
}
