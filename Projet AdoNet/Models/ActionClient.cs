using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Projet_AdoNet.Models
{
    public class ActionClient
    {
        public SqlConnection sqlconn = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ProjetADONet;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        public List<ProjetParClients> AllCustomer()
        {
            List<ProjetParClients> dt = new List<ProjetParClients>();

            using (var cmd = new SqlCommand("NbProjetClient", sqlconn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                sqlconn.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    ProjetParClients prj = new ProjetParClients();

                    prj.Id = reader.GetInt32(0);
                    prj.Nom = reader.GetString(1);
                    prj.Prenom = reader.GetString(2);
                    prj.NombreProjet = reader.GetInt32(3);

                    dt.Add(prj);
                }
                sqlconn.Close();
                return dt;
            }
        }

        public List<Projet> DetailProjectClient(int? idCli)
        {
            List<Projet> dt = new List<Projet>();

            using (var cmd = new SqlCommand("DetailProjetClient", sqlconn))
            {
                cmd.Parameters.Add(new SqlParameter("@idClient", idCli));
                cmd.CommandType = CommandType.StoredProcedure;
                sqlconn.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Projet prj = new Projet();

                    prj.Id = reader.GetInt32(0);
                    prj.Nom = reader.GetString(1);
                    prj.DateCreation = reader.GetDateTime(2);
                    prj.DateFinalisation = reader.GetDateTime(3);
                    prj.Ville = reader.GetString(4);
                    prj.IdStatut = reader.GetInt32(5);
                    prj.IdCommercial = reader.GetInt32(6);
                    prj.IdClient = reader.GetInt32(7);

                    dt.Add(prj);
                }
                sqlconn.Close();
                return dt;
            }
        }

        public List<ProjetParClients> TopTenCustomers()
        {
            List<ProjetParClients> dt = new List<ProjetParClients>();

            using (var cmd = new SqlCommand("TopTenClient", sqlconn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                sqlconn.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    ProjetParClients prj = new ProjetParClients();

                    prj.Id = reader.GetInt32(0);
                    prj.Nom = reader.GetString(1);
                    prj.Prenom = reader.GetString(2);
                    prj.NombreProjet = reader.GetInt32(3);

                    dt.Add(prj);
                }
                sqlconn.Close();
                return dt;
            }
        }
    }
}
