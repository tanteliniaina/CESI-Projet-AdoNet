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
        public SqlConnection sqlconn = new SqlConnection("Data Source=ACER-JEFF;Initial Catalog=ProjetADONet;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");


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
