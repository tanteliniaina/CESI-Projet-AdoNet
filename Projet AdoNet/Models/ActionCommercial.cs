using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Projet_AdoNet.Models
{
    public class ActionCommercial
    {


        public SqlConnection sqlconn = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ProjetADONet;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        public List<ProjetParCommerciaux> AllCommercial()
        {
            List<ProjetParCommerciaux> dt = new List<ProjetParCommerciaux>();

            using (var cmd = new SqlCommand("NbProjetCommerciaux", sqlconn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                sqlconn.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    ProjetParCommerciaux prj = new ProjetParCommerciaux();

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

        public List<Projet> DetailProjectCommercial(int? idComm)
        {
            List<Projet> dt = new List<Projet>();

            using (var cmd = new SqlCommand("DetailProjetCommercial", sqlconn))
            {
                cmd.Parameters.Add(new SqlParameter("@idCommercial", idComm));
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
                    prj.IdStatut= reader.GetInt32(5);
                    prj.IdCommercial = reader.GetInt32(6);
                    prj.IdClient = reader.GetInt32(7);

                    dt.Add(prj);
                }
                sqlconn.Close();
                return dt;
            }
        }

        public List<ProjetParCommerciaux> TopTenCommercials()
        {
            List<ProjetParCommerciaux> dt = new List<ProjetParCommerciaux>();

            using (var cmd = new SqlCommand("TopTenCommercial", sqlconn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                sqlconn.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    ProjetParCommerciaux prj = new ProjetParCommerciaux();

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
        
        public List<ProjetParCommerciaux> Comparaison(int? id1, int? id2, int? id3, int? id4, int? id5)
        {
            List<ProjetParCommerciaux> dt = new List<ProjetParCommerciaux>();

            using (var cmd = new SqlCommand("ComparaisonEntreCinq", sqlconn))
            {
                cmd.Parameters.Add(new SqlParameter("@id1", id1));
                cmd.Parameters.Add(new SqlParameter("@id2", id2));
                cmd.Parameters.Add(new SqlParameter("@id3", id3));
                cmd.Parameters.Add(new SqlParameter("@id4", id4));
                cmd.Parameters.Add(new SqlParameter("@id5", id5));
                cmd.CommandType = CommandType.StoredProcedure;
                sqlconn.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    ProjetParCommerciaux prj = new ProjetParCommerciaux();

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
