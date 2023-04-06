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
            this.LinearSearchTextBox = new System.Windows.Forms.TextBox();
            this.searchStreamsLabel = new System.Windows.Forms.Label();
            this.bucketSortButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(38, 114);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(970, 400);
            this.dataGridView1.TabIndex = 0;
            // 
            // mainLabel
            // 
            this.mainLabel.AutoSize = true;
            this.mainLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainLabel.ForeColor = System.Drawing.Color.DarkOrchid;
            this.mainLabel.Location = new System.Drawing.Point(380, 42);
            this.mainLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mainLabel.Name = "mainLabel";
            this.mainLabel.Size = new System.Drawing.Size(296, 37);
            this.mainLabel.TabIndex = 1;
            this.mainLabel.Text = "Data about songs ";
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.Color.DarkOrchid;
            this.SearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchButton.ForeColor = System.Drawing.Color.White;
            this.SearchButton.Location = new System.Drawing.Point(1088, 212);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(256, 42);
            this.SearchButton.TabIndex = 2;
            this.SearchButton.Text = "Song Binary Search";
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchBwutton_Click);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SearchTextBox.Location = new System.Drawing.Point(1088, 155);
            this.SearchTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(322, 31);
            this.SearchTextBox.TabIndex = 3;
            // 
            // searchSongName
            // 
            this.searchSongName.AutoSize = true;
            this.searchSongName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchSongName.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.searchSongName.Location = new System.Drawing.Point(1083, 114);
            this.searchSongName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.searchSongName.Name = "searchSongName";
            this.searchSongName.Size = new System.Drawing.Size(353, 26);
            this.searchSongName.TabIndex = 4;
            this.searchSongName.Text = "Enter a name of song for search";
            // 
            // AddRowButton
            // 
            this.AddRowButton.Location = new System.Drawing.Point(38, 570);
            this.AddRowButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.AddRowButton.Name = "AddRowButton";
            this.AddRowButton.Size = new System.Drawing.Size(100, 50);
            this.AddRowButton.TabIndex = 5;
            this.AddRowButton.Text = "Add row";
            this.AddRowButton.UseVisualStyleBackColor = true;
            this.AddRowButton.Click += new System.EventHandler(this.AddRowButton_Click);
            // 
            // RemoveRowButton
            // 
            this.RemoveRowButton.Location = new System.Drawing.Point(183, 570);
            this.RemoveRowButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.RemoveRowButton.Name = "RemoveRowButton";
            this.RemoveRowButton.Size = new System.Drawing.Size(171, 50);
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
            this.JumpSearchButton.Location = new System.Drawing.Point(1088, 508);
            this.JumpSearchButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.JumpSearchButton.Name = "JumpSearchButton";
            this.JumpSearchButton.Size = new System.Drawing.Size(285, 42);
            this.JumpSearchButton.TabIndex = 8;
            this.JumpSearchButton.Text = "Streams Linear Search";
            this.JumpSearchButton.UseVisualStyleBackColor = false;
            // 
            // LinearSearchTextBox
            // 
            this.LinearSearchTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LinearSearchTextBox.Location = new System.Drawing.Point(1088, 456);
            this.LinearSearchTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.LinearSearchTextBox.Name = "LinearSearchTextBox";
            this.LinearSearchTextBox.Size = new System.Drawing.Size(322, 31);
            this.LinearSearchTextBox.TabIndex = 9;
            // 
            // searchStreamsLabel
            // 
            this.searchStreamsLabel.AutoSize = true;
            this.searchStreamsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchStreamsLabel.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.searchStreamsLabel.Location = new System.Drawing.Point(1083, 411);
            this.searchStreamsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.searchStreamsLabel.Name = "searchStreamsLabel";
            this.searchStreamsLabel.Size = new System.Drawing.Size(472, 26);
            this.searchStreamsLabel.TabIndex = 10;
            this.searchStreamsLabel.Text = "Enter a streams number for jump searching";
            // 
            // bucketSortButton
            // 
            this.bucketSortButton.Location = new System.Drawing.Point(738, 565);
            this.bucketSortButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bucketSortButton.Name = "bucketSortButton";
            this.bucketSortButton.Size = new System.Drawing.Size(270, 61);
            this.bucketSortButton.TabIndex = 11;
            this.bucketSortButton.Text = "BucketSortButton";
            this.bucketSortButton.UseVisualStyleBackColor = true;
            this.bucketSortButton.Click += new System.EventHandler(this.BucketSortButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(431, 565);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(270, 61);
            this.button1.TabIndex = 12;
            this.button1.Text = "StreamSortButton";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.StreamSortButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1924, 805);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bucketSortButton);
            this.Controls.Add(this.searchStreamsLabel);
            this.Controls.Add(this.LinearSearchTextBox);
            this.Controls.Add(this.JumpSearchButton);
            this.Controls.Add(this.RemoveRowButton);
            this.Controls.Add(this.AddRowButton);
            this.Controls.Add(this.searchSongName);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.mainLabel);
            this.Controls.Add(this.dataGridView1);
            this.ForeColor = System.Drawing.Color.DarkOrchid;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = " (";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button button1;

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label mainLabel;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Label searchSongName;
        private System.Windows.Forms.Button AddRowButton;
        private System.Windows.Forms.Button RemoveRowButton;
        private System.Windows.Forms.Button JumpSearchButton;
        private System.Windows.Forms.TextBox LinearSearchTextBox;
        private System.Windows.Forms.Label searchStreamsLabel;
        private System.Windows.Forms.Button bucketSortButton;
    }
}

