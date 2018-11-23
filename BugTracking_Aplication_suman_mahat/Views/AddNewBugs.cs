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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BugTracking_Aplication_suman_mahat.Views
{
    public partial class AddNewBugs : MaterialSkin.Controls.MaterialForm
    {
        //declearing required variables
        private string email;
        private string path;
        public AddNewBugs(string email)
        {
            this.email = email;
            InitializeComponent();
        }

        /// <summary>
        /// button event to add bugs
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_add_Click(object sender, EventArgs e)
        {
           
            string project = txt_project.Text;
            string className = txt_class.Text;
            string method = txt_method.Text;
            string lineNo = txt_lineNo.Text;
            string endline = txt_endlinenub.Text;
            string codeAuthor = txt_codeAuthor.Text;
            string year = combo_year.Text;
            string month = combo_month.Text;
            string date = combo_date.Text;
            string sourcecode = txt_sourceCode.Text;
            if (!string.IsNullOrEmpty(project)
                && !string.IsNullOrEmpty(month) && !string.IsNullOrEmpty(date) &&
                !string.IsNullOrEmpty(year) && !string.IsNullOrEmpty(sourcecode) && !string.IsNullOrEmpty(path))
            {
                Bugs bugs = new Bugs()
                {
                    Addedby = email,
                    Projectname = project,
                    Classname = className,
                    Method = method,
                    Lineno = lineNo,
                    Endline=endline,
                    Author = codeAuthor,
                    Year = year,
                    Month = month,
                    Day = date,
                    Sourcecode = sourcecode,
                    Imgfile= path,
                    Status = "Active"
                };

                BugsController bController = new BugsController();
                Boolean rep = bController.AddBug(bugs);
                if (rep)
                {
                    MessageBox.Show("Bug added succesful");
                    txt_project.Text="";
                    txt_class.Text = "";
                    txt_codeAuthor.Text = "";
                    txt_lineNo.Text = "";
                    txt_endlinenub.Text = "";
                    txt_method.Text = "";
                    txt_sourceCode.Text = "";
                    combo_date.Text = "";
                    combo_month.Text = "";
                    combo_year.Text = "";
                    lbl_path.Text = "";
                }
            }
            else
            {
                MessageBox.Show("unsuccesful");
            }

            }

        private void pan_addBug_Paint(object sender, PaintEventArgs e)
        {

        }

        /// <summary>
        /// event to choose image file from computer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_open_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog op = new OpenFileDialog();
                op.Filter = "Choose Image(*.jpg; *.png; *.gif)| *.jpg; *.png; *.gif";
                if (op.ShowDialog() == DialogResult.OK)
                {
                    path = op.FileName;
                    lbl_path.Text = path;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// event for syntax color code in text box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
            string strings= "\".+?\"";
            MatchCollection stringMatches = Regex.Matches(txt_sourceCode.Text, strings);

            //
            int originalStart = txt_sourceCode.SelectionStart;
            int originalLength = txt_sourceCode.SelectionLength;
            Color originalColor = Color.Black;

            txt_project.Focus();
            txt_sourceCode.SelectionStart = 0;
            txt_sourceCode.SelectionLength = txt_sourceCode.Text.Length;
            txt_sourceCode.SelectionColor = originalColor;

            foreach(Match match in fmatch)
            {
                txt_sourceCode.SelectionStart = match.Index;
                txt_sourceCode.SelectionLength = match.Index;
                txt_sourceCode.SelectionColor = Color.Blue;
            }

            foreach(Match match in classMatch)
            {
                txt_sourceCode.SelectionStart = match.Index;
                txt_sourceCode.SelectionLength = match.Index;
                txt_sourceCode.SelectionColor = Color.Brown;
            }
            foreach(Match match in commentMatch)
            {
                txt_sourceCode.SelectionStart = match.Index;
                txt_sourceCode.SelectionLength = match.Index;
                txt_sourceCode.SelectionColor = Color.DarkGreen;
            }

            txt_sourceCode.SelectionStart = originalStart;
            txt_sourceCode.SelectionLength = originalLength;
            txt_sourceCode.SelectionColor = originalColor;

            txt_project.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void AddNewBugs_Load(object sender, EventArgs e)
        {

        }
    }
    }

