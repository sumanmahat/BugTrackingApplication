using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BugTracking_Aplication_suman_mahat.Model;
using System.Windows.Forms;
using System.Data;
using System.IO;

namespace BugTracking_Aplication_suman_mahat.Controller
{
    class BugsController
    {
        private MySqlConnection conn= null;
        private MySqlCommand cmd;
        FileStream fileStream;
        BinaryReader bReader;

        public BugsController()
        {
            //databse connection
            if (conn == null)
            {
                conn = Connection.getConn();
            }
        }

        /// <summary>
        /// insert bug details in database
        /// </summary>
        /// <param name="bugs"></param>
        /// <returns></returns>
        public Boolean AddBug(Bugs bugs)
        {
            Boolean add = false;
            //to open image
            byte[] Image;
            fileStream = new FileStream(bugs.Imgfile,FileMode.Open,FileAccess.Read);
            bReader = new BinaryReader(fileStream);
            Image = bReader.ReadBytes((int)fileStream.Length);
            bReader.Close();
            fileStream.Close();

            string q1= "insert into tbl_bugs (bugId,projectname, classname, method, lineNo, endline, errorsnap,author, year, month, day, sourcecode, status, addedby)" +
                "values ('"+bugs.BugId+"','" + bugs.Projectname + "', '" + bugs.Classname + "', '" + bugs.Method + "', '" + bugs.Lineno + "','" + bugs.Endline + "',@errorsnap,'" + bugs.Author + "', '" + bugs.Year + "', '" + bugs.Month + "', '" + bugs.Day + "', '" + bugs.Sourcecode + "','" + bugs.Status + "', '" + bugs.Addedby + "');";
            try
            {
                conn.Open();
                cmd = new MySqlCommand(q1, conn);
                cmd.Parameters.AddWithValue("errorsnap", Image);
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

        /// <summary>
        /// add bugs into database 
        /// </summary>
        /// <param name="addedby"></param>
        /// <returns></returns>
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


        /// <summary>
        /// gettinf all the bugs from database into DataTable
        /// </summary>
        /// <param name="addedby"></param>
        /// <returns></returns>
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

        /// <summary>
        /// delete bugs from database
        /// </summary>
        /// <param name="bugs"></param>
        /// <returns></returns>
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

        /// <summary>
        /// update bugs
        /// </summary>
        /// <param name="bugs"></param>
        /// <returns></returns>
        public Boolean UpdateBugs(Bugs bugs)
        {
            Boolean update = false;
            string q5 = "update tbl_bugs set projectname='" + bugs.Projectname + "', classname='" + bugs.Classname + "', method='" + bugs.Method + "',lineNo= '" + bugs.Lineno + "',endline= '" + bugs.Endline + "', sourcecode='" + bugs.Sourcecode + "', status= '" + bugs.Status + "', solveremail='" + bugs.Solver + "', solveyear='" + bugs.Solveyear + "', solvemonth= '" + bugs.Solvemonth + "', solveday= '" + bugs.Solveday + "', solvecode='" + bugs.Solvecode + "' where bugId= '" + bugs.BugId + "'; ";
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
