using BugTracking_Aplication_suman_mahat.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BugTracking_Aplication_suman_mahat.Controller
{
    class ProfileController
    {
        //required variables for profile controller
        private SqlConnection conn = null;
        private SqlCommand cmd;
        public string fullname, email, contact, status;
        private object txt_email;
        public string pkk;

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
            string q1 = "Select * from [tbl_user] where email= '" + userprofile.Email + "' and password= '" + userprofile.Password + "' ; ";
            try
            {
                conn.Open();
                cmd = new SqlCommand(q1, conn);
                SqlDataReader datareader = cmd.ExecuteReader();
                while (datareader.Read())
                {
                    isValid = true;
                }
                conn.Close();
            }
            catch(Exception)
            {
                pkk = "Error";
            }
            return isValid;
        }

        public Boolean PasswordUpdate(UserProfile profile)
        {
            Boolean isUpdate = false;
            string q2 = "update user set password='" + profile.Password + "' where email='" + profile.Email + "';";
            try
            {
                conn.Open();
                cmd = new SqlCommand(q2, conn);
                int update = cmd.ExecuteNonQuery();
                if (update > 0)
                {
                    isUpdate = true;
                }
                conn.Close();
            }
            catch (Exception)
            {
                pkk= "Error";
            }
            return isUpdate;
        }


        public Boolean EmailAuthinticate(UserProfile profile)
        {
            Boolean emailValid = false;
            string q3 = "select * from [tbl_user] where email= '" + profile.Email + "';";
            try
            {
                conn.Open();
                cmd = new SqlCommand(q3, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    emailValid = true;
                }
                conn.Close();
            }
            catch(Exception)
            {
                pkk = "Error";
            }
            return emailValid;
        }

        public Boolean AddNewUser(UserProfile profile)
        {
            Boolean addnewUser = false;
            string q4 = "Insert into [tbl_user] (email, password, fullname, contact, status) values ('"+profile.Email+"','"+profile.Password+"','"+profile.FullName1+"','"+profile.Contact+"','"+profile.Status+"');";
            try
            {
                conn.Open();
                cmd = new SqlCommand(q4, conn);
                int newuser = cmd.ExecuteNonQuery();
                if(newuser > 0)
                {
                    addnewUser = true;
                }
                conn.Close();
            }
            catch(Exception)
            {
                pkk = "Error";
            }
            return addnewUser;               
        }
        
        public DataTable LoadUsersData()
        {
            DataTable dt = new DataTable();
            string q5 = "select * from [tbl_user]";
            try
            {
                conn.Open();
                cmd = new SqlCommand(q5, conn);
                SqlDataAdapter adapter = new SqlDataAdapter
                {
                    SelectCommand = cmd
                };
                adapter.Fill(dt);
                conn.Close();
            }
            catch (Exception)
            {
                pkk = "Error";
            }
            return dt;
        }


        // method to update user data
        public Boolean UserUpdate(UserProfile profile)
        {
            Boolean update = false;
            string q6 = "update [tbl_user] set fullname= '" + profile.FullName1 + "',contact= '" + profile.Contact + "', status= '" + profile.Status + "' where id= '" + profile.UserId1 + "' and " + "email= '" + profile.Email + "'";
            try
            {
                conn.Open();
                cmd = new SqlCommand(q6, conn);
                int DataUpdate = cmd.ExecuteNonQuery();
                if(DataUpdate > 0)
                {
                    update = true;
                }
                conn.Close();
            }
            catch(Exception)
            {
                pkk = "Error";
            }
            return update;
        }


        //method to delete user data 
        public Boolean DeleteUserData(UserProfile profile)
        {
            Boolean delete = false;
            string q7 = "delete from [tbl_user] where id='" + profile.UserId1 + "' and email='" + profile.Email + "';";
            try
            {
                conn.Open();
                cmd = new SqlCommand(q7, conn);
                int deletedData = cmd.ExecuteNonQuery();
                if(deletedData > 0)
                {
                    delete = true;
                }
                conn.Close();
            }
            catch (Exception)
            {
                pkk = "";
            }
            return delete;
            
        }
        

        public int GetUserId(UserProfile profile)
        {
            int userID = 0;
            string q8 = "select id from [tbl_user] where email= '" + profile.Email + "' and password= '" + profile.Password + "';";
            try
            {
                conn.Open();
                cmd = new SqlCommand(q8, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    userID = Convert.ToInt32(reader["id"]);
                }
                conn.Close();
            }
            catch(Exception)
            {
                pkk = "errpr";
            }
            return userID;
        }


        public string GetStatus(UserProfile profile)
        {
            string status = "";
            string q9 = "select status from [tbl_user] where email='" + profile.Email + "' and password='" + profile.Password + "' ; ";
            try
            {
                conn.Open();
                cmd = new SqlCommand(q9, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    status = reader["status"].ToString();
                }
                conn.Close();
            }
            catch (Exception)
            {
                pkk = "Error";
            }
            return status;
        }

        public void GetUserData(UserProfile profile)
        {
            string q10 = "select * from [tbl_user] where id='" + profile.UserId1 + "';";
            try{
                conn.Open();
                cmd = new SqlCommand(q10, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    email = reader["email"].ToString();
                    fullname = reader["fullname"].ToString();
                    contact = reader["contact"].ToString();
                    status = reader["status"].ToString();    
                }
                conn.Close();
            }
            catch(Exception)
            {
                pkk = "Error";
            }
        }
    }

}
