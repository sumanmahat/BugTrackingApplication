using BugTracking_Aplication_suman_mahat.Controller;
using BugTracking_Aplication_suman_mahat.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BugTracking_Aplication_suman_mahat.Views
{
    public partial class AdminPanelForm : Form
    {

        //variable
        private string email, status;
        private int userId;

        //constructor
        public AdminPanelForm()
        {

        }
        public AdminPanelForm(string email, String status)
        {
            this.email = email;
            this.WindowState = FormWindowState.Maximized;
            InitializeComponent();
        }

        /// <summary>
        /// event to open user form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void showUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewUsers user = new ViewUsers();
            user.ShowDialog();
        }

        private void AdminPanelForm_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// event to add user form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddUser addUser = new AddUser();
            addUser.ShowDialog();
        }

        /// <summary>
        /// event to edit user data form
        /// </summary>
        /// <param name="Id"></param>
        /// <param name="fullname"></param>
        /// <param name="email"></param>
        /// <param name="contact"></param>
        /// <param name="status"></param>
        public void EditUserForm(int Id, string fullname, string email, string contact, string status)
        {
            EditUser eUser = new EditUser(Id, fullname, email, contact, status);
            eUser.ShowDialog();
        }

        //event to view Bugs
        private void viewBugsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchBug sb = new SearchBug();
            sb.ShowDialog();
        }

        public void BugDetailForm(string currentemail, int bugId, string projectname, string classname, string method, string lineNo, string endline, MemoryStream mStream, string author, string year, string month, string day, string sourcecode, string status, string addedby, string solveremail, string solveyear, string solvemonth, string solveday, string solvecode)
        {
            ViewBugDetails show = new ViewBugDetails(currentemail, bugId, projectname, classname, method, lineNo, endline, mStream, author, year, month, day, sourcecode, status, addedby, solveremail, solveyear, solvemonth, solveday, solvecode);
            show.ShowDialog();
        }


        //event to edit bugs
        public void EditBugFroms(string currentemail, int bugId, string projectname, string classname, string method, string lineNo,string endline,MemoryStream mStream, string author, string year, string month, string day, string sourcecode, string status, string addedby, string solveremail, string solveyear, string solvemonth, string solveday, string solvecode)
        {

            EditBug edit = new EditBug(currentemail,bugId,projectname,classname,method,lineNo,endline,mStream,author,year,month,day,sourcecode,status,addedby,solveremail,solveyear,solvemonth,solveday,solvecode);
            edit.ShowDialog();
        }

        //form closing request
        bool close = true;
        private void AdminPanelForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (close)
            {
                DialogResult dialog = MessageBox.Show("Are you sure you want to exist", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    close = false;
                    Application.Exit();
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        bool logoff = true;
        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (logoff)
            {
                DialogResult dialog = MessageBox.Show("Are you sure you want to Logout", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    this.Hide();
                    Login lg = new Login();
                    lg.ShowDialog();
                    this.Close();
                }
                else
                {
                    
                }
            }
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserProfile profile = new UserProfile();
            profile.UserId1 = userId;
            ProfileController pController = new ProfileController();
            pController.GetUserData(profile);
            string fullname = pController.fullname;
            string email = pController.email;
            string contact = pController.contact;
            string status = pController.status;
            ViewUserProfile uprofile = new ViewUserProfile(fullname, email, contact, status);
            uprofile.ShowDialog();
        }

        private void viewAllBugsToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void viewGitBrowserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VersionControl1 v1 = new VersionControl1();
            v1.ShowDialog();
        }

        private void versionControlToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Notification nof = new Notification();
            nof.ShowDialog();
        }
    }
}
