namespace CityInfoApp
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
            System.Windows.Forms.ColumnHeader columnHeader1;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.countryTextBox = new System.Windows.Forms.TextBox();
            this.aboutTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.CitylistView = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.countryRadioButton = new System.Windows.Forms.RadioButton();
            this.cityRadioButton = new System.Windows.Forms.RadioButton();
            this.searchButton = new System.Windows.Forms.Button();
            columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Serial No.";
            columnHeader1.Width = 59;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.countryTextBox);
            this.groupBox1.Controls.Add(this.aboutTextBox);
            this.groupBox1.Controls.Add(this.nameTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.saveButton);
            this.groupBox1.Location = new System.Drawing.Point(82, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(482, 165);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "City Information";
            // 
            // countryTextBox
            // 
            this.countryTextBox.Location = new System.Drawing.Point(179, 113);
            this.countryTextBox.Name = "countryTextBox";
            this.countryTextBox.Size = new System.Drawing.Size(183, 20);
            this.countryTextBox.TabIndex = 6;
            // 
            // aboutTextBox
            // 
            this.aboutTextBox.Location = new System.Drawing.Point(179, 41);
            this.aboutTextBox.Multiline = true;
            this.aboutTextBox.Name = "aboutTextBox";
            this.aboutTextBox.Size = new System.Drawing.Size(183, 57);
            this.aboutTextBox.TabIndex = 5;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(179, 15);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(183, 20);
            this.nameTextBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(119, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Country";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(127, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "About";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "City Name";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(391, 136);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 0;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.searchTextBox);
            this.groupBox2.Controls.Add(this.CitylistView);
            this.groupBox2.Controls.Add(this.countryRadioButton);
            this.groupBox2.Controls.Add(this.cityRadioButton);
            this.groupBox2.Controls.Add(this.searchButton);
            this.groupBox2.Location = new System.Drawing.Point(12, 183);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(618, 271);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(228, 28);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(222, 20);
            this.searchTextBox.TabIndex = 4;
            // 
            // CitylistView
            // 
            this.CitylistView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.CitylistView.FullRowSelect = true;
            this.CitylistView.GridLines = true;
            this.CitylistView.Location = new System.Drawing.Point(24, 83);
            this.CitylistView.Name = "CitylistView";
            this.CitylistView.Size = new System.Drawing.Size(547, 173);
            this.CitylistView.TabIndex = 3;
            this.CitylistView.UseCompatibleStateImageBehavior = false;
            this.CitylistView.View = System.Windows.Forms.View.Details;
            this.CitylistView.DoubleClick += new System.EventHandler(this.CitylistView_DoubleClick);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "City Name";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 128;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "About";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 282;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Country";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // countryRadioButton
            // 
            this.countryRadioButton.AutoSize = true;
            this.countryRadioButton.Location = new System.Drawing.Point(70, 45);
            this.countryRadioButton.Name = "countryRadioButton";
            this.countryRadioButton.Size = new System.Drawing.Size(115, 17);
            this.countryRadioButton.TabIndex = 2;
            this.countryRadioButton.Text = "Search by Country ";
            this.countryRadioButton.UseVisualStyleBackColor = true;
            this.countryRadioButton.CheckedChanged += new System.EventHandler(this.countryRadioButton_CheckedChanged);
            // 
            // cityRadioButton
            // 
            this.cityRadioButton.AutoSize = true;
            this.cityRadioButton.Location = new System.Drawing.Point(70, 19);
            this.cityRadioButton.Name = "cityRadioButton";
            this.cityRadioButton.Size = new System.Drawing.Size(93, 17);
            this.cityRadioButton.TabIndex = 1;
            this.cityRadioButton.Text = "Search by City";
            this.cityRadioButton.UseVisualStyleBackColor = true;
            this.cityRadioButton.CheckedChanged += new System.EventHandler(this.cityRadioButton_CheckedChanged);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(456, 28);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 0;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 466);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "City Information";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox countryTextBox;
        private System.Windows.Forms.TextBox aboutTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton countryRadioButton;
        private System.Windows.Forms.RadioButton cityRadioButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.ListView CitylistView;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TextBox searchTextBox;
    }
}

