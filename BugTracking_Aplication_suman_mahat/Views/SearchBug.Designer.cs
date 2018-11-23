namespace BugTracking_Aplication_suman_mahat.Views
{
    partial class SearchBug
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
            this.txt_search = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_solution = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(156, 79);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(220, 20);
            this.txt_search.TabIndex = 0;
            this.txt_search.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(40, 113);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(618, 293);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btn_solution
            // 
            this.btn_solution.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_solution.ForeColor = System.Drawing.Color.Black;
            this.btn_solution.Location = new System.Drawing.Point(40, 431);
            this.btn_solution.Name = "btn_solution";
            this.btn_solution.Size = new System.Drawing.Size(217, 36);
            this.btn_solution.TabIndex = 2;
            this.btn_solution.Text = "View Bugs";
            this.btn_solution.UseVisualStyleBackColor = true;
            this.btn_solution.Click += new System.EventHandler(this.btn_solution_Click);
            // 
            // Search
            // 
            this.Search.AutoSize = true;
            this.Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.Location = new System.Drawing.Point(37, 79);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(95, 16);
            this.Search.TabIndex = 3;
            this.Search.Text = "Search Here";
            // 
            // SearchBug
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 479);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.btn_solution);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_search);
            this.Name = "SearchBug";
            this.Text = "SearchBug";
            this.Load += new System.EventHandler(this.SearchBug_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_solution;
        private System.Windows.Forms.Label Search;
    }
}