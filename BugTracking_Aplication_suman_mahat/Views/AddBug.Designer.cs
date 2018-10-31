namespace BugTracking_Aplication_suman_mahat.Views
{
    partial class AddBug
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
            this.combo_year = new System.Windows.Forms.ComboBox();
            this.combo_date = new System.Windows.Forms.ComboBox();
            this.combo_month = new System.Windows.Forms.ComboBox();
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
            this.txt_bugDescription = new System.Windows.Forms.TextBox();
            this.lbl_bugDescription = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_sourceCode
            // 
            this.txt_sourceCode.Font = new System.Drawing.Font("Century", 18F);
            this.txt_sourceCode.ForeColor = System.Drawing.Color.Red;
            this.txt_sourceCode.Location = new System.Drawing.Point(353, 457);
            this.txt_sourceCode.Multiline = true;
            this.txt_sourceCode.Name = "txt_sourceCode";
            this.txt_sourceCode.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_sourceCode.Size = new System.Drawing.Size(387, 117);
            this.txt_sourceCode.TabIndex = 45;
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
            this.combo_year.Location = new System.Drawing.Point(355, 406);
            this.combo_year.Name = "combo_year";
            this.combo_year.Size = new System.Drawing.Size(86, 36);
            this.combo_year.TabIndex = 42;
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
            this.combo_date.Location = new System.Drawing.Point(572, 486);
            this.combo_date.Name = "combo_date";
            this.combo_date.Size = new System.Drawing.Size(86, 36);
            this.combo_date.TabIndex = 44;
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
            this.combo_month.Location = new System.Drawing.Point(469, 406);
            this.combo_month.Name = "combo_month";
            this.combo_month.Size = new System.Drawing.Size(86, 36);
            this.combo_month.TabIndex = 43;
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Font = new System.Drawing.Font("Arial", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_date.ForeColor = System.Drawing.Color.DarkCyan;
            this.lbl_date.Location = new System.Drawing.Point(34, 403);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(96, 36);
            this.lbl_date.TabIndex = 51;
            this.lbl_date.Text = "Date:";
            // 
            // txt_method
            // 
            this.txt_method.Font = new System.Drawing.Font("Century", 18F);
            this.txt_method.ForeColor = System.Drawing.Color.Red;
            this.txt_method.Location = new System.Drawing.Point(353, 246);
            this.txt_method.Name = "txt_method";
            this.txt_method.Size = new System.Drawing.Size(387, 36);
            this.txt_method.TabIndex = 38;
            // 
            // txt_codeAuthor
            // 
            this.txt_codeAuthor.Font = new System.Drawing.Font("Century", 18F);
            this.txt_codeAuthor.ForeColor = System.Drawing.Color.Blue;
            this.txt_codeAuthor.Location = new System.Drawing.Point(353, 350);
            this.txt_codeAuthor.Name = "txt_codeAuthor";
            this.txt_codeAuthor.Size = new System.Drawing.Size(292, 36);
            this.txt_codeAuthor.TabIndex = 41;
            // 
            // lbl_codeAuthor
            // 
            this.lbl_codeAuthor.AutoSize = true;
            this.lbl_codeAuthor.Font = new System.Drawing.Font("Arial", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_codeAuthor.ForeColor = System.Drawing.Color.DarkCyan;
            this.lbl_codeAuthor.Location = new System.Drawing.Point(33, 347);
            this.lbl_codeAuthor.Name = "lbl_codeAuthor";
            this.lbl_codeAuthor.Size = new System.Drawing.Size(228, 36);
            this.lbl_codeAuthor.TabIndex = 50;
            this.lbl_codeAuthor.Text = "Code Author :";
            // 
            // txt_lineNo
            // 
            this.txt_lineNo.Font = new System.Drawing.Font("Century", 18F);
            this.txt_lineNo.ForeColor = System.Drawing.Color.Red;
            this.txt_lineNo.Location = new System.Drawing.Point(353, 298);
            this.txt_lineNo.Name = "txt_lineNo";
            this.txt_lineNo.Size = new System.Drawing.Size(387, 36);
            this.txt_lineNo.TabIndex = 39;
            // 
            // lbl_lineNo
            // 
            this.lbl_lineNo.AutoSize = true;
            this.lbl_lineNo.Font = new System.Drawing.Font("Arial", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lineNo.ForeColor = System.Drawing.Color.DarkCyan;
            this.lbl_lineNo.Location = new System.Drawing.Point(33, 295);
            this.lbl_lineNo.Name = "lbl_lineNo";
            this.lbl_lineNo.Size = new System.Drawing.Size(231, 36);
            this.lbl_lineNo.TabIndex = 49;
            this.lbl_lineNo.Text = "Line Number :";
            // 
            // lbl_method
            // 
            this.lbl_method.AutoSize = true;
            this.lbl_method.Font = new System.Drawing.Font("Arial", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_method.ForeColor = System.Drawing.Color.DarkCyan;
            this.lbl_method.Location = new System.Drawing.Point(33, 243);
            this.lbl_method.Name = "lbl_method";
            this.lbl_method.Size = new System.Drawing.Size(151, 36);
            this.lbl_method.TabIndex = 48;
            this.lbl_method.Text = "Method :";
            // 
            // txt_class
            // 
            this.txt_class.Font = new System.Drawing.Font("Century", 18F);
            this.txt_class.ForeColor = System.Drawing.Color.Red;
            this.txt_class.Location = new System.Drawing.Point(353, 192);
            this.txt_class.Name = "txt_class";
            this.txt_class.Size = new System.Drawing.Size(387, 36);
            this.txt_class.TabIndex = 37;
            // 
            // lbl_class
            // 
            this.lbl_class.AutoSize = true;
            this.lbl_class.Font = new System.Drawing.Font("Arial", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_class.ForeColor = System.Drawing.Color.DarkCyan;
            this.lbl_class.Location = new System.Drawing.Point(33, 189);
            this.lbl_class.Name = "lbl_class";
            this.lbl_class.Size = new System.Drawing.Size(121, 36);
            this.lbl_class.TabIndex = 47;
            this.lbl_class.Text = "Class :";
            // 
            // txt_project
            // 
            this.txt_project.Font = new System.Drawing.Font("Century", 18F);
            this.txt_project.ForeColor = System.Drawing.Color.Blue;
            this.txt_project.Location = new System.Drawing.Point(353, 139);
            this.txt_project.Name = "txt_project";
            this.txt_project.Size = new System.Drawing.Size(387, 36);
            this.txt_project.TabIndex = 36;
            // 
            // lbl_project
            // 
            this.lbl_project.AutoSize = true;
            this.lbl_project.Font = new System.Drawing.Font("Arial", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_project.ForeColor = System.Drawing.Color.DarkCyan;
            this.lbl_project.Location = new System.Drawing.Point(33, 136);
            this.lbl_project.Name = "lbl_project";
            this.lbl_project.Size = new System.Drawing.Size(144, 36);
            this.lbl_project.TabIndex = 46;
            this.lbl_project.Text = "Project :";
            // 
            // txt_bugDescription
            // 
            this.txt_bugDescription.Font = new System.Drawing.Font("Century", 18F);
            this.txt_bugDescription.ForeColor = System.Drawing.Color.Blue;
            this.txt_bugDescription.Location = new System.Drawing.Point(353, 12);
            this.txt_bugDescription.Multiline = true;
            this.txt_bugDescription.Name = "txt_bugDescription";
            this.txt_bugDescription.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_bugDescription.Size = new System.Drawing.Size(387, 117);
            this.txt_bugDescription.TabIndex = 35;
            // 
            // lbl_bugDescription
            // 
            this.lbl_bugDescription.AutoSize = true;
            this.lbl_bugDescription.Font = new System.Drawing.Font("Arial", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_bugDescription.ForeColor = System.Drawing.Color.DarkCyan;
            this.lbl_bugDescription.Location = new System.Drawing.Point(33, 53);
            this.lbl_bugDescription.Name = "lbl_bugDescription";
            this.lbl_bugDescription.Size = new System.Drawing.Size(284, 36);
            this.lbl_bugDescription.TabIndex = 40;
            this.lbl_bugDescription.Text = "Bug Description :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(34, 479);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 36);
            this.label1.TabIndex = 53;
            this.label1.Text = "Source Code:";
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.btn_add.ForeColor = System.Drawing.Color.DarkCyan;
            this.btn_add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_add.Location = new System.Drawing.Point(144, 647);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(62, 36);
            this.btn_add.TabIndex = 54;
            this.btn_add.Text = "Add";
            this.btn_add.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_add.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.button1.ForeColor = System.Drawing.Color.DarkCyan;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(411, 647);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 36);
            this.button1.TabIndex = 55;
            this.button1.Text = "Cancel";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // AddBug
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(765, 749);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_sourceCode);
            this.Controls.Add(this.combo_year);
            this.Controls.Add(this.combo_date);
            this.Controls.Add(this.combo_month);
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
            this.Controls.Add(this.txt_bugDescription);
            this.Controls.Add(this.lbl_bugDescription);
            this.Name = "AddBug";
            this.Text = "AddBug";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_sourceCode;
        private System.Windows.Forms.ComboBox combo_year;
        private System.Windows.Forms.ComboBox combo_date;
        private System.Windows.Forms.ComboBox combo_month;
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
        private System.Windows.Forms.TextBox txt_bugDescription;
        private System.Windows.Forms.Label lbl_bugDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button button1;
    }
}