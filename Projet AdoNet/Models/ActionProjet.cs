using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Projet_AdoNet.Models
{
    public class ActionProjet
    {
        public SqlConnection sqlconn = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ProjetADONet;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        public List<Projet> AllProject()
        {
            List<Projet> dt = new List<Projet>();

            using (var cmd = new SqlCommand("ListeProjet", sqlconn))
            {
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

        public List<ProjetParVille> FilterByCity()
        {
            List<ProjetParVille> dt = new List<ProjetParVille>();

            using (var cmd = new SqlCommand("ProjetGroupByVille", sqlconn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                sqlconn.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    ProjetParVille prj = new ProjetParVille();

                    prj.NombreProjet = reader.GetInt32(0);
                    prj.Ville = reader.GetString(1);

                    dt.Add(prj);
                }
                sqlconn.Close();
                return dt;
            }
        }


        public List<Projet> ProjectPerCity(string ville)
        {
            List<Projet> dt = new List<Projet>();

            using (var cmd = new SqlCommand("ListeProjetParVille", sqlconn))
            {
                cmd.Parameters.Add(new SqlParameter("@ville", ville));
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

        public List<Projet> ProjectPerDelay(DateTime? creation, DateTime? finalisation)
        {
            List<Projet> dt = new List<Projet>();

            using (var cmd = new SqlCommand("ListeProjetParDélais", sqlconn))
            {
                cmd.Parameters.Add(new SqlParameter("@Creation", creation));
                cmd.Parameters.Add(new SqlParameter("@Finalisation", finalisation));
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

    }
}
