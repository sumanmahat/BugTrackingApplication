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
    public partial class ViewBugDetails : Form
    {
        public ViewBugDetails()
        {
        }

        public ViewBugDetails(string currentemail, int bugId, string projectname, string classname, string method, string lineNo, string endline, MemoryStream mStream, string author, string year, string month, string day, string sourcecode, string status, string addedby, string solveremail, string solveyear, string solvemonth, string solveday, string solvecode)
        {
            InitializeComponent();

            pictureBox_bug.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox_bug.Image = Image.FromStream(mStream);
            txt_project.Text = projectname;
            txt_class.Text = classname;
            txt_method.Text = method;
            txt_lineNo.Text = lineNo;
            txt_endlinenub.Text = endline;
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

        private void ViewBugDetails_Load(object sender, EventArgs e)
        {

        }
    }
}
