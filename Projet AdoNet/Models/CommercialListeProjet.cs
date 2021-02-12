using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Projet_AdoNet.Models
{
    public class CommercialListeProjet
    {


        public SqlConnection sqlconn = new SqlConnection("Data Source=ACER-JEFF;Initial Catalog=ProjetADONet;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");


        public List<Projet> GetProject(int? idComm)
        {
            List<Projet> dt = new List<Projet>();

            using (var cmd = new SqlCommand("CountProjet", sqlconn))
            {
                cmd.Parameters.Add(new SqlParameter("@idCommercial", idComm));
                cmd.CommandType = CommandType.StoredProcedure;
                sqlconn.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                Projet prj = new Projet();

                    prj.idProjet = reader.GetInt32(0);
                    prj.nomProjet = reader.GetString(1);
                    prj.dateCreation = reader.GetDateTime(2);
                    prj.dateFinalisation = reader.GetDateTime(3);
                    prj.villeProjet = reader.GetString(4);
                    prj.idStatutProjet = reader.GetInt32(5);
                    prj.idCommercial = reader.GetInt32(6);
                    prj.idClient = reader.GetInt32(7);

                    dt.Add(prj);
                }
                return dt;
            }
        }
    }
}
