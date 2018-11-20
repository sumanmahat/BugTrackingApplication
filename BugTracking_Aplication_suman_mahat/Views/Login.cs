using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BugTracking_Aplication_suman_mahat.Model;
using BugTracking_Aplication_suman_mahat.Controller;
using BugTracking_Aplication_suman_mahat.Views;

namespace BugTracking_Aplication_suman_mahat
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        /// <summary>
        /// button event for login
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_login_Click(object sender, EventArgs e)
        {
            string email = txt_email.Text;
            string password = txt_password.Text;
            if (!string.IsNullOrEmpty(email))
                {
                if (!string.IsNullOrEmpty(password))
                {
                    UserProfile uProfile = new UserProfile
                    {
                        Email = email,
                        Password = password
                    };

                    ProfileController pControllor = new ProfileController();
                    Boolean correct = pControllor.ProfileAuthenticaion(uProfile);

                    if (correct)
                    {
                        string status = pControllor.GetStatus(uProfile);
                        int userId = pControllor.GetUserId(uProfile);
                        if (status == "Admin")
                        {
                            this.Hide();
                            AdminPanelForm admin = new AdminPanelForm(email);
                            admin.ShowDialog();
                            this.Close();

                        }
                        else if(status == "Developer")
                        {
                            this.Hide();
                            BugTracking panel = new BugTracking(email, userId);
                            panel.ShowDialog();
                            this.Close();
                        }
                        else
                        {
                            this.Hide();
                            TesterPanel tp = new TesterPanel(email, userId);
                            tp.ShowDialog();
                            this.Close();
                        }
                        
                    }
                    else
                    {
                        MessageBox.Show("please enter valid email or password..");
                        txt_email.Text = "";
                        txt_password.Text = "";
                        txt_email.Focus();
                        
                    }
                }
                
                else
                {
                    MessageBox.Show("please enter your password.");
                    txt_password.Focus();
                }
            }
            else
            {
                MessageBox.Show("please enter your email..");
                txt_email.Focus();
            }

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}       
               
      
