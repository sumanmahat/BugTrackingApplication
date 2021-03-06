﻿using BugTracking_Aplication_suman_mahat.Controller;
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
    public partial class EditUser : MaterialSkin.Controls.MaterialForm
    {
        //variables decleared
        private int Id;
        public EditUser(int Id, string fullname, string email, string contact, string status)
        {
            InitializeComponent();
            this.Id = Id;
            txt_fullName.Text = fullname;
            txt_email.Text = email;
            txt_contact.Text = contact;
            combo_role.Text = status;
        }

        private void EditUser_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// button event to edit user details
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_edit_Click(object sender, EventArgs e)
        {
            string fullname = txt_fullName.Text;
            string email = txt_email.Text;
            string contact = txt_contact.Text;
            string status = combo_role.Text;
            if(!string.IsNullOrEmpty(fullname) && !string.IsNullOrEmpty(email) && !string.IsNullOrEmpty(contact) && !string.IsNullOrEmpty(status))
            {
                UserProfile profile = new UserProfile();
                profile.UserId1 = Id;
                profile.FullName1 = fullname;
                profile.Email = email;
                profile.Contact = contact;
                profile.Status = status;
                ProfileController pController = new ProfileController();
                Boolean update = pController.UserUpdate(profile);
                if (update)
                {
                    MessageBox.Show("Succesfully updated..");
                    Dispose();

                }
                else
                {
                    MessageBox.Show("Unsucessfull..");
                }
             }
            else
            {
                MessageBox.Show("Fill the fields");
            }
        }

        private void txt_fullName_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
