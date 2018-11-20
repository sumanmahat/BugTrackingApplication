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
            this.txt_sourceCode = new System.Windows.Forms.RichTextBox();
            this.lbl_path = new System.Windows.Forms.Label();
            this.btn_open = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_endlinenub = new System.Windows.Forms.TextBox();
            this.pan_addBug.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_sourceCode
            // 
            this.lbl_sourceCode.AutoSize = true;
            this.lbl_sourceCode.Font = new System.Drawing.Font("Arial", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sourceCode.ForeColor = System.Drawing.Color.DarkCyan;
            this.lbl_sourceCode.Location = new System.Drawing.Point(776, 34);
            this.lbl_sourceCode.Name = "lbl_sourceCode";
            this.lbl_sourceCode.Size = new System.Drawing.Size(213, 36);
            this.lbl_sourceCode.TabIndex = 35;
            this.lbl_sourceCode.Text = "Source Code";
            // 
            // combo_year
            // 
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
            this.combo_year.Location = new System.Drawing.Point(339, 393);
            this.combo_year.Name = "combo_year";
            this.combo_year.Size = new System.Drawing.Size(86, 36);
            this.combo_year.TabIndex = 7;
            // 
            // combo_date
            // 
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
            this.combo_date.Location = new System.Drawing.Point(559, 393);
            this.combo_date.Name = "combo_date";
            this.combo_date.Size = new System.Drawing.Size(86, 36);
            this.combo_date.TabIndex = 9;
            // 
            // combo_month
            // 
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
            this.combo_month.Location = new System.Drawing.Point(453, 393);
            this.combo_month.Name = "combo_month";
            this.combo_month.Size = new System.Drawing.Size(86, 36);
            this.combo_month.TabIndex = 8;
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Font = new System.Drawing.Font("Arial", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_date.ForeColor = System.Drawing.Color.DarkCyan;
            this.lbl_date.Location = new System.Drawing.Point(18, 390);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(96, 36);
            this.lbl_date.TabIndex = 22;
            this.lbl_date.Text = "Date:";
            // 
            // txt_method
            // 
            this.txt_method.Font = new System.Drawing.Font("Century", 18F);
            this.txt_method.ForeColor = System.Drawing.Color.Black;
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
            this.btn_cancel.Location = new System.Drawing.Point(414, 559);
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
            this.btn_add.Location = new System.Drawing.Point(106, 559);
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
            this.txt_codeAuthor.ForeColor = System.Drawing.Color.Black;
            this.txt_codeAuthor.Location = new System.Drawing.Point(337, 337);
            this.txt_codeAuthor.Name = "txt_codeAuthor";
            this.txt_codeAuthor.Size = new System.Drawing.Size(292, 36);
            this.txt_codeAuthor.TabIndex = 6;
            // 
            // lbl_codeAuthor
            // 
            this.lbl_codeAuthor.AutoSize = true;
            this.lbl_codeAuthor.Font = new System.Drawing.Font("Arial", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_codeAuthor.ForeColor = System.Drawing.Color.DarkCyan;
            this.lbl_codeAuthor.Location = new System.Drawing.Point(20, 337);
            this.lbl_codeAuthor.Name = "lbl_codeAuthor";
            this.lbl_codeAuthor.Size = new System.Drawing.Size(228, 36);
            this.lbl_codeAuthor.TabIndex = 20;
            this.lbl_codeAuthor.Text = "Code Author :";
            // 
            // txt_lineNo
            // 
            this.txt_lineNo.Font = new System.Drawing.Font("Century", 18F);
            this.txt_lineNo.ForeColor = System.Drawing.Color.Black;
            this.txt_lineNo.Location = new System.Drawing.Point(337, 239);
            this.txt_lineNo.Name = "txt_lineNo";
            this.txt_lineNo.Size = new System.Drawing.Size(387, 36);
            this.txt_lineNo.TabIndex = 5;
            // 
            // lbl_lineNo
            // 
            this.lbl_lineNo.AutoSize = true;
            this.lbl_lineNo.Font = new System.Drawing.Font("Arial", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lineNo.ForeColor = System.Drawing.Color.DarkCyan;
            this.lbl_lineNo.Location = new System.Drawing.Point(17, 236);
            this.lbl_lineNo.Name = "lbl_lineNo";
            this.lbl_lineNo.Size = new System.Drawing.Size(304, 36);
            this.lbl_lineNo.TabIndex = 18;
            this.lbl_lineNo.Text = "StartLine Number :";
            // 
            // lbl_method
            // 
            this.lbl_method.AutoSize = true;
            this.lbl_method.Font = new System.Drawing.Font("Arial", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_method.ForeColor = System.Drawing.Color.DarkCyan;
            this.lbl_method.Location = new System.Drawing.Point(17, 184);
            this.lbl_method.Name = "lbl_method";
            this.lbl_method.Size = new System.Drawing.Size(151, 36);
            this.lbl_method.TabIndex = 16;
            this.lbl_method.Text = "Method :";
            // 
            // txt_class
            // 
            this.txt_class.Font = new System.Drawing.Font("Century", 18F);
            this.txt_class.ForeColor = System.Drawing.Color.Black;
            this.txt_class.Location = new System.Drawing.Point(337, 133);
            this.txt_class.Name = "txt_class";
            this.txt_class.Size = new System.Drawing.Size(387, 36);
            this.txt_class.TabIndex = 3;
            // 
            // lbl_class
            // 
            this.lbl_class.AutoSize = true;
            this.lbl_class.Font = new System.Drawing.Font("Arial", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_class.ForeColor = System.Drawing.Color.DarkCyan;
            this.lbl_class.Location = new System.Drawing.Point(17, 130);
            this.lbl_class.Name = "lbl_class";
            this.lbl_class.Size = new System.Drawing.Size(121, 36);
            this.lbl_class.TabIndex = 14;
            this.lbl_class.Text = "Class :";
            // 
            // txt_project
            // 
            this.txt_project.Font = new System.Drawing.Font("Century", 18F);
            this.txt_project.ForeColor = System.Drawing.Color.Black;
            this.txt_project.Location = new System.Drawing.Point(337, 80);
            this.txt_project.Name = "txt_project";
            this.txt_project.Size = new System.Drawing.Size(387, 36);
            this.txt_project.TabIndex = 2;
            // 
            // lbl_project
            // 
            this.lbl_project.AutoSize = true;
            this.lbl_project.Font = new System.Drawing.Font("Arial", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_project.ForeColor = System.Drawing.Color.DarkCyan;
            this.lbl_project.Location = new System.Drawing.Point(18, 76);
            this.lbl_project.Name = "lbl_project";
            this.lbl_project.Size = new System.Drawing.Size(144, 36);
            this.lbl_project.TabIndex = 12;
            this.lbl_project.Text = "Project :";
            // 
            // pan_addBug
            // 
            this.pan_addBug.BackColor = System.Drawing.SystemColors.Control;
            this.pan_addBug.Controls.Add(this.txt_endlinenub);
            this.pan_addBug.Controls.Add(this.label2);
            this.pan_addBug.Controls.Add(this.lbl_path);
            this.pan_addBug.Controls.Add(this.btn_open);
            this.pan_addBug.Controls.Add(this.label1);
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
            // txt_sourceCode
            // 
            this.txt_sourceCode.Font = new System.Drawing.Font("Consolas", 15.75F);
            this.txt_sourceCode.Location = new System.Drawing.Point(765, 84);
            this.txt_sourceCode.Name = "txt_sourceCode";
            this.txt_sourceCode.Size = new System.Drawing.Size(380, 224);
            this.txt_sourceCode.TabIndex = 40;
            this.txt_sourceCode.Text = "";
            // 
            // lbl_path
            // 
            this.lbl_path.AutoSize = true;
            this.lbl_path.Location = new System.Drawing.Point(336, 549);
            this.lbl_path.Name = "lbl_path";
            this.lbl_path.Size = new System.Drawing.Size(0, 13);
            this.lbl_path.TabIndex = 39;
            // 
            // btn_open
            // 
            this.btn_open.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.btn_open.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btn_open.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_open.Location = new System.Drawing.Point(337, 472);
            this.btn_open.Name = "btn_open";
            this.btn_open.Size = new System.Drawing.Size(73, 36);
            this.btn_open.TabIndex = 38;
            this.btn_open.Text = "open";
            this.btn_open.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_open.UseVisualStyleBackColor = true;
            this.btn_open.Click += new System.EventHandler(this.btn_open_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(20, 472);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 36);
            this.label1.TabIndex = 36;
            this.label1.Text = "Code snap";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkCyan;
            this.label2.Location = new System.Drawing.Point(20, 291);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(292, 36);
            this.label2.TabIndex = 40;
            this.label2.Text = "EndLine Number :";
            // 
            // txt_endlinenub
            // 
            this.txt_endlinenub.Font = new System.Drawing.Font("Century", 18F);
            this.txt_endlinenub.ForeColor = System.Drawing.Color.Black;
            this.txt_endlinenub.Location = new System.Drawing.Point(337, 291);
            this.txt_endlinenub.Name = "txt_endlinenub";
            this.txt_endlinenub.Size = new System.Drawing.Size(387, 36);
            this.txt_endlinenub.TabIndex = 41;
            // 
            // AddNewBugs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 596);
            this.Controls.Add(this.txt_sourceCode);
            this.Controls.Add(this.pan_addBug);
            this.Controls.Add(this.lbl_sourceCode);
            this.Name = "AddNewBugs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddNewBugs";
            this.pan_addBug.ResumeLayout(false);
            this.pan_addBug.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_open;
        private System.Windows.Forms.Label lbl_path;
        private System.Windows.Forms.RichTextBox txt_sourceCode;
        private System.Windows.Forms.TextBox txt_endlinenub;
        private System.Windows.Forms.Label label2;
    }
}