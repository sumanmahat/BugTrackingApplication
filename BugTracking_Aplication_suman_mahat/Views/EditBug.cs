using BugTracking_Aplication_suman_mahat.Controller;
using BugTracking_Aplication_suman_mahat.Model;
using System;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace BugTracking_Aplication_suman_mahat.Views
{
    public partial class EditBug : Form
    {
        //declearing variables
        private int bugId;
        private string role;
        public EditBug(string currentemail, int bugId, string projectname, string classname, string method, string lineNo, MemoryStream mStream,string author, string year, string month, string day, string sourcecode, string status, string addedby, string solveremail, string solveyear, string solvemonth, string solveday, string solvecode)
        {
            InitializeComponent();
            this.bugId = bugId;
            if (status == "Fixed")
            {
                txt_solutionCode.ReadOnly = true;
                txt_project.ReadOnly = true;
                txt_class.ReadOnly = true;
                txt_method.ReadOnly = true;
                txt_solutionCode.ReadOnly = true;
                btn_update.Visible = false;
                btn_cancel.Visible = false;

            }
           
            
            pictureBox_bug.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox_bug.Image = Image.FromStream(mStream);
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
          //  string status = combo_status.Text;
            string solveremail = txt_solver.Text;
            string solveyear = combo_fixYear.Text;
            string solvemonth = combo_fixMonth.Text;
            string solveday = combo_fixDate.Text;
            string solvecode = txt_solutionCode.Text;
            if (!string.IsNullOrEmpty(solveyear) && !string.IsNullOrEmpty(solvemonth) &&  !string.IsNullOrEmpty(solvecode))
            {
                Bugs bugs = new Bugs()
                {
                    BugId = bugId,
                   Projectname = projectname,
                    Classname= classname,
                    Method= method,
                    Lineno= lineNo,
                    Sourcecode= sourcecode,
                //    Status= status,
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

        private void pictureBox_bug_Click(object sender, EventArgs e)
        {
            
        }

        private void txt_solutionCode_TextChanged(object sender, EventArgs e)
        {
           
        }

        //event for syntax color code
        private void txt_sourceCode_TextChanged(object sender, EventArgs e)
        {
            //color code for functions
            string words = @"\b(public|private|partial|static|namespace|class|using
                            |void|foreach|in|int|string|this|new|try|catch|if|else|)\b";

            MatchCollection fmatch = Regex.Matches(txt_sourceCode.Text, words);

            //color code for classes
            string cMatch = @"\b(Console|MessageBox)\b";
            MatchCollection classMatch = Regex.Matches(txt_sourceCode.Text, cMatch);

            //color code for comment
            string comments = @"(\/\/.+?$|\/\*.+?\*\/)";
            MatchCollection commentMatch = Regex.Matches(txt_sourceCode.Text, comments);

            //color code for strings
            string strings = "\".+?\"";
            MatchCollection stringMatches = Regex.Matches(txt_sourceCode.Text, strings);

            //
            int originalStart = txt_sourceCode.SelectionStart;
            int originalLength = txt_sourceCode.SelectionLength;
            Color originalColor = Color.Black;

            txt_project.Focus();
            txt_sourceCode.SelectionStart = 0;
            txt_sourceCode.SelectionLength = txt_sourceCode.Text.Length;
            txt_sourceCode.SelectionColor = originalColor;

            foreach (Match match in fmatch)
            {
                txt_sourceCode.SelectionStart = match.Index;
                txt_sourceCode.SelectionLength = match.Index;
                txt_sourceCode.SelectionColor = Color.Blue;
            }

            foreach (Match match in classMatch)
            {
                txt_sourceCode.SelectionStart = match.Index;
                txt_sourceCode.SelectionLength = match.Index;
                txt_sourceCode.SelectionColor = Color.Brown;
            }
            foreach (Match match in commentMatch)
            {
                txt_sourceCode.SelectionStart = match.Index;
                txt_sourceCode.SelectionLength = match.Index;
                txt_sourceCode.SelectionColor = Color.DarkGreen;
            }

            txt_sourceCode.SelectionStart = originalStart;
            txt_sourceCode.SelectionLength = originalLength;
            txt_sourceCode.SelectionColor = originalColor;

            
        }

        private void txt_solutionCode_TextChanged_1(object sender, EventArgs e)
        {
            //color code for functions
            string words = @"\b(public|private|partial|static|namespace|class|using
                            |void|foreach|in|int|string|this|new|try|catch|if|else|)\b";

            MatchCollection fmatch = Regex.Matches(txt_solutionCode.Text, words);

            //color code for classes
            string cMatch = @"\b(Console|MessageBox)\b";
            MatchCollection classMatch = Regex.Matches(txt_solutionCode.Text, cMatch);

            //color code for comment
            string comments = @"(\/\/.+?$|\/\*.+?\*\/)";
            MatchCollection commentMatch = Regex.Matches(txt_solutionCode.Text, comments);

            //color code for strings
            string strings = "\".+?\"";
            MatchCollection stringMatches = Regex.Matches(txt_solutionCode.Text, strings);

            //
            int originalStart = txt_solutionCode.SelectionStart;
            int originalLength = txt_solutionCode.SelectionLength;
            Color originalColor = Color.Black;

            //txt_project.Focus();
            txt_solutionCode.SelectionStart = 0;
            txt_solutionCode.SelectionLength = txt_sourceCode.Text.Length;
            txt_solutionCode.SelectionColor = originalColor;

            foreach (Match match in fmatch)
            {
                txt_solutionCode.SelectionStart = match.Index;
                txt_solutionCode.SelectionLength = match.Index;
                txt_solutionCode.SelectionColor = Color.Blue;
            }

            foreach (Match match in classMatch)
            {
                txt_solutionCode.SelectionStart = match.Index;
                txt_solutionCode.SelectionLength = match.Index;
                txt_solutionCode.SelectionColor = Color.Brown;
            }
            foreach (Match match in commentMatch)
            {
                txt_solutionCode.SelectionStart = match.Index;
                txt_solutionCode.SelectionLength = match.Index;
                txt_solutionCode.SelectionColor = Color.DarkGreen;
            }

            txt_solutionCode.SelectionStart = originalStart;
            txt_solutionCode.SelectionLength = originalLength;
            txt_solutionCode.SelectionColor = originalColor;

           // txt_project.Focus();
        }
    }
}
