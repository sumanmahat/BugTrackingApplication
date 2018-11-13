namespace BugTracking_Aplication_suman_mahat.Views
{
    partial class AddNewBugs
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
            this.txt_sourceCode = new System.Windows.Forms.TextBox();
            this.lbl_sourceCode = new System.Windows.Forms.Label();
            this.combo_year = new System.Windows.Forms.ComboBox();
            this.combo_date = new System.Windows.Forms.ComboBox();
            this.combo_month = new System.Windows.Forms.ComboBox();
            this.lbl_date = new System.Windows.Forms.Label();
            this.txt_method = new System.Windows.Forms.TextBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.txt_codeAuthor = new System.Windows.Forms.TextBox();
            this.lbl_codeAuthor = new System.Windows.Forms.Label();
            this.txt_lineNo = new System.Windows.Forms.TextBox();
            this.lbl_lineNo = new System.Windows.Forms.Label();
            this.lbl_method = new System.Windows.Forms.Label();
            this.txt_class = new System.Windows.Forms.TextBox();
            this.lbl_class = new System.Windows.Forms.Label();
            this.txt_project = new System.Windows.Forms.TextBox();
            this.lbl_project = new System.Windows.Forms.Label();
            this.pan_addBug = new System.Windows.Forms.Panel();
            this.pan_addBug.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_sourceCode
            // 
            this.txt_sourceCode.Font = new System.Drawing.Font("Century", 18F);
            this.txt_sourceCode.ForeColor = System.Drawing.Color.Red;
            this.txt_sourceCode.Location = new System.Drawing.Point(337, 398);
            this.txt_sourceCode.Multiline = true;
            this.txt_sourceCode.Name = "txt_sourceCode";
            this.txt_sourceCode.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_sourceCode.Size = new System.Drawing.Size(387, 117);
            this.txt_sourceCode.TabIndex = 10;
            // 
            // lbl_sourceCode
            // 
            this.lbl_sourceCode.AutoSize = true;
            this.lbl_sourceCode.Font = new System.Drawing.Font("Monotype Corsiva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbl_sourceCode.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbl_sourceCode.Location = new System.Drawing.Point(17, 439);
            this.lbl_sourceCode.Name = "lbl_sourceCode";
            this.lbl_sourceCode.Size = new System.Drawing.Size(165, 39);
            this.lbl_sourceCode.TabIndex = 35;
            this.lbl_sourceCode.Text = "Source Code";
            // 
            // combo_year
            // 
            this.combo_year.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.combo_year.Font = new System.Drawing.Font("Century", 18F);
            this.combo_year.ForeColor = System.Drawing.Color.Blue;
            this.combo_year.FormattingEnabled = true;
            this.combo_year.Items.AddRange(new object[] {
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030"});
            this.combo_year.Location = new System.Drawing.Point(339, 347);
            this.combo_year.Name = "combo_year";
            this.combo_year.Size = new System.Drawing.Size(86, 36);
            this.combo_year.TabIndex = 7;
            // 
            // combo_date
            // 
            this.combo_date.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.combo_date.Font = new System.Drawing.Font("Century", 18F);
            this.combo_date.ForeColor = System.Drawing.Color.Blue;
            this.combo_date.FormattingEnabled = true;
            this.combo_date.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32"});
            this.combo_date.Location = new System.Drawing.Point(559, 347);
            this.combo_date.Name = "combo_date";
            this.combo_date.Size = new System.Drawing.Size(86, 36);
            this.combo_date.TabIndex = 9;
            // 
            // combo_month
            // 
            this.combo_month.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.combo_month.Font = new System.Drawing.Font("Century", 18F);
            this.combo_month.ForeColor = System.Drawing.Color.Blue;
            this.combo_month.FormattingEnabled = true;
            this.combo_month.Items.AddRange(new object[] {
            "JAN",
            "FEB",
            "MAR",
            "APR",
            "MAY",
            "JUN",
            "JUL",
            "AUG",
            "SEP",
            "OCT",
            "NOV",
            "DEC"});
            this.combo_month.Location = new System.Drawing.Point(453, 347);
            this.combo_month.Name = "combo_month";
            this.combo_month.Size = new System.Drawing.Size(86, 36);
            this.combo_month.TabIndex = 8;
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Font = new System.Drawing.Font("Monotype Corsiva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbl_date.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbl_date.Location = new System.Drawing.Point(18, 344);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(86, 39);
            this.lbl_date.TabIndex = 22;
            this.lbl_date.Text = "Date:";
            // 
            // txt_method
            // 
            this.txt_method.Font = new System.Drawing.Font("Century", 18F);
            this.txt_method.ForeColor = System.Drawing.Color.Red;
            this.txt_method.Location = new System.Drawing.Point(337, 187);
            this.txt_method.Name = "txt_method";
            this.txt_method.Size = new System.Drawing.Size(387, 36);
            this.txt_method.TabIndex = 4;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.btn_cancel.ForeColor = System.Drawing.Color.Brown;
            this.btn_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cancel.Location = new System.Drawing.Point(430, 573);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(89, 36);
            this.btn_cancel.TabIndex = 12;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.btn_add.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btn_add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_add.Location = new System.Drawing.Point(120, 573);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(62, 36);
            this.btn_add.TabIndex = 11;
            this.btn_add.Text = "Add";
            this.btn_add.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // txt_codeAuthor
            // 
            this.txt_codeAuthor.Font = new System.Drawing.Font("Century", 18F);
            this.txt_codeAuthor.ForeColor = System.Drawing.Color.Blue;
            this.txt_codeAuthor.Location = new System.Drawing.Point(337, 291);
            this.txt_codeAuthor.Name = "txt_codeAuthor";
            this.txt_codeAuthor.Size = new System.Drawing.Size(292, 36);
            this.txt_codeAuthor.TabIndex = 6;
            // 
            // lbl_codeAuthor
            // 
            this.lbl_codeAuthor.AutoSize = true;
            this.lbl_codeAuthor.Font = new System.Drawing.Font("Monotype Corsiva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbl_codeAuthor.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbl_codeAuthor.Location = new System.Drawing.Point(17, 288);
            this.lbl_codeAuthor.Name = "lbl_codeAuthor";
            this.lbl_codeAuthor.Size = new System.Drawing.Size(189, 39);
            this.lbl_codeAuthor.TabIndex = 20;
            this.lbl_codeAuthor.Text = "Code Author :";
            // 
            // txt_lineNo
            // 
            this.txt_lineNo.Font = new System.Drawing.Font("Century", 18F);
            this.txt_lineNo.ForeColor = System.Drawing.Color.Red;
            this.txt_lineNo.Location = new System.Drawing.Point(337, 239);
            this.txt_lineNo.Name = "txt_lineNo";
            this.txt_lineNo.Size = new System.Drawing.Size(387, 36);
            this.txt_lineNo.TabIndex = 5;
            // 
            // lbl_lineNo
            // 
            this.lbl_lineNo.AutoSize = true;
            this.lbl_lineNo.Font = new System.Drawing.Font("Monotype Corsiva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbl_lineNo.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbl_lineNo.Location = new System.Drawing.Point(17, 236);
            this.lbl_lineNo.Name = "lbl_lineNo";
            this.lbl_lineNo.Size = new System.Drawing.Size(196, 39);
            this.lbl_lineNo.TabIndex = 18;
            this.lbl_lineNo.Text = "Line Number :";
            // 
            // lbl_method
            // 
            this.lbl_method.AutoSize = true;
            this.lbl_method.Font = new System.Drawing.Font("Monotype Corsiva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbl_method.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbl_method.Location = new System.Drawing.Point(17, 184);
            this.lbl_method.Name = "lbl_method";
            this.lbl_method.Size = new System.Drawing.Size(129, 39);
            this.lbl_method.TabIndex = 16;
            this.lbl_method.Text = "Method :";
            // 
            // txt_class
            // 
            this.txt_class.Font = new System.Drawing.Font("Century", 18F);
            this.txt_class.ForeColor = System.Drawing.Color.Red;
            this.txt_class.Location = new System.Drawing.Point(337, 133);
            this.txt_class.Name = "txt_class";
            this.txt_class.Size = new System.Drawing.Size(387, 36);
            this.txt_class.TabIndex = 3;
            // 
            // lbl_class
            // 
            this.lbl_class.AutoSize = true;
            this.lbl_class.Font = new System.Drawing.Font("Monotype Corsiva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbl_class.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbl_class.Location = new System.Drawing.Point(17, 130);
            this.lbl_class.Name = "lbl_class";
            this.lbl_class.Size = new System.Drawing.Size(97, 39);
            this.lbl_class.TabIndex = 14;
            this.lbl_class.Text = "Class :";
            // 
            // txt_project
            // 
            this.txt_project.Font = new System.Drawing.Font("Century", 18F);
            this.txt_project.ForeColor = System.Drawing.Color.Blue;
            this.txt_project.Location = new System.Drawing.Point(337, 80);
            this.txt_project.Name = "txt_project";
            this.txt_project.Size = new System.Drawing.Size(387, 36);
            this.txt_project.TabIndex = 2;
            // 
            // lbl_project
            // 
            this.lbl_project.AutoSize = true;
            this.lbl_project.Font = new System.Drawing.Font("Monotype Corsiva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbl_project.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbl_project.Location = new System.Drawing.Point(18, 76);
            this.lbl_project.Name = "lbl_project";
            this.lbl_project.Size = new System.Drawing.Size(120, 39);
            this.lbl_project.TabIndex = 12;
            this.lbl_project.Text = "Project :";
            // 
            // pan_addBug
            // 
            this.pan_addBug.BackColor = System.Drawing.Color.Khaki;
            this.pan_addBug.Controls.Add(this.txt_sourceCode);
            this.pan_addBug.Controls.Add(this.lbl_sourceCode);
            this.pan_addBug.Controls.Add(this.combo_year);
            this.pan_addBug.Controls.Add(this.combo_date);
            this.pan_addBug.Controls.Add(this.combo_month);
            this.pan_addBug.Controls.Add(this.lbl_date);
            this.pan_addBug.Controls.Add(this.txt_method);
            this.pan_addBug.Controls.Add(this.btn_cancel);
            this.pan_addBug.Controls.Add(this.btn_add);
            this.pan_addBug.Controls.Add(this.txt_codeAuthor);
            this.pan_addBug.Controls.Add(this.lbl_codeAuthor);
            this.pan_addBug.Controls.Add(this.txt_lineNo);
            this.pan_addBug.Controls.Add(this.lbl_lineNo);
            this.pan_addBug.Controls.Add(this.lbl_method);
            this.pan_addBug.Controls.Add(this.txt_class);
            this.pan_addBug.Controls.Add(this.lbl_class);
            this.pan_addBug.Controls.Add(this.txt_project);
            this.pan_addBug.Controls.Add(this.lbl_project);
            this.pan_addBug.Location = new System.Drawing.Point(29, -46);
            this.pan_addBug.Name = "pan_addBug";
            this.pan_addBug.Size = new System.Drawing.Size(730, 696);
            this.pan_addBug.TabIndex = 3;
            this.pan_addBug.Paint += new System.Windows.Forms.PaintEventHandler(this.pan_addBug_Paint);
            // 
            // AddNewBugs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(806, 605);
            this.Controls.Add(this.pan_addBug);
            this.Name = "AddNewBugs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddNewBugs";
            this.pan_addBug.ResumeLayout(false);
            this.pan_addBug.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_sourceCode;
        private System.Windows.Forms.Label lbl_sourceCode;
        private System.Windows.Forms.ComboBox combo_year;
        private System.Windows.Forms.ComboBox combo_date;
        private System.Windows.Forms.ComboBox combo_month;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.TextBox txt_method;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TextBox txt_codeAuthor;
        private System.Windows.Forms.Label lbl_codeAuthor;
        private System.Windows.Forms.TextBox txt_lineNo;
        private System.Windows.Forms.Label lbl_lineNo;
        private System.Windows.Forms.Label lbl_method;
        private System.Windows.Forms.TextBox txt_class;
        private System.Windows.Forms.Label lbl_class;
        private System.Windows.Forms.TextBox txt_project;
        private System.Windows.Forms.Label lbl_project;
        private System.Windows.Forms.Panel pan_addBug;
    }
}