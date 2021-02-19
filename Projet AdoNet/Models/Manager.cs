using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Projet_AdoNet.Models
{
    public class Manager
    {
        [Key, Column(Order = 1)]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [StringLength(50, MinimumLength = 3)]
        public string Nom { get; set; }

        [StringLength(50, MinimumLength = 3)]
        public string Prenom  { get; set; }

        public string Login { get; set; }

        ///  public string Pseudo { get; set; }

        [Required]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{8,15}$")]
        public string Password { get; set; }


        /*[NotMapped]
        [Required]
        [System.ComponentModel.DataAnnotations.Compare("Password")]*/
        public string ConfirmPassword { get; set; }

    }
}
