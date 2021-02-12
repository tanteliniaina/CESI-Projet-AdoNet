using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projet_AdoNet.Models
{
    public class Connexion
    {
        public SqlConnection sqlcon = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ProjetADONet;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
    }
}
