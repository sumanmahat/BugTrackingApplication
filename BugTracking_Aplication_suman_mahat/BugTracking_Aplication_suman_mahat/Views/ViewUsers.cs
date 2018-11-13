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
    public partial class ViewUsers : Form
    {
        public ViewUsers()
        {
            InitializeComponent();
            LoadAllUser();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void LoadAllUser()
        {
            ProfileController pController = new ProfileController();
            DataTable dt = pController.LoadUsersData();
            dataGridView1.DataSource = dt;
            dataGridView1.Columns["password"].Visible = false;
            dataGridView1.Rows.Remove(dataGridView1.Rows[0]);
            dataGridView1.Columns["id"].HeaderText = "Id";
            dataGridView1.Columns["fullname"].HeaderText = "Full Name";
            dataGridView1.Columns["email"].HeaderText = "Email";
            dataGridView1.Columns["contact"].HeaderText = "Contact";
            dataGridView1.Columns["status"].HeaderText = "Status";
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.MultiSelect = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;

        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0)
            {
                int Id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                string fullname = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                string email = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                string contact = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                string status = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                AdminPanelForm adminpanel = new AdminPanelForm();
                adminpanel.EditUserForm(Id, fullname, email, contact, status);
                dataGridView1.Refresh();
                LoadAllUser();
            }
            else
            {
                MessageBox.Show("Please selct a row...");
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete user?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    int Id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                    string email = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                    UserProfile profile = new UserProfile();
                    profile.UserId1 = Id;
                    profile.Email = email;
                    ProfileController pController = new ProfileController();
                    Boolean delete = pController.DeleteUserData(profile);
                    if (delete)
                    {
                        MessageBox.Show("Succesfully deleted..");
                        dataGridView1.Refresh();
                        LoadAllUser();
                    }
                    else
                    {
                        MessageBox.Show("Unseccesfull");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a row..");
            }
        }
    
    }
}
