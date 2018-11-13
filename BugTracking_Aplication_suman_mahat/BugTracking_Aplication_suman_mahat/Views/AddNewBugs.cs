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
    public partial class AddNewBugs : Form
    {
        private string email;
        public AddNewBugs(string email)
        {
            this.email = email;
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string project = txt_project.Text;
            string className = txt_class.Text;
            string method = txt_method.Text;
            string lineNo = txt_lineNo.Text;
            string codeAuthor = txt_codeAuthor.Text;
            string year = combo_year.Text;
            string month = combo_month.Text;
            string date = combo_date.Text;
            string sourcecode = txt_sourceCode.Text;
            if (!string.IsNullOrEmpty(project)
                && !string.IsNullOrEmpty(month) && !string.IsNullOrEmpty(date) &&
                !string.IsNullOrEmpty(year) && !string.IsNullOrEmpty(sourcecode))
            {
                Bugs bugs = new Bugs()
                {
                    Addedby = email,
                    Projectname = project,
                    Classname = className,
                    Method = method,
                    Lineno = lineNo,
                    Author = codeAuthor,
                    Year = year,
                    Month = month,
                    Day = date,
                    Sourcecode = sourcecode,
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
                    txt_method.Text = "";
                    txt_sourceCode.Text = "";
                    combo_date.Text = "";
                    combo_month.Text = "";
                    combo_year.Text = "";
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
    }
    }

