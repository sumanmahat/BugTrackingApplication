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
    public partial class EditBug : Form
    {
        private int bugId;
        public EditBug(string currentemail, int bugId, string projectname, string classname, string method, string lineNo, string author, string year, string month, string day, string sourcecode, string status, string addedby, string solveremail, string solveyear, string solvemonth, string solveday, string solvecode)
        {
            InitializeComponent();
            this.bugId = bugId;
            txt_project.Text = projectname;
            txt_class.Text = classname;
            txt_method.Text = method;
            txt_lineNo.Text = lineNo;
            txt_codeAuthor.Text = author;
            combo_year.Text = year;
            combo_month.Text = month;
            combo_date.Text = day;
            txt_sourceCode.Text = sourcecode;
            combo_status.Text = status;
            txt_addedEmail.Text = addedby;
            txt_solver.Text = currentemail;
            combo_fixYear.Text = solveyear;
            combo_fixMonth.Text = solvemonth;
            combo_fixDate.Text = solveday;
            txt_solutionCode.Text = solvecode;
        }

        private void combo_status_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void EditBug_Load(object sender, EventArgs e)
        {

        }


        //button event to update edit bugs
        private void btn_update_Click(object sender, EventArgs e)
        {
            string projectname = txt_project.Text;
            string classname = txt_class.Text;
            string method = txt_method.Text;
            string lineNo = txt_lineNo.Text;
            string sourcecode = txt_solutionCode.Text;
            string status = combo_status.Text;
            string solveremail = txt_solver.Text;
            string solveyear = combo_fixYear.Text;
            string solvemonth = combo_fixMonth.Text;
            string solveday = combo_fixDate.Text;
            string solvecode = txt_solutionCode.Text;
            if (!string.IsNullOrEmpty(projectname) && !string.IsNullOrEmpty(classname) && !string.IsNullOrEmpty(method) && !string.IsNullOrEmpty(lineNo)
                && !string.IsNullOrEmpty(sourcecode) && !string.IsNullOrEmpty(solveyear) && !string.IsNullOrEmpty(solvemonth) &&  !string.IsNullOrEmpty(solvecode))
            {
                Bugs bugs = new Bugs()
                {
                    BugId = bugId,
                    Projectname = projectname,
                    Classname= classname,
                    Method= method,
                    Lineno= lineNo,
                    Sourcecode= sourcecode,
                    Status= status,
                    Solver= solveremail,
                    Solveyear= solveyear,
                    Solvemonth= solvemonth,
                    Solveday= solveday,
                    Solvecode= solvecode
                };
                BugsController bController = new BugsController();
                Boolean update = bController.UpdateBugs(bugs);
                if (update)
                {
                    MessageBox.Show("Successfully updated..");
                    Dispose();
                }
                else
                {
                    MessageBox.Show("Not Successfull to update..");

                }
             }
            else
            {
                MessageBox.Show("Please fill all the fields");
            }
        }

        private void txt_project_TextChanged(object sender, EventArgs e)
        {

        }

        private void combo_fixdate_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
