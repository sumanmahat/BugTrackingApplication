using BugTracking_Aplication_suman_mahat.Controller;
using BugTracking_Aplication_suman_mahat.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BugTracking_Aplication_suman_mahat.Views
{
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();
        }

        //aadding new user to database
        private void button1_Click(object sender, EventArgs e)
        {
            string email = txt_email.Text;
            string fullname = txt_name.Text;
            string password = txt_password.Text;
            string conformPass = txt_confirmPassword.Text;
            string contact = txt_contact.Text;
            string status = combo_status.Text;
            if (!string.IsNullOrEmpty(email) && !string.IsNullOrEmpty(fullname) && !string.IsNullOrEmpty(password) &&
                !string.IsNullOrEmpty(conformPass) && !string.IsNullOrEmpty(contact) && !string.IsNullOrEmpty(status))
            {
                if (password == conformPass)
                {
                    UserProfile userprofile = new UserProfile();
                    userprofile.Email = email;
                    ProfileController pController = new ProfileController();
                    Boolean Emailexist = pController.EmailAuthinticate(userprofile);
                    if (!Emailexist)
                    {
                        userprofile.FullName1 = fullname;
                        userprofile.Password = password;
                        userprofile.Contact = contact;
                        userprofile.Status = status;
                        Boolean add = pController.AddNewUser(userprofile);
                        if (add)
                        {
                            MessageBox.Show("User added succesfull");
                            txt_name.Text = "";
                            txt_email.Text = "";
                            txt_password.Text = "";
                            txt_confirmPassword.Text = "";
                            txt_contact.Text = "";
                            combo_status.Text = "";
                            txt_name.Focus();

                        }
                        else
                        {
                            MessageBox.Show("user added unsuccesfull");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Email exist already");
                        txt_email.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("password doesn't match");
                    txt_confirmPassword.Focus();
                }

            }
            else
            {
                MessageBox.Show("please input required fields");
            }
        
        }


        //key down events fortext box (enter to go in next text area)
        private void AddUser_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if(txt_name.Text.Length > 0)
                {
                    txt_email.Focus();
                }
                else
                {
                    txt_name.Focus();
                }
            }
        }

        private void txt_email_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txt_email.Text.Length > 0)
                {
                    txt_password.Focus();
                }
                else
                {
                    txt_email.Focus();
                }
            }
        }

        private void txt_password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txt_password.Text.Length > 0)
                {
                    txt_confirmPassword.Focus();
                }
                else
                {
                    txt_password.Focus();
                }
            }
        }

        private void txt_confirmPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txt_confirmPassword.Text.Length > 0)
                {
                    combo_status.Focus();
                }
                else
                {
                    txt_confirmPassword.Focus();
                }
            }
        }

        private void txt_name_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txt_name.Text.Length > 0)
                {
                    txt_email.Focus();
                }
                else
                {
                    txt_name.Focus();
                }
            }
        }

        private void AddUser_Load(object sender, EventArgs e)
        {

        }
    }
}

