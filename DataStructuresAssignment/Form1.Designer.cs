namespace DataStructuresAssignment
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mainLabel = new System.Windows.Forms.Label();
            this.SearchButton = new System.Windows.Forms.Button();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.searchSongName = new System.Windows.Forms.Label();
            this.AddRowButton = new System.Windows.Forms.Button();
            this.RemoveRowButton = new System.Windows.Forms.Button();
            this.JumpSearchButton = new System.Windows.Forms.Button();
            this.JumpSearchTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bucketSortButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(25, 73);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(647, 256);
            this.dataGridView1.TabIndex = 0;
            // 
            // mainLabel
            // 
            this.mainLabel.AutoSize = true;
            this.mainLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainLabel.ForeColor = System.Drawing.Color.DarkOrchid;
            this.mainLabel.Location = new System.Drawing.Point(253, 27);
            this.mainLabel.Name = "mainLabel";
            this.mainLabel.Size = new System.Drawing.Size(187, 25);
            this.mainLabel.TabIndex = 1;
            this.mainLabel.Text = "Data about songs ";
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.Color.DarkOrchid;
            this.SearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchButton.ForeColor = System.Drawing.Color.White;
            this.SearchButton.Location = new System.Drawing.Point(725, 136);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(171, 27);
            this.SearchButton.TabIndex = 2;
            this.SearchButton.Text = "Song Binary Search";
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchBwutton_Click);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SearchTextBox.Location = new System.Drawing.Point(725, 99);
            this.SearchTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(215, 22);
            this.SearchTextBox.TabIndex = 3;
            // 
            // searchSongName
            // 
            this.searchSongName.AutoSize = true;
            this.searchSongName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchSongName.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.searchSongName.Location = new System.Drawing.Point(722, 73);
            this.searchSongName.Name = "searchSongName";
            this.searchSongName.Size = new System.Drawing.Size(243, 17);
            this.searchSongName.TabIndex = 4;
            this.searchSongName.Text = "Enter a name of song for search";
            // 
            // AddRowButton
            // 
            this.AddRowButton.Location = new System.Drawing.Point(25, 365);
            this.AddRowButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddRowButton.Name = "AddRowButton";
            this.AddRowButton.Size = new System.Drawing.Size(67, 32);
            this.AddRowButton.TabIndex = 5;
            this.AddRowButton.Text = "Add row";
            this.AddRowButton.UseVisualStyleBackColor = true;
            this.AddRowButton.Click += new System.EventHandler(this.AddRowButton_Click);
            // 
            // RemoveRowButton
            // 
            this.RemoveRowButton.Location = new System.Drawing.Point(122, 365);
            this.RemoveRowButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RemoveRowButton.Name = "RemoveRowButton";
            this.RemoveRowButton.Size = new System.Drawing.Size(114, 32);
            this.RemoveRowButton.TabIndex = 6;
            this.RemoveRowButton.Text = "Remove row";
            this.RemoveRowButton.UseVisualStyleBackColor = true;
            this.RemoveRowButton.Click += new System.EventHandler(this.RemoveRowButton_Click);
            // 
            // JumpSearchButton
            // 
            this.JumpSearchButton.BackColor = System.Drawing.Color.DarkOrchid;
            this.JumpSearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JumpSearchButton.ForeColor = System.Drawing.Color.White;
            this.JumpSearchButton.Location = new System.Drawing.Point(725, 325);
            this.JumpSearchButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.JumpSearchButton.Name = "JumpSearchButton";
            this.JumpSearchButton.Size = new System.Drawing.Size(171, 27);
            this.JumpSearchButton.TabIndex = 8;
            this.JumpSearchButton.Text = "Jump Search\r\n";
            this.JumpSearchButton.UseVisualStyleBackColor = false;
            this.JumpSearchButton.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // JumpSearchTextBox
            // 
            this.JumpSearchTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.JumpSearchTextBox.Location = new System.Drawing.Point(725, 292);
            this.JumpSearchTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.JumpSearchTextBox.Name = "JumpSearchTextBox";
            this.JumpSearchTextBox.Size = new System.Drawing.Size(215, 22);
            this.JumpSearchTextBox.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label1.Location = new System.Drawing.Point(722, 263);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Enter a streams number for jump searching";
            // 
            // bucketSortButton
            // 
            this.bucketSortButton.Location = new System.Drawing.Point(725, 211);
            this.bucketSortButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bucketSortButton.Name = "bucketSortButton";
            this.bucketSortButton.Size = new System.Drawing.Size(180, 39);
            this.bucketSortButton.TabIndex = 11;
            this.bucketSortButton.Text = "BucketSortButton";
            this.bucketSortButton.UseVisualStyleBackColor = true;
            this.bucketSortButton.Click += new System.EventHandler(this.BucketSortButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1283, 515);
            this.Controls.Add(this.bucketSortButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.JumpSearchTextBox);
            this.Controls.Add(this.JumpSearchButton);
            this.Controls.Add(this.RemoveRowButton);
            this.Controls.Add(this.AddRowButton);
            this.Controls.Add(this.searchSongName);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.mainLabel);
            this.Controls.Add(this.dataGridView1);
            this.ForeColor = System.Drawing.Color.DarkOrchid;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Home page ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label mainLabel;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Label searchSongName;
        private System.Windows.Forms.Button AddRowButton;
        private System.Windows.Forms.Button RemoveRowButton;
        private System.Windows.Forms.Button HashSearchButton;
        private System.Windows.Forms.TextBox HashSsearchTextBox;
        private System.Windows.Forms.Button JumpSearchButton;
        private System.Windows.Forms.TextBox JumpSearchTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bucketSortButton;
    }
}

