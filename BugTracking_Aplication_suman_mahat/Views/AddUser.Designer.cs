namespace BugTracking_Aplication_suman_mahat.Views
{
    partial class AddUser
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
            this.txt_confirmPassword = new System.Windows.Forms.TextBox();
            this.lbl_confirmPassword = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.lbl_password = new System.Windows.Forms.Label();
            this.combo_status = new System.Windows.Forms.ComboBox();
            this.lbl_role = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.lbl_email = new System.Windows.Forms.Label();
            this.txt_contact = new System.Windows.Forms.TextBox();
            this.lbl_contact = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.lbl_fullName = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_confirmPassword
            // 
            this.txt_confirmPassword.Font = new System.Drawing.Font("Century", 18F);
            this.txt_confirmPassword.ForeColor = System.Drawing.Color.Blue;
            this.txt_confirmPassword.Location = new System.Drawing.Point(316, 209);
            this.txt_confirmPassword.Name = "txt_confirmPassword";
            this.txt_confirmPassword.Size = new System.Drawing.Size(292, 36);
            this.txt_confirmPassword.TabIndex = 24;
            this.txt_confirmPassword.UseSystemPasswordChar = true;
            this.txt_confirmPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_confirmPassword_KeyDown);
            // 
            // lbl_confirmPassword
            // 
            this.lbl_confirmPassword.AutoSize = true;
            this.lbl_confirmPassword.Font = new System.Drawing.Font("Arial Narrow", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_confirmPassword.ForeColor = System.Drawing.Color.DarkCyan;
            this.lbl_confirmPassword.Location = new System.Drawing.Point(27, 208);
            this.lbl_confirmPassword.Name = "lbl_confirmPassword";
            this.lbl_confirmPassword.Size = new System.Drawing.Size(234, 33);
            this.lbl_confirmPassword.TabIndex = 34;
            this.lbl_confirmPassword.Text = "Confirm Password ";
            // 
            // txt_password
            // 
            this.txt_password.Font = new System.Drawing.Font("Century", 18F);
            this.txt_password.ForeColor = System.Drawing.Color.Blue;
            this.txt_password.Location = new System.Drawing.Point(316, 159);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(292, 36);
            this.txt_password.TabIndex = 23;
            this.txt_password.UseSystemPasswordChar = true;
            this.txt_password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_password_KeyDown);
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Font = new System.Drawing.Font("Arial Narrow", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_password.ForeColor = System.Drawing.Color.DarkCyan;
            this.lbl_password.Location = new System.Drawing.Point(27, 158);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(135, 33);
            this.lbl_password.TabIndex = 33;
            this.lbl_password.Text = "Password ";
            // 
            // combo_status
            // 
            this.combo_status.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.combo_status.Font = new System.Drawing.Font("Century", 18F);
            this.combo_status.ForeColor = System.Drawing.Color.Blue;
            this.combo_status.FormattingEnabled = true;
            this.combo_status.Items.AddRange(new object[] {
            "Developer",
            "Tester"});
            this.combo_status.Location = new System.Drawing.Point(316, 370);
            this.combo_status.Name = "combo_status";
            this.combo_status.Size = new System.Drawing.Size(292, 36);
            this.combo_status.TabIndex = 28;
            this.combo_status.Text = "Select One";
            // 
            // lbl_role
            // 
            this.lbl_role.AutoSize = true;
            this.lbl_role.Font = new System.Drawing.Font("Arial Narrow", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_role.ForeColor = System.Drawing.Color.DarkCyan;
            this.lbl_role.Location = new System.Drawing.Point(27, 375);
            this.lbl_role.Name = "lbl_role";
            this.lbl_role.Size = new System.Drawing.Size(88, 33);
            this.lbl_role.TabIndex = 32;
            this.lbl_role.Text = "Status";
            // 
            // txt_email
            // 
            this.txt_email.Font = new System.Drawing.Font("Century", 18F);
            this.txt_email.ForeColor = System.Drawing.Color.Blue;
            this.txt_email.Location = new System.Drawing.Point(316, 109);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(292, 36);
            this.txt_email.TabIndex = 22;
            this.txt_email.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_email_KeyDown);
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Font = new System.Drawing.Font("Arial Narrow", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_email.ForeColor = System.Drawing.Color.DarkCyan;
            this.lbl_email.Location = new System.Drawing.Point(27, 108);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(86, 33);
            this.lbl_email.TabIndex = 31;
            this.lbl_email.Text = "Email ";
            // 
            // txt_contact
            // 
            this.txt_contact.Font = new System.Drawing.Font("Century", 18F);
            this.txt_contact.ForeColor = System.Drawing.Color.Blue;
            this.txt_contact.Location = new System.Drawing.Point(316, 310);
            this.txt_contact.Name = "txt_contact";
            this.txt_contact.Size = new System.Drawing.Size(292, 36);
            this.txt_contact.TabIndex = 26;
            // 
            // lbl_contact
            // 
            this.lbl_contact.AutoSize = true;
            this.lbl_contact.Font = new System.Drawing.Font("Arial Narrow", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_contact.ForeColor = System.Drawing.Color.DarkCyan;
            this.lbl_contact.Location = new System.Drawing.Point(27, 315);
            this.lbl_contact.Name = "lbl_contact";
            this.lbl_contact.Size = new System.Drawing.Size(208, 33);
            this.lbl_contact.TabIndex = 30;
            this.lbl_contact.Text = "Contact Number ";
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("Century", 18F);
            this.txt_name.ForeColor = System.Drawing.Color.Blue;
            this.txt_name.Location = new System.Drawing.Point(316, 55);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(292, 36);
            this.txt_name.TabIndex = 21;
            this.txt_name.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_name_KeyDown);
            // 
            // lbl_fullName
            // 
            this.lbl_fullName.AutoSize = true;
            this.lbl_fullName.Font = new System.Drawing.Font("Arial Narrow", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fullName.ForeColor = System.Drawing.Color.DarkCyan;
            this.lbl_fullName.Location = new System.Drawing.Point(27, 54);
            this.lbl_fullName.Name = "lbl_fullName";
            this.lbl_fullName.Size = new System.Drawing.Size(137, 33);
            this.lbl_fullName.TabIndex = 27;
            this.lbl_fullName.Text = "Full Name ";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(160, 438);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 38);
            this.button1.TabIndex = 35;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(316, 438);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 38);
            this.button2.TabIndex = 36;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 502);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_confirmPassword);
            this.Controls.Add(this.lbl_confirmPassword);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.combo_status);
            this.Controls.Add(this.lbl_role);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.txt_contact);
            this.Controls.Add(this.lbl_contact);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.lbl_fullName);
            this.Name = "AddUser";
            this.Text = "AddUser";
            this.Load += new System.EventHandler(this.AddUser_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AddUser_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_confirmPassword;
        private System.Windows.Forms.Label lbl_confirmPassword;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.ComboBox combo_status;
        private System.Windows.Forms.Label lbl_role;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.TextBox txt_contact;
        private System.Windows.Forms.Label lbl_contact;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label lbl_fullName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}