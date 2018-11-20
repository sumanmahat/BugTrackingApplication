using BugTracking_Aplication_suman_mahat.Views;
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
using BugTracking_Aplication_suman_mahat.Controller;
using System.IO;

namespace BugTracking_Aplication_suman_mahat
{
    public partial class BugTracking : Form
    {

        //variable 
        private string email;
        private int userId;

        public BugTracking()
        {

        }
        public BugTracking(string email, int userId)
        {
            this.email = email;
            this.userId = userId;
            this.WindowState = FormWindowState.Maximized;
            InitializeComponent();
        }

        private void BugTracking_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// event to view user profile
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void viewProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserProfile profile = new UserProfile();
            profile.UserId1 = userId;
            ProfileController pController = new ProfileController();
            pController.GetUserData(profile);
            string fullname = pController.fullname;
            string email = pController.email;
            string contact = pController.contact;
            string status = pController.status;
            ViewUserProfile uprofile = new ViewUserProfile(fullname,email,contact,status);
            uprofile.ShowDialog();
        }


        //event to open Addnewbug form
        private void addBugToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewBugs addBugs = new AddNewBugs(email);
            addBugs.ShowDialog();
        }

        //event on editbugs
        public void EditBugForm(string currentemail, int bugId, string projectname, string classname, string method, string lineNo,string endline, MemoryStream mStream,string author, string year, string month, string day, string sourcecode, string status, string addedby, string solveremail, string solveyear, string solvemonth, string solveday, string solvecode)
        {
            EditBug edit = new EditBug(currentemail,bugId,projectname,classname,method,lineNo,endline,mStream,author,year,month,day,sourcecode,status,addedby,solveremail,solveyear,solvemonth,solveday,solvecode);
            edit.ShowDialog();
        }

        //event to view bugs
        private void vToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewBugs viewBugs = new ViewBugs(email);
            viewBugs.ShowDialog();
        }

        private void viewAllBugsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AllBugs allBugs = new AllBugs(email);
            allBugs.ShowDialog();
        }

        //form closing request
        bool close = true;
        private void BugTracking_FormClosing(object sender, FormClosingEventArgs e)
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

        /// <summary>
        /// event on logout
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login lg = new Login();
            lg.ShowDialog();
            this.Close();
        }
    }
}
