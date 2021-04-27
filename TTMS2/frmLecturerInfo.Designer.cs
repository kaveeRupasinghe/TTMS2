
namespace TTMS2
{
    partial class frmLecturerInfo
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
            this.components = new System.ComponentModel.Container();
            this.txtEmpID = new System.Windows.Forms.TextBox();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboDep = new System.Windows.Forms.ComboBox();
            this.comboFac = new System.Windows.Forms.ComboBox();
            this.comboCen = new System.Windows.Forms.ComboBox();
            this.comboBuild = new System.Windows.Forms.ComboBox();
            this.comboLevel = new System.Windows.Forms.ComboBox();
            this.numericRank = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.lecturerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numericRank)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lecturerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEmpID
            // 
            this.txtEmpID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lecturerBindingSource, "EmployeeID", true));
            this.txtEmpID.Location = new System.Drawing.Point(192, 173);
            this.txtEmpID.Name = "txtEmpID";
            this.txtEmpID.Size = new System.Drawing.Size(193, 22);
            this.txtEmpID.TabIndex = 8;
            // 
            // txtLName
            // 
            this.txtLName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lecturerBindingSource, "LecturerName", true));
            this.txtLName.Location = new System.Drawing.Point(192, 119);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(193, 22);
            this.txtLName.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 295);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Department";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Faculty";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Employee ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Lecturer Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(466, 295);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Rank";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(466, 235);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Level";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(466, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Building ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(466, 119);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 17);
            this.label8.TabIndex = 13;
            this.label8.Text = "Center";
            // 
            // comboDep
            // 
            this.comboDep.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.lecturerBindingSource, "Department", true));
            this.comboDep.FormattingEnabled = true;
            this.comboDep.Items.AddRange(new object[] {
            "Information Technology",
            "Software Engineering",
            "Data Science",
            "Cyber Security",
            "interactive Media",
            "Information System Engineering",
            "CSNE",
            "Management",
            "Accounting",
            "Financial",
            "Civil",
            "Chemical",
            "Electrical",
            "Mechanical"});
            this.comboDep.Location = new System.Drawing.Point(192, 288);
            this.comboDep.Name = "comboDep";
            this.comboDep.Size = new System.Drawing.Size(193, 24);
            this.comboDep.TabIndex = 18;
            // 
            // comboFac
            // 
            this.comboFac.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.lecturerBindingSource, "Faculty", true));
            this.comboFac.FormattingEnabled = true;
            this.comboFac.Items.AddRange(new object[] {
            "Faculty of Computing",
            "Faculty of Engineering",
            "Faculty of Business",
            "Faculty of Medicine",
            "Faculty of Law"});
            this.comboFac.Location = new System.Drawing.Point(192, 232);
            this.comboFac.Name = "comboFac";
            this.comboFac.Size = new System.Drawing.Size(193, 24);
            this.comboFac.TabIndex = 19;
            // 
            // comboCen
            // 
            this.comboCen.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.lecturerBindingSource, "Center", true));
            this.comboCen.FormattingEnabled = true;
            this.comboCen.Items.AddRange(new object[] {
            "Malabe",
            "Metro",
            "Matara",
            "Kandy",
            "Jaffna",
            "Kurunegala"});
            this.comboCen.Location = new System.Drawing.Point(562, 119);
            this.comboCen.Name = "comboCen";
            this.comboCen.Size = new System.Drawing.Size(193, 24);
            this.comboCen.TabIndex = 21;
            // 
            // comboBuild
            // 
            this.comboBuild.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.lecturerBindingSource, "Building", true));
            this.comboBuild.FormattingEnabled = true;
            this.comboBuild.Items.AddRange(new object[] {
            "B001"});
            this.comboBuild.Location = new System.Drawing.Point(562, 175);
            this.comboBuild.Name = "comboBuild";
            this.comboBuild.Size = new System.Drawing.Size(193, 24);
            this.comboBuild.TabIndex = 20;
            // 
            // comboLevel
            // 
            this.comboLevel.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.lecturerBindingSource, "ELevel", true));
            this.comboLevel.FormattingEnabled = true;
            this.comboLevel.Items.AddRange(new object[] {
            "Professor",
            "Assistant Professor ",
            "Senior Lecturer(HG)",
            "Senior Lecturer",
            "Lecturer",
            "Assistant Lecturer"});
            this.comboLevel.Location = new System.Drawing.Point(562, 232);
            this.comboLevel.Name = "comboLevel";
            this.comboLevel.Size = new System.Drawing.Size(193, 24);
            this.comboLevel.TabIndex = 22;
            // 
            // numericRank
            // 
            this.numericRank.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.lecturerBindingSource, "Rank", true));
            this.numericRank.Location = new System.Drawing.Point(562, 288);
            this.numericRank.Name = "numericRank";
            this.numericRank.Size = new System.Drawing.Size(56, 22);
            this.numericRank.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(337, 58);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 17);
            this.label9.TabIndex = 24;
            this.label9.Text = "Lecturer Details";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnSave.Location = new System.Drawing.Point(377, 372);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 30);
            this.btnSave.TabIndex = 25;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lecturerBindingSource
            // 
            this.lecturerBindingSource.DataSource = typeof(TTMS2.Lecturer);
            // 
            // frmLecturerInfo
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.numericRank);
            this.Controls.Add(this.comboLevel);
            this.Controls.Add(this.comboCen);
            this.Controls.Add(this.comboBuild);
            this.Controls.Add(this.comboFac);
            this.Controls.Add(this.comboDep);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtEmpID);
            this.Controls.Add(this.txtLName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmLecturerInfo";
            this.Text = "Add/Edit Lecturers";
            this.Load += new System.EventHandler(this.frmLecturerInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericRank)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lecturerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtEmpID;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboDep;
        private System.Windows.Forms.ComboBox comboFac;
        private System.Windows.Forms.ComboBox comboCen;
        private System.Windows.Forms.ComboBox comboBuild;
        private System.Windows.Forms.ComboBox comboLevel;
        private System.Windows.Forms.NumericUpDown numericRank;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.BindingSource lecturerBindingSource;
    }
}