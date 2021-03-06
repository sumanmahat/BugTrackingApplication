﻿namespace BugTracking_Aplication_suman_mahat.Views
{
    partial class EditUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_email = new System.Windows.Forms.TextBox();
            this.combo_role = new System.Windows.Forms.ComboBox();
            this.lbl_role = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.txt_fullName = new System.Windows.Forms.TextBox();
            this.lbl_fullName = new System.Windows.Forms.Label();
            this.btn_edit = new System.Windows.Forms.Button();
            this.txt_contact = new System.Windows.Forms.TextBox();
            this.lbl_contact = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_email
            // 
            this.txt_email.Cursor = System.Windows.Forms.Cursors.No;
            this.txt_email.Enabled = false;
            this.txt_email.Font = new System.Drawing.Font("Century", 18F);
            this.txt_email.ForeColor = System.Drawing.Color.Blue;
            this.txt_email.Location = new System.Drawing.Point(348, 159);
            this.txt_email.Name = "txt_email";
            this.txt_email.ReadOnly = true;
            this.txt_email.Size = new System.Drawing.Size(292, 36);
            this.txt_email.TabIndex = 34;
            // 
            // combo_role
            // 
            this.combo_role.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_role.Font = new System.Drawing.Font("Century", 18F);
            this.combo_role.ForeColor = System.Drawing.Color.Blue;
            this.combo_role.FormattingEnabled = true;
            this.combo_role.Items.AddRange(new object[] {
            "Developer",
            "Tester",
            "Admin"});
            this.combo_role.Location = new System.Drawing.Point(348, 279);
            this.combo_role.Name = "combo_role";
            this.combo_role.Size = new System.Drawing.Size(292, 36);
            this.combo_role.TabIndex = 27;
            // 
            // lbl_role
            // 
            this.lbl_role.AutoSize = true;
            this.lbl_role.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_role.ForeColor = System.Drawing.Color.DarkCyan;
            this.lbl_role.Location = new System.Drawing.Point(28, 269);
            this.lbl_role.Name = "lbl_role";
            this.lbl_role.Size = new System.Drawing.Size(90, 37);
            this.lbl_role.TabIndex = 33;
            this.lbl_role.Text = "Role :";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_email.ForeColor = System.Drawing.Color.DarkCyan;
            this.lbl_email.Location = new System.Drawing.Point(28, 156);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(103, 37);
            this.lbl_email.TabIndex = 32;
            this.lbl_email.Text = "Email :";
            // 
            // txt_fullName
            // 
            this.txt_fullName.Font = new System.Drawing.Font("Century", 18F);
            this.txt_fullName.ForeColor = System.Drawing.Color.Blue;
            this.txt_fullName.Location = new System.Drawing.Point(348, 111);
            this.txt_fullName.Name = "txt_fullName";
            this.txt_fullName.Size = new System.Drawing.Size(292, 36);
            this.txt_fullName.TabIndex = 24;
            this.txt_fullName.TextChanged += new System.EventHandler(this.txt_fullName_TextChanged);
            // 
            // lbl_fullName
            // 
            this.lbl_fullName.AutoSize = true;
            this.lbl_fullName.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fullName.ForeColor = System.Drawing.Color.DarkCyan;
            this.lbl_fullName.Location = new System.Drawing.Point(28, 102);
            this.lbl_fullName.Name = "lbl_fullName";
            this.lbl_fullName.Size = new System.Drawing.Size(158, 37);
            this.lbl_fullName.TabIndex = 29;
            this.lbl_fullName.Text = "Full Name :";
            // 
            // btn_edit
            // 
            this.btn_edit.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit.ForeColor = System.Drawing.Color.DarkCyan;
            this.btn_edit.Location = new System.Drawing.Point(180, 391);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(86, 36);
            this.btn_edit.TabIndex = 35;
            this.btn_edit.Text = "Edit User";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // txt_contact
            // 
            this.txt_contact.Font = new System.Drawing.Font("Century", 18F);
            this.txt_contact.ForeColor = System.Drawing.Color.Blue;
            this.txt_contact.Location = new System.Drawing.Point(348, 227);
            this.txt_contact.Name = "txt_contact";
            this.txt_contact.Size = new System.Drawing.Size(292, 36);
            this.txt_contact.TabIndex = 26;
            // 
            // lbl_contact
            // 
            this.lbl_contact.AutoSize = true;
            this.lbl_contact.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_contact.ForeColor = System.Drawing.Color.DarkCyan;
            this.lbl_contact.Location = new System.Drawing.Point(28, 218);
            this.lbl_contact.Name = "lbl_contact";
            this.lbl_contact.Size = new System.Drawing.Size(238, 37);
            this.lbl_contact.TabIndex = 31;
            this.lbl_contact.Text = "Contact Number :";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.DarkCyan;
            this.button1.Location = new System.Drawing.Point(348, 391);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 36);
            this.button1.TabIndex = 36;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // EditUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 457);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.combo_role);
            this.Controls.Add(this.lbl_role);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.txt_contact);
            this.Controls.Add(this.lbl_contact);
            this.Controls.Add(this.txt_fullName);
            this.Controls.Add(this.lbl_fullName);
            this.Name = "EditUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditUser";
            this.Load += new System.EventHandler(this.EditUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.ComboBox combo_role;
        private System.Windows.Forms.Label lbl_role;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.TextBox txt_fullName;
        private System.Windows.Forms.Label lbl_fullName;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.TextBox txt_contact;
        private System.Windows.Forms.Label lbl_contact;
        private System.Windows.Forms.Button button1;
    }
}