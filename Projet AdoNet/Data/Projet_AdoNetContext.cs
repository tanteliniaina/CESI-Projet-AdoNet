using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Projet_AdoNet.Models;

namespace Projet_AdoNet.Data
{
    public class Projet_AdoNetContext : DbContext
    {
        public Projet_AdoNetContext (DbContextOptions<Projet_AdoNetContext> options)
            : base(options)
        {
        }
        public DbSet<Projet_AdoNet.Models.Client> Client { get; set; }
        public DbSet<Projet_AdoNet.Models.Commercial> Commercial { get; set; }
        public DbSet<Projet_AdoNet.Models.Manager> Manager { get; set; }
        public DbSet<Projet_AdoNet.Models.StatutProjet> StatutProjet { get; set; }
        public DbSet<Projet_AdoNet.Models.Projet> Projet { get; set; }
    }
}
