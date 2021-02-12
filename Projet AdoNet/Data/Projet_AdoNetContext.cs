using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
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

        public DbSet<Projet_AdoNet.Models.Projet> Projet { get; set; }

        public DbSet<Projet_AdoNet.Models.Manager> Manager { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            ////modelBuilder.Entity<Login>(entity =>
            ////{
            ////    entity.Property(e => e.Id).HasColumnName("id");

            ////    entity.Property(e => e.Password)
            ////        .IsRequired()
            ////        .HasColumnName("password")
            ////        .HasMaxLength(50)
            ////        .IsUnicode(false);

            ////    entity.Property(e => e.Username)
            ////        .IsRequired()
            ////        .HasColumnName("username")
            ////        .HasMaxLength(50)
            ////        .IsUnicode(false);
            ////});

            // [Asma Khalid]: Query for store procedure.
            modelBuilder.Query<LoginByPseudoPassword>();
        }

        [Obsolete]
        public async Task<List<LoginByPseudoPassword>> LoginByUsernamePasswordMethodAsync(string usernameVal, string passwordVal)
        {
            // Initialization.
            List<LoginByPseudoPassword> lst = new List<LoginByPseudoPassword>();

            try
            {
                // Settings.
                SqlParameter usernameParam = new SqlParameter("@userManager", usernameVal ?? (object)DBNull.Value);
                SqlParameter passwordParam = new SqlParameter("@password", passwordVal ?? (object)DBNull.Value);

                // Processing.
                string sqlQuery = "EXEC	[dbo].[LoginByUsernamePassword] " +
                                    "@username, @password";

                lst = await this.Query<LoginByPseudoPassword>().FromSql(sqlQuery, usernameParam, passwordParam).ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            // Info.
            return lst;
        }

    }
}
