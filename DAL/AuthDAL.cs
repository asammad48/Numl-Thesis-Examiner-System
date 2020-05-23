using PROPS;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class AuthDAL
    {
        string dbConn = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
        SqlConnection conn;
        SqlDataReader sdr;
       public AuthDAL()
        {
            conn = new SqlConnection(dbConn);
        }
        public DataTable login(AuthPROPS ap)
       {
           DataTable dt = new DataTable();
           conn.Open();
           SqlCommand cmd = new SqlCommand("LOGIN", conn);
           cmd.CommandType = CommandType.StoredProcedure;
           cmd.Parameters.Add(new SqlParameter("@Email", ap.Email));
           cmd.Parameters.Add(new SqlParameter("@Password", ap.Passowrd));
           sdr = cmd.ExecuteReader();
           if (sdr.HasRows)
               dt.Load(sdr);
           return dt;            
        }
    }
}
