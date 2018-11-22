using BugTracking_Aplication_suman_mahat.Controller;
using MySql.Data.MySqlClient;
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
    public partial class SearchBug : Form
    {
        private string email;
        public SearchBug()
        {
            InitializeComponent();
        }

        MySqlConnection con = new MySqlConnection("datasource=localhost;username=root;password=;database=bugtrackin_suman;SSLmode=none");

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SearchData(txt_search.Text);

        }

        private void SearchBug_Load(object sender, EventArgs e)
        {
           
           SearchData("");
        }

        public void SearchData(string valuetofind)
        {

            string searchdata = "select * from tbl_bugs where CONCAT(projectname,classname) LIKE '%" + valuetofind + "%'";
            MySqlDataAdapter adp = new MySqlDataAdapter(searchdata, con);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dataGridView1.DataSource = dt;

        }
        /// <summary>
        /// Loading all bugs into DataTable
        /// </summary>
        public void LoadAllBugs()
        {
            BugsController bController = new BugsController();
            DataTable dt = bController.ShowAllBugs(email);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns["bugId"].HeaderText = "BugId";
            dataGridView1.Columns["projectname"].HeaderText = "Project Name";
            dataGridView1.Columns["classname"].HeaderText = "Class Name";
            dataGridView1.Columns["method"].HeaderText = "Method";
            dataGridView1.Columns["lineNo"].HeaderText = "StartLine No.";
            dataGridView1.Columns["endline"].HeaderText = "EndLine no.";
            dataGridView1.Columns["author"].HeaderText = "Author";
            dataGridView1.Columns["year"].HeaderText = "Year";
            dataGridView1.Columns["month"].HeaderText = "Month";
            dataGridView1.Columns["day"].HeaderText = "Day";
            dataGridView1.Columns["sourcecode"].HeaderText = "Source Code";
            dataGridView1.Columns["status"].HeaderText = "Status";
            dataGridView1.Columns["addedby"].HeaderText = "Added By";
            dataGridView1.Columns["solveremail"].HeaderText = "Solver Email";
            dataGridView1.Columns["solveyear"].HeaderText = "Solve Year";
            dataGridView1.Columns["solvemonth"].HeaderText = "Solve month";
            dataGridView1.Columns["solveday"].HeaderText = "Solve day";
            dataGridView1.Columns["solvecode"].HeaderText = "Solve code";

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;

        }

        private void btn_solution_Click(object sender, EventArgs e)
        {
            MemoryStream mStream;
            if (dataGridView1.SelectedRows.Count != 0)
            {
                int bugId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                string projectname = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                string classname = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                string method = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                string lineNo = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                string endline = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                byte[] errorsnap = (byte[])dataGridView1.SelectedRows[0].Cells[6].Value;
                string author = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
                string year = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
                string month = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();
                string day = dataGridView1.SelectedRows[0].Cells[10].Value.ToString();
                string sourcecode = dataGridView1.SelectedRows[0].Cells[11].Value.ToString();
                string status = dataGridView1.SelectedRows[0].Cells[12].Value.ToString();
                string addedby = dataGridView1.SelectedRows[0].Cells[13].Value.ToString();
                string solveremail = dataGridView1.SelectedRows[0].Cells[14].Value.ToString();
                string solveyear = dataGridView1.SelectedRows[0].Cells[15].Value.ToString();
                string solvemonth = dataGridView1.SelectedRows[0].Cells[16].Value.ToString();
                string solveday = dataGridView1.SelectedRows[0].Cells[17].Value.ToString();
                string solvecode = dataGridView1.SelectedRows[0].Cells[18].Value.ToString();
                mStream = new MemoryStream(errorsnap);
                string role = email;
                if (role == "admin@admin.com")
                {
                    AdminPanelForm admin = new AdminPanelForm();
                    admin.BugDetailForm(email, bugId, projectname, classname, method, lineNo, endline, mStream, author, year, month, day, sourcecode, status, addedby, solveremail, solveyear, solvemonth, solveday, solvecode);
                    dataGridView1.Refresh();
                    LoadAllBugs();
                }
                else
                {
                    BugTracking panel = new BugTracking();
                    panel.BugDetailForm(email, bugId, projectname, classname, method, lineNo, endline, mStream, author, year, month, day, sourcecode, status, addedby, solveremail, solveyear, solvemonth, solveday, solvecode);
                    dataGridView1.Refresh();
                    LoadAllBugs();
                }



            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
