using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BugTracking_Aplication_suman_mahat
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            Connection con = new Connection();
            con.dataGet("Select * from [tbl_user] where email= '" + txt_email.Text + "' and password= '" + txt_password.Text + "'  ");
            DataTable dt = new DataTable();
            con.adpater.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                this.Hide();
                BugTracking bt = new BugTracking();
                bt.Show();
            }
            else
            {
                MessageBox.Show("Invalid email or password..!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
