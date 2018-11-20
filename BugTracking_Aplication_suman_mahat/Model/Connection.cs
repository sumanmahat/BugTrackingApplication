using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BugTracking_Aplication_suman_mahat
{
    class Connection
    {
        public static MySqlConnection con = null;
       // public string pkk;
               


        public static  MySqlConnection getConn()
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
                string sqlconnectionstring = "datasource=localhost;username=root;password=;database=bugtrackin_suman;SSLmode=none";
                con = new MySqlConnection(sqlconnectionstring);

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("error.."+ex.Message);
            }
            
        }
       
    }

}
