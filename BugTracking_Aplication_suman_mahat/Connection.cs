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
        public SqlConnection con;
        public SqlCommand cmd;
        public SqlDataAdapter adpater;
        public string pkk;



        public void connection()
        {
            con = new SqlConnection(@"Data Source=.;Initial Catalog=BugTracking_Suman;Integrated Security=True");
            con.Open();
        }

        public void dataSend(string SQL)
        {
            try
            {
                connection();
                cmd = new SqlCommand(SQL,con);
                cmd.ExecuteNonQuery();
                pkk = "";
            }
            catch (Exception)
            {
                pkk = "Please check your data";
            }
            con.Close();
        }
        public void dataGet(String SQL)
        {

            try
            {
                connection();
                adpater = new SqlDataAdapter(SQL, con);
                
            }
            catch (Exception)
            {
                pkk = "Please check your data";
            }
        }
    }

}
