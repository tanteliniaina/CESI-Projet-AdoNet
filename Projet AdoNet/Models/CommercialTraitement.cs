using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Projet_AdoNet.Models
{
    public class CommercialTraitement
    {
        public SqlConnection sqlconn = new SqlConnection();

        public CommercialTraitement(Connexion conn)
        {
            sqlconn = conn.sqlcon;
        }

        public DataTable Load_Groups()
        {
            DataTable dt = new DataTable();

            SqlCommand cmd = new SqlCommand("Select * from Commercial", sqlconn);
            sqlconn.Open();
            dt.Load(cmd.ExecuteReader());
            sqlconn.Close();

            return dt;
        }

    }
}
