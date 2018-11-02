using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTracking_Aplication_suman_mahat
{
    class Connection
    {
        public static SqlConnection con = null;
        public SqlCommand cmd;
        public SqlDataAdapter adpater;
        public string pkk;



        public static  SqlConnection getConn()
        {
            if (con == null)
            {
                DatabseConnection();
            }
            return con;
        }

        public static void DatabseConnection()
        {
            try
            {
                string sqlconnection = "Data Source=.;Initial Catalog=BugTracking_Suman;Integrated Security=True";
                con = new SqlConnection(sqlconnection);
               

               
            }
            catch (SqlException )
            {
                
            }
            
        }
       
    }

}
