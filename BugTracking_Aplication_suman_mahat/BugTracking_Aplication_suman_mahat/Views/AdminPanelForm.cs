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
    public partial class AdminPanelForm : Form
    {

        //variable
        private string email;

        //constructor
        public AdminPanelForm()
        {

        }
        public AdminPanelForm(string email)
        {
            this.email = email;
            InitializeComponent();
        }

        private void showUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewUsers user = new ViewUsers();
            user.ShowDialog();
        }

        private void AdminPanelForm_Load(object sender, EventArgs e)
        {

        }

        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddUser addUser = new AddUser();
            addUser.ShowDialog();
        }

        public void EditUserForm(int Id, string fullname, string email, string contact, string status)
        {
            EditUser eUser = new EditUser(Id, fullname, email, contact, status);
            eUser.ShowDialog();
        }

        private void viewBugsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AllBugs bugs = new AllBugs(email);
            bugs.ShowDialog();
        }

        public void EditBugFroms(string currentemail, int bugId, string projectname, string classname, string method, string lineNo, string author, string year, string month, string day, string sourcecode, string status, string addedby, string solveremail, string solveyear, string solvemonth, string solveday, string solvecode)
        {
            EditBug edit = new EditBug(currentemail,bugId,projectname,classname,method,lineNo,author,year,month,day,sourcecode,status,addedby,solveremail,solveyear,solvemonth,solveday,solvecode);
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
    }
}
