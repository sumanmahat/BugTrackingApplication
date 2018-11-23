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
    public partial class TesterPanel : Form
    {

        //variable 
        private string email;
        private int userId;
        public Boolean testerFlag;

        public TesterPanel(string email,int userId)
        {
            this.email = email;
            this.userId = userId;
            this.WindowState = FormWindowState.Maximized;
            InitializeComponent();
        }

        public TesterPanel(string email, int userId, Boolean testerFlag)
        {
            this.testerFlag = testerFlag;
            this.email = email;
            this.userId = userId;
            this.WindowState = FormWindowState.Maximized;
            InitializeComponent();
        }

        private void TesterPanel_Load(object sender, EventArgs e)
        {

        }

        //event to open addnewbug form
        private void addBugsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewBugs addBugs = new AddNewBugs(email);
            addBugs.ShowDialog();
        }

        private void viewBugsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchBug all = new SearchBug();
            all.ShowDialog();
        }

        /// <summary>
        /// event to view user profile
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
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


        /// <summary>
        /// event to logout
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login lg = new Login();
            lg.ShowDialog();
            this.Close();
        }
    }
}
