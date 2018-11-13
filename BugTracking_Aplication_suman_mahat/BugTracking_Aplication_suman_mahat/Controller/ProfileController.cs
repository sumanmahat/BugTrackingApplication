using BugTracking_Aplication_suman_mahat.Model;
using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace BugTracking_Aplication_suman_mahat.Controller
{
    class ProfileController
    {
        //required variables for profile controller
        private MySqlConnection conn = null;
        private MySqlCommand cmd;
        public string fullname, email, contact, status;
      //  private object txt_email;
      //  public string pkk;

        public ProfileController()
        {
            if(conn == null)
            {
                conn = Connection.getConn();
            }
        }

        //profileAuthentication
        /// <summary>
        /// <paramref name="userprofile"></paramref>/>
        /// </summary>
        /// <returns></returns>
        public Boolean ProfileAuthenticaion(UserProfile userprofile)
        {
            Boolean isValid = false;
            string q1 = "Select * from tbl_user where email= '" + userprofile.Email + "' and password= '" + userprofile.Password + "' ; ";
            try
            {
                conn.Open();
                cmd = new MySqlCommand(q1, conn);
                MySqlDataReader datareader = cmd.ExecuteReader();
                while (datareader.Read())
                {
                    isValid = true;
                }
                conn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error.." + ex.Message);
            }
            return isValid;
        }

        public Boolean PasswordUpdate(UserProfile userprofile)
        {
            Boolean isUpdate = false;
            string q2 = "update [tbl_user] set password='" + userprofile.Password + "' where email='" + userprofile.Email + "';";
            try
            {
                conn.Open();
                cmd = new MySqlCommand(q2, conn);
                int update = cmd.ExecuteNonQuery();
                if (update > 0)
                {
                    isUpdate = true;
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex.Message);
            }
            return isUpdate;
        }

        //checking uesr email already exist or not 
        public Boolean EmailAuthinticate(UserProfile userprofile)
        {
            Boolean emailValid = false;
            string q3 = "select * from tbl_user where email='" + userprofile.Email + "';";
            try
            {
                conn.Open();
                cmd = new MySqlCommand(q3, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    emailValid = true;
                }
                conn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error.." + ex.Message);
            }
            return emailValid;
        }

        public Boolean AddNewUser(UserProfile userprofile)
        {
            Boolean addnewUser = false;
            string q4 = "INSERT INTO tbl_user (email, password, fullname, contact, status) VALUES ('" + userprofile.Email + "', '" + userprofile.Password + "', '" + userprofile.FullName1 + "', '" + userprofile.Contact + "', '" + userprofile.Status + "');";
            try
            {
                conn.Open();
                cmd = new MySqlCommand(q4, conn);
                int newuser = cmd.ExecuteNonQuery();
                if(newuser > 0)
                {
                    addnewUser = true;
                }
                conn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error.." + ex.Message);
            }
            return addnewUser;               
        }
        
        public DataTable LoadUsersData()
        {
            DataTable dt = new DataTable();
            string q5 = "select * from tbl_user";
            try
            {
                conn.Open();
                cmd = new MySqlCommand(q5, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter
                {
                    SelectCommand = cmd
                };
                adapter.Fill(dt);
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex.Message);
            }
            return dt;
        }


        // method to update user data
        public Boolean UserUpdate(UserProfile userprofile)
        {
            Boolean update = false;
            string q6 = "update tbl_user set fullname= '" + userprofile.FullName1 + "',contact= '" + userprofile.Contact + "', status= '" + userprofile.Status + "' where id= '" + userprofile.UserId1 + "' and " + "email= '" + userprofile.Email + "'";
            try
            {
                conn.Open();
                cmd = new MySqlCommand(q6, conn);
                int DataUpdate = cmd.ExecuteNonQuery();
                if(DataUpdate > 0)
                {
                    update = true;
                }
                conn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error.." + ex.Message);
            }
            return update;
        }


        //method to delete user data 
        public Boolean DeleteUserData(UserProfile userprofile)
        {
            Boolean delete = false;
            string q7 = "delete from tbl_user where id='" + userprofile.UserId1 + "' and email='" + userprofile.Email + "';";
            try
            {
                conn.Open();
                cmd = new MySqlCommand(q7, conn);
                int deletedData = cmd.ExecuteNonQuery();
                if(deletedData > 0)
                {
                    delete = true;
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex.Message);
            }
            return delete;
            
        }
        

        public int GetUserId(UserProfile userprofile)
        {
            int userID = 0;
            string q8 = "select id from tbl_user where email= '" + userprofile.Email + "' and password= '" + userprofile.Password + "';";
            try
            {
                conn.Open();
                cmd = new MySqlCommand(q8, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    userID = Convert.ToInt32(reader["id"]);
                }
                conn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error.." + ex.Message);
            }
            return userID;
        }


        public string GetStatus(UserProfile userprofile)
        {
            string status = "";
            string q9 = "select status from tbl_user where email='" + userprofile.Email + "' and password='" + userprofile.Password + "' ; ";
            try
            {
                conn.Open();
                cmd = new MySqlCommand(q9, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    status = reader["status"].ToString();
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex.Message);
            }
            return status;
        }

        public void GetUserData(UserProfile userprofile)
        {
            string q10 = "select * from tbl_user where id='" + userprofile.UserId1 + "';";
            try{
                conn.Open();
                cmd = new MySqlCommand(q10, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    email = reader["email"].ToString();
                    fullname = reader["fullname"].ToString();
                    contact = reader["contact"].ToString();
                    status = reader["status"].ToString();    
                }
                conn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error.." + ex.Message);
            }
        }
    }

}
