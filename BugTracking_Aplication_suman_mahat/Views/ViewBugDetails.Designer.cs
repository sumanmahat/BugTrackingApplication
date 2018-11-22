namespace BugTracking_Aplication_suman_mahat.Views
{
    partial class ViewBugDetails
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
            this.txt_endlinenub = new System.Windows.Forms.TextBox();
            this.lbl_endline = new System.Windows.Forms.Label();
            this.txt_solutionCode = new System.Windows.Forms.RichTextBox();
            this.txt_sourceCode = new System.Windows.Forms.RichTextBox();
            this.pictureBox_bug = new System.Windows.Forms.PictureBox();
            this.combo_fixDate = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_solutionCode = new System.Windows.Forms.Label();
            this.combo_fixYear = new System.Windows.Forms.ComboBox();
            this.combo_fixMonth = new System.Windows.Forms.ComboBox();
            this.lbl_fixDate = new System.Windows.Forms.Label();
            this.txt_solver = new System.Windows.Forms.TextBox();
            this.lbl_fixerEmail = new System.Windows.Forms.Label();
            this.combo_year = new System.Windows.Forms.ComboBox();
            this.combo_date = new System.Windows.Forms.ComboBox();
            this.combo_month = new System.Windows.Forms.ComboBox();
            this.txt_addedEmail = new System.Windows.Forms.TextBox();
            this.lbl_addedEmail = new System.Windows.Forms.Label();
            this.combo_status = new System.Windows.Forms.ComboBox();
            this.lbl_status = new System.Windows.Forms.Label();
            this.lbl_sourceCode = new System.Windows.Forms.Label();
            this.lbl_date = new System.Windows.Forms.Label();
            this.txt_method = new System.Windows.Forms.TextBox();
            this.txt_codeAuthor = new System.Windows.Forms.TextBox();
            this.lbl_codeAuthor = new System.Windows.Forms.Label();
            this.txt_lineNo = new System.Windows.Forms.TextBox();
            this.lbl_lineNo = new System.Windows.Forms.Label();
            this.lbl_method = new System.Windows.Forms.Label();
            this.txt_class = new System.Windows.Forms.TextBox();
            this.lbl_class = new System.Windows.Forms.Label();
            this.txt_project = new System.Windows.Forms.TextBox();
            this.lbl_project = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_bug)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_endlinenub
            // 
            this.txt_endlinenub.Font = new System.Drawing.Font("Century", 18F);
            this.txt_endlinenub.ForeColor = System.Drawing.Color.Red;
            this.txt_endlinenub.Location = new System.Drawing.Point(350, 249);
            this.txt_endlinenub.Name = "txt_endlinenub";
            this.txt_endlinenub.ReadOnly = true;
            this.txt_endlinenub.Size = new System.Drawing.Size(387, 36);
            this.txt_endlinenub.TabIndex = 119;
            // 
            // lbl_endline
            // 
            this.lbl_endline.AutoSize = true;
            this.lbl_endline.Font = new System.Drawing.Font("Arial", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_endline.ForeColor = System.Drawing.Color.DarkCyan;
            this.lbl_endline.Location = new System.Drawing.Point(33, 249);
            this.lbl_endline.Name = "lbl_endline";
            this.lbl_endline.Size = new System.Drawing.Size(292, 36);
            this.lbl_endline.TabIndex = 118;
            this.lbl_endline.Text = "EndLine Number :";
            // 
            // txt_solutionCode
            // 
            this.txt_solutionCode.Font = new System.Drawing.Font("Consolas", 15.75F);
            this.txt_solutionCode.Location = new System.Drawing.Point(765, 514);
            this.txt_solutionCode.Name = "txt_solutionCode";
            this.txt_solutionCode.ReadOnly = true;
            this.txt_solutionCode.Size = new System.Drawing.Size(387, 133);
            this.txt_solutionCode.TabIndex = 117;
            this.txt_solutionCode.Text = "";
            // 
            // txt_sourceCode
            // 
            this.txt_sourceCode.Font = new System.Drawing.Font("Consolas", 15.75F);
            this.txt_sourceCode.Location = new System.Drawing.Point(350, 382);
            this.txt_sourceCode.Name = "txt_sourceCode";
            this.txt_sourceCode.ReadOnly = true;
            this.txt_sourceCode.Size = new System.Drawing.Size(387, 126);
            this.txt_sourceCode.TabIndex = 116;
            this.txt_sourceCode.Text = "";
            // 
            // pictureBox_bug
            // 
            this.pictureBox_bug.BackColor = System.Drawing.Color.White;
            this.pictureBox_bug.Location = new System.Drawing.Point(756, 123);
            this.pictureBox_bug.Name = "pictureBox_bug";
            this.pictureBox_bug.Size = new System.Drawing.Size(396, 321);
            this.pictureBox_bug.TabIndex = 115;
            this.pictureBox_bug.TabStop = false;
            // 
            // combo_fixDate
            // 
            this.combo_fixDate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.combo_fixDate.Font = new System.Drawing.Font("Century", 18F);
            this.combo_fixDate.ForeColor = System.Drawing.Color.Black;
            this.combo_fixDate.FormattingEnabled = true;
            this.combo_fixDate.Items.AddRange(new object[] {
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
            this.combo_fixDate.Location = new System.Drawing.Point(571, 651);
            this.combo_fixDate.Name = "combo_fixDate";
            this.combo_fixDate.Size = new System.Drawing.Size(86, 36);
            this.combo_fixDate.TabIndex = 114;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(768, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 36);
            this.label1.TabIndex = 113;
            this.label1.Text = "Snap Shot : ";
            // 
            // lbl_solutionCode
            // 
            this.lbl_solutionCode.AutoSize = true;
            this.lbl_solutionCode.Font = new System.Drawing.Font("Arial", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_solutionCode.ForeColor = System.Drawing.Color.DarkCyan;
            this.lbl_solutionCode.Location = new System.Drawing.Point(759, 465);
            this.lbl_solutionCode.Name = "lbl_solutionCode";
            this.lbl_solutionCode.Size = new System.Drawing.Size(263, 36);
            this.lbl_solutionCode.TabIndex = 110;
            this.lbl_solutionCode.Text = "Solution Code : ";
            // 
            // combo_fixYear
            // 
            this.combo_fixYear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.combo_fixYear.Font = new System.Drawing.Font("Century", 18F);
            this.combo_fixYear.ForeColor = System.Drawing.Color.Black;
            this.combo_fixYear.FormattingEnabled = true;
            this.combo_fixYear.Items.AddRange(new object[] {
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
            this.combo_fixYear.Location = new System.Drawing.Point(351, 654);
            this.combo_fixYear.Name = "combo_fixYear";
            this.combo_fixYear.Size = new System.Drawing.Size(86, 36);
            this.combo_fixYear.TabIndex = 106;
            // 
            // combo_fixMonth
            // 
            this.combo_fixMonth.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.combo_fixMonth.Font = new System.Drawing.Font("Century", 18F);
            this.combo_fixMonth.ForeColor = System.Drawing.Color.Black;
            this.combo_fixMonth.FormattingEnabled = true;
            this.combo_fixMonth.Items.AddRange(new object[] {
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
            this.combo_fixMonth.Location = new System.Drawing.Point(465, 654);
            this.combo_fixMonth.Name = "combo_fixMonth";
            this.combo_fixMonth.Size = new System.Drawing.Size(86, 36);
            this.combo_fixMonth.TabIndex = 107;
            // 
            // lbl_fixDate
            // 
            this.lbl_fixDate.AutoSize = true;
            this.lbl_fixDate.Font = new System.Drawing.Font("Arial", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fixDate.ForeColor = System.Drawing.Color.DarkCyan;
            this.lbl_fixDate.Location = new System.Drawing.Point(32, 651);
            this.lbl_fixDate.Name = "lbl_fixDate";
            this.lbl_fixDate.Size = new System.Drawing.Size(199, 36);
            this.lbl_fixDate.TabIndex = 109;
            this.lbl_fixDate.Text = "Fixed Date :";
            // 
            // txt_solver
            // 
            this.txt_solver.Enabled = false;
            this.txt_solver.Font = new System.Drawing.Font("Century", 18F);
            this.txt_solver.ForeColor = System.Drawing.Color.Black;
            this.txt_solver.Location = new System.Drawing.Point(351, 610);
            this.txt_solver.Name = "txt_solver";
            this.txt_solver.Size = new System.Drawing.Size(387, 36);
            this.txt_solver.TabIndex = 105;
            // 
            // lbl_fixerEmail
            // 
            this.lbl_fixerEmail.AutoSize = true;
            this.lbl_fixerEmail.Font = new System.Drawing.Font("Arial", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fixerEmail.ForeColor = System.Drawing.Color.DarkCyan;
            this.lbl_fixerEmail.Location = new System.Drawing.Point(32, 607);
            this.lbl_fixerEmail.Name = "lbl_fixerEmail";
            this.lbl_fixerEmail.Size = new System.Drawing.Size(206, 36);
            this.lbl_fixerEmail.TabIndex = 108;
            this.lbl_fixerEmail.Text = "Solver Email";
            // 
            // combo_year
            // 
            this.combo_year.Enabled = false;
            this.combo_year.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.combo_year.Font = new System.Drawing.Font("Century", 18F);
            this.combo_year.ForeColor = System.Drawing.Color.Black;
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
            this.combo_year.Location = new System.Drawing.Point(351, 340);
            this.combo_year.Name = "combo_year";
            this.combo_year.Size = new System.Drawing.Size(86, 36);
            this.combo_year.TabIndex = 91;
            // 
            // combo_date
            // 
            this.combo_date.Enabled = false;
            this.combo_date.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.combo_date.Font = new System.Drawing.Font("Century", 18F);
            this.combo_date.ForeColor = System.Drawing.Color.Black;
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
            this.combo_date.Location = new System.Drawing.Point(571, 340);
            this.combo_date.Name = "combo_date";
            this.combo_date.Size = new System.Drawing.Size(86, 36);
            this.combo_date.TabIndex = 93;
            // 
            // combo_month
            // 
            this.combo_month.Enabled = false;
            this.combo_month.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.combo_month.Font = new System.Drawing.Font("Century", 18F);
            this.combo_month.ForeColor = System.Drawing.Color.Black;
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
            this.combo_month.Location = new System.Drawing.Point(465, 340);
            this.combo_month.Name = "combo_month";
            this.combo_month.Size = new System.Drawing.Size(86, 36);
            this.combo_month.TabIndex = 92;
            // 
            // txt_addedEmail
            // 
            this.txt_addedEmail.Enabled = false;
            this.txt_addedEmail.Font = new System.Drawing.Font("Century", 18F);
            this.txt_addedEmail.ForeColor = System.Drawing.Color.Black;
            this.txt_addedEmail.Location = new System.Drawing.Point(351, 559);
            this.txt_addedEmail.Name = "txt_addedEmail";
            this.txt_addedEmail.Size = new System.Drawing.Size(387, 36);
            this.txt_addedEmail.TabIndex = 95;
            // 
            // lbl_addedEmail
            // 
            this.lbl_addedEmail.AutoSize = true;
            this.lbl_addedEmail.Font = new System.Drawing.Font("Arial", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_addedEmail.ForeColor = System.Drawing.Color.DarkCyan;
            this.lbl_addedEmail.Location = new System.Drawing.Point(32, 556);
            this.lbl_addedEmail.Name = "lbl_addedEmail";
            this.lbl_addedEmail.Size = new System.Drawing.Size(185, 36);
            this.lbl_addedEmail.TabIndex = 104;
            this.lbl_addedEmail.Text = "Added By :";
            // 
            // combo_status
            // 
            this.combo_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_status.Font = new System.Drawing.Font("Century", 18F);
            this.combo_status.ForeColor = System.Drawing.Color.Blue;
            this.combo_status.FormattingEnabled = true;
            this.combo_status.Items.AddRange(new object[] {
            "Active",
            "Fixed"});
            this.combo_status.Location = new System.Drawing.Point(351, 514);
            this.combo_status.Name = "combo_status";
            this.combo_status.Size = new System.Drawing.Size(386, 36);
            this.combo_status.TabIndex = 94;
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Font = new System.Drawing.Font("Arial", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_status.ForeColor = System.Drawing.Color.DarkCyan;
            this.lbl_status.Location = new System.Drawing.Point(32, 507);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(133, 36);
            this.lbl_status.TabIndex = 103;
            this.lbl_status.Text = "Status :";
            // 
            // lbl_sourceCode
            // 
            this.lbl_sourceCode.AutoSize = true;
            this.lbl_sourceCode.Font = new System.Drawing.Font("Arial", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sourceCode.ForeColor = System.Drawing.Color.DarkCyan;
            this.lbl_sourceCode.Location = new System.Drawing.Point(33, 405);
            this.lbl_sourceCode.Name = "lbl_sourceCode";
            this.lbl_sourceCode.Size = new System.Drawing.Size(242, 36);
            this.lbl_sourceCode.TabIndex = 102;
            this.lbl_sourceCode.Text = "Source Code : ";
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Font = new System.Drawing.Font("Arial", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_date.ForeColor = System.Drawing.Color.DarkCyan;
            this.lbl_date.Location = new System.Drawing.Point(33, 339);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(105, 36);
            this.lbl_date.TabIndex = 101;
            this.lbl_date.Text = "Date :";
            // 
            // txt_method
            // 
            this.txt_method.Font = new System.Drawing.Font("Century", 18F);
            this.txt_method.ForeColor = System.Drawing.Color.Black;
            this.txt_method.Location = new System.Drawing.Point(352, 165);
            this.txt_method.Name = "txt_method";
            this.txt_method.ReadOnly = true;
            this.txt_method.Size = new System.Drawing.Size(387, 36);
            this.txt_method.TabIndex = 88;
            // 
            // txt_codeAuthor
            // 
            this.txt_codeAuthor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_codeAuthor.Enabled = false;
            this.txt_codeAuthor.Font = new System.Drawing.Font("Century", 18F);
            this.txt_codeAuthor.ForeColor = System.Drawing.Color.Black;
            this.txt_codeAuthor.Location = new System.Drawing.Point(352, 298);
            this.txt_codeAuthor.Name = "txt_codeAuthor";
            this.txt_codeAuthor.ReadOnly = true;
            this.txt_codeAuthor.Size = new System.Drawing.Size(387, 36);
            this.txt_codeAuthor.TabIndex = 90;
            // 
            // lbl_codeAuthor
            // 
            this.lbl_codeAuthor.AutoSize = true;
            this.lbl_codeAuthor.Font = new System.Drawing.Font("Arial", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_codeAuthor.ForeColor = System.Drawing.Color.DarkCyan;
            this.lbl_codeAuthor.Location = new System.Drawing.Point(33, 295);
            this.lbl_codeAuthor.Name = "lbl_codeAuthor";
            this.lbl_codeAuthor.Size = new System.Drawing.Size(228, 36);
            this.lbl_codeAuthor.TabIndex = 100;
            this.lbl_codeAuthor.Text = "Code Author :";
            // 
            // txt_lineNo
            // 
            this.txt_lineNo.Font = new System.Drawing.Font("Century", 18F);
            this.txt_lineNo.ForeColor = System.Drawing.Color.Black;
            this.txt_lineNo.Location = new System.Drawing.Point(352, 207);
            this.txt_lineNo.Name = "txt_lineNo";
            this.txt_lineNo.ReadOnly = true;
            this.txt_lineNo.Size = new System.Drawing.Size(387, 36);
            this.txt_lineNo.TabIndex = 89;
            // 
            // lbl_lineNo
            // 
            this.lbl_lineNo.AutoSize = true;
            this.lbl_lineNo.Font = new System.Drawing.Font("Arial", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lineNo.ForeColor = System.Drawing.Color.DarkCyan;
            this.lbl_lineNo.Location = new System.Drawing.Point(33, 204);
            this.lbl_lineNo.Name = "lbl_lineNo";
            this.lbl_lineNo.Size = new System.Drawing.Size(304, 36);
            this.lbl_lineNo.TabIndex = 99;
            this.lbl_lineNo.Text = "StartLine Number :";
            // 
            // lbl_method
            // 
            this.lbl_method.AutoSize = true;
            this.lbl_method.Font = new System.Drawing.Font("Arial", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_method.ForeColor = System.Drawing.Color.DarkCyan;
            this.lbl_method.Location = new System.Drawing.Point(33, 162);
            this.lbl_method.Name = "lbl_method";
            this.lbl_method.Size = new System.Drawing.Size(151, 36);
            this.lbl_method.TabIndex = 98;
            this.lbl_method.Text = "Method :";
            // 
            // txt_class
            // 
            this.txt_class.Font = new System.Drawing.Font("Century", 18F);
            this.txt_class.ForeColor = System.Drawing.Color.Black;
            this.txt_class.Location = new System.Drawing.Point(352, 123);
            this.txt_class.Name = "txt_class";
            this.txt_class.ReadOnly = true;
            this.txt_class.Size = new System.Drawing.Size(387, 36);
            this.txt_class.TabIndex = 87;
            // 
            // lbl_class
            // 
            this.lbl_class.AutoSize = true;
            this.lbl_class.Font = new System.Drawing.Font("Arial", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_class.ForeColor = System.Drawing.Color.DarkCyan;
            this.lbl_class.Location = new System.Drawing.Point(33, 120);
            this.lbl_class.Name = "lbl_class";
            this.lbl_class.Size = new System.Drawing.Size(121, 36);
            this.lbl_class.TabIndex = 97;
            this.lbl_class.Text = "Class :";
            // 
            // txt_project
            // 
            this.txt_project.Font = new System.Drawing.Font("Century", 18F);
            this.txt_project.ForeColor = System.Drawing.Color.Black;
            this.txt_project.Location = new System.Drawing.Point(352, 81);
            this.txt_project.Name = "txt_project";
            this.txt_project.ReadOnly = true;
            this.txt_project.Size = new System.Drawing.Size(387, 36);
            this.txt_project.TabIndex = 86;
            // 
            // lbl_project
            // 
            this.lbl_project.AutoSize = true;
            this.lbl_project.Font = new System.Drawing.Font("Arial", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_project.ForeColor = System.Drawing.Color.DarkCyan;
            this.lbl_project.Location = new System.Drawing.Point(33, 78);
            this.lbl_project.Name = "lbl_project";
            this.lbl_project.Size = new System.Drawing.Size(144, 36);
            this.lbl_project.TabIndex = 96;
            this.lbl_project.Text = "Project :";
            // 
            // ViewBugDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 703);
            this.Controls.Add(this.txt_endlinenub);
            this.Controls.Add(this.lbl_endline);
            this.Controls.Add(this.txt_solutionCode);
            this.Controls.Add(this.txt_sourceCode);
            this.Controls.Add(this.pictureBox_bug);
            this.Controls.Add(this.combo_fixDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_solutionCode);
            this.Controls.Add(this.combo_fixYear);
            this.Controls.Add(this.combo_fixMonth);
            this.Controls.Add(this.lbl_fixDate);
            this.Controls.Add(this.txt_solver);
            this.Controls.Add(this.lbl_fixerEmail);
            this.Controls.Add(this.combo_year);
            this.Controls.Add(this.combo_date);
            this.Controls.Add(this.combo_month);
            this.Controls.Add(this.txt_addedEmail);
            this.Controls.Add(this.lbl_addedEmail);
            this.Controls.Add(this.combo_status);
            this.Controls.Add(this.lbl_status);
            this.Controls.Add(this.lbl_sourceCode);
            this.Controls.Add(this.lbl_date);
            this.Controls.Add(this.txt_method);
            this.Controls.Add(this.txt_codeAuthor);
            this.Controls.Add(this.lbl_codeAuthor);
            this.Controls.Add(this.txt_lineNo);
            this.Controls.Add(this.lbl_lineNo);
            this.Controls.Add(this.lbl_method);
            this.Controls.Add(this.txt_class);
            this.Controls.Add(this.lbl_class);
            this.Controls.Add(this.txt_project);
            this.Controls.Add(this.lbl_project);
            this.Name = "ViewBugDetails";
            this.Text = "ViewBugDetails";
            this.Load += new System.EventHandler(this.ViewBugDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_bug)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_endlinenub;
        private System.Windows.Forms.Label lbl_endline;
        private System.Windows.Forms.RichTextBox txt_solutionCode;
        private System.Windows.Forms.RichTextBox txt_sourceCode;
        private System.Windows.Forms.PictureBox pictureBox_bug;
        private System.Windows.Forms.ComboBox combo_fixDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_solutionCode;
        private System.Windows.Forms.ComboBox combo_fixYear;
        private System.Windows.Forms.ComboBox combo_fixMonth;
        private System.Windows.Forms.Label lbl_fixDate;
        private System.Windows.Forms.TextBox txt_solver;
        private System.Windows.Forms.Label lbl_fixerEmail;
        private System.Windows.Forms.ComboBox combo_year;
        private System.Windows.Forms.ComboBox combo_date;
        private System.Windows.Forms.ComboBox combo_month;
        private System.Windows.Forms.TextBox txt_addedEmail;
        private System.Windows.Forms.Label lbl_addedEmail;
        private System.Windows.Forms.ComboBox combo_status;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.Label lbl_sourceCode;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.TextBox txt_method;
        private System.Windows.Forms.TextBox txt_codeAuthor;
        private System.Windows.Forms.Label lbl_codeAuthor;
        private System.Windows.Forms.TextBox txt_lineNo;
        private System.Windows.Forms.Label lbl_lineNo;
        private System.Windows.Forms.Label lbl_method;
        private System.Windows.Forms.TextBox txt_class;
        private System.Windows.Forms.Label lbl_class;
        private System.Windows.Forms.TextBox txt_project;
        private System.Windows.Forms.Label lbl_project;
    }
}