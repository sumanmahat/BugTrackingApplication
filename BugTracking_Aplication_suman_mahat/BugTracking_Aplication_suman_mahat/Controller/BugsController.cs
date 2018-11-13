using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BugTracking_Aplication_suman_mahat.Model;
using System.Windows.Forms;
using System.Data;

namespace BugTracking_Aplication_suman_mahat.Controller
{
    class BugsController
    {
        private MySqlConnection conn= null;
        private MySqlCommand cmd;

        public BugsController()
        {
            if (conn == null)
            {
                conn = Connection.getConn();
            }
        }

        public Boolean AddBug(Bugs bugs)
        {
            Boolean add = false;
            string q1= "insert into tbl_bugs (bugId,projectname, classname, method, lineNo, author, year, month, day, sourcecode, status, addedby)" +
                "values ('"+bugs.BugId+"','" + bugs.Projectname + "', '" + bugs.Classname + "', '" + bugs.Method + "', '" + bugs.Lineno + "',"
                + "'" + bugs.Author + "', '" + bugs.Year + "', '" + bugs.Month + "', '" + bugs.Day + "', '" + bugs.Sourcecode + "','" + bugs.Status + "', '" + bugs.Addedby + "');";
            try
            {
                conn.Open();
                cmd = new MySqlCommand(q1, conn);
                int addbugs = cmd.ExecuteNonQuery();
                if(addbugs > 0)
                {
                    add = true;
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.."+ ex.Message);
            }
            return add;
        }

        public DataTable LoadBugs (string addedby)
        {
            DataTable dt = new DataTable();
            string q2 = "select * from tbl_bugs where addedby= '" + addedby + "'; ";
            try
            {
                conn.Open();
                cmd = new MySqlCommand(q2, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter
                {
                    SelectCommand = cmd
                };
                adapter.Fill(dt);
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error..." + ex.Message);
            }
            return dt;
        }

        public DataTable ShowAllBugs(string addedby)
        {
            DataTable dt = new DataTable();
            string q3 = "select * from tbl_bugs";
            try
            {
                conn.Open();
                cmd = new MySqlCommand(q3, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter
                {
                    SelectCommand = cmd
                };
                adapter.Fill(dt);
                conn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error.." + ex.Message);
            }
            return dt;  
        }

        public Boolean DeleteBugs(Bugs bugs)
        {
            Boolean delete = false;
            string q4 = "delete from tbl_bugs where bugId='" + bugs.BugId + "' and addedby='" + bugs.Addedby + "'; ";
            try
            {
                conn.Open();
                cmd = new MySqlCommand(q4, conn);
                int changedata = cmd.ExecuteNonQuery();
                if(changedata > 0)
                {
                    delete = true;
                }
                conn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("error.." + ex.Message);
            }
            return delete;
        }

        public Boolean UpdateBugs(Bugs bugs)
        {
            Boolean update = false;
            string q5 = "update tbl_bugs set projectname='" + bugs.Projectname + "', classname='" + bugs.Classname + "', method='" + bugs.Method + "',lineNo= '" + bugs.Lineno + "', sourcecode='" + bugs.Sourcecode + "', status= '" + bugs.Status + "', solveremail='" + bugs.Solver + "', solveyear='" + bugs.Solveyear + "', solvemonth= '" + bugs.Solvemonth + "', solveday= '" + bugs.Solveday + "', solvecode='" + bugs.Solvecode + "' where bugId= '" + bugs.BugId + "'; ";
            try
            {
                conn.Open();
                cmd = new MySqlCommand(q5, conn);
                int newupdate = cmd.ExecuteNonQuery();
                if(newupdate > 0)
                {
                    update = true;
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error..." + ex.Message);
            }
            return update;
        }
    }
}
