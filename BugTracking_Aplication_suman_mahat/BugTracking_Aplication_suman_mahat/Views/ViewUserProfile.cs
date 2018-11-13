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
    public partial class ViewUserProfile : Form
    {
        public ViewUserProfile(string fullname, string email, string contact, string status)
        {
            InitializeComponent();
            txt_fullName.Text = fullname;
            txt_email.Text = email;
            txt_contact.Text = contact;
            txt_role.Text = status;

        }

        private void ViewUserProfile_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
