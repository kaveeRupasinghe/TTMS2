
namespace TTMS2
{
    partial class frmSubjectInfo
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
            this.btnSave = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.numericEvahour = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboOyear = new System.Windows.Forms.ComboBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.txtsname = new System.Windows.Forms.TextBox();
            this.txtscode = new System.Windows.Forms.TextBox();
            this.numericLabhour = new System.Windows.Forms.NumericUpDown();
            this.numericThour = new System.Windows.Forms.NumericUpDown();
            this.numericLechour = new System.Windows.Forms.NumericUpDown();
            this.subjectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numericEvahour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericLabhour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericThour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericLechour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnSave.Location = new System.Drawing.Point(365, 367);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 30);
            this.btnSave.TabIndex = 43;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(349, 54);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 17);
            this.label9.TabIndex = 42;
            this.label9.Text = "Subject Details";
            // 
            // numericEvahour
            // 
            this.numericEvahour.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.subjectBindingSource, "Evhour", true));
            this.numericEvahour.Location = new System.Drawing.Point(632, 280);
            this.numericEvahour.Name = "numericEvahour";
            this.numericEvahour.Size = new System.Drawing.Size(56, 22);
            this.numericEvahour.TabIndex = 41;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(466, 285);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 17);
            this.label5.TabIndex = 32;
            this.label5.Text = "No of evaluation hours";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(466, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 17);
            this.label6.TabIndex = 33;
            this.label6.Text = "No of lab hours";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(466, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 17);
            this.label7.TabIndex = 34;
            this.label7.Text = "No of tute hours";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(466, 114);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 17);
            this.label8.TabIndex = 35;
            this.label8.Text = "No of lecture hours";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 290);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 17);
            this.label4.TabIndex = 26;
            this.label4.Text = "Subject code";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 17);
            this.label3.TabIndex = 27;
            this.label3.Text = "Subject name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 17);
            this.label2.TabIndex = 28;
            this.label2.Text = "Offered Semester";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 17);
            this.label1.TabIndex = 29;
            this.label1.Text = "Offered Year";
            // 
            // comboOyear
            // 
            this.comboOyear.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.subjectBindingSource, "Syear", true));
            this.comboOyear.FormattingEnabled = true;
            this.comboOyear.Items.AddRange(new object[] {
            "Malabe",
            "Metro",
            "Matara",
            "Kandy",
            "Jaffna",
            "Kurunegala"});
            this.comboOyear.Location = new System.Drawing.Point(180, 114);
            this.comboOyear.Name = "comboOyear";
            this.comboOyear.Size = new System.Drawing.Size(193, 24);
            this.comboOyear.TabIndex = 44;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.subjectBindingSource, "Ssemester", true));
            this.radioButton1.Location = new System.Drawing.Point(180, 173);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(78, 21);
            this.radioButton1.TabIndex = 45;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "1st sem";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.subjectBindingSource, "Ssemester", true));
            this.radioButton2.Location = new System.Drawing.Point(290, 171);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(83, 21);
            this.radioButton2.TabIndex = 46;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "2nd sem";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // txtsname
            // 
            this.txtsname.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.subjectBindingSource, "Sname", true));
            this.txtsname.Location = new System.Drawing.Point(180, 230);
            this.txtsname.Name = "txtsname";
            this.txtsname.Size = new System.Drawing.Size(193, 22);
            this.txtsname.TabIndex = 47;
            // 
            // txtscode
            // 
            this.txtscode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.subjectBindingSource, "Scode", true));
            this.txtscode.Location = new System.Drawing.Point(180, 290);
            this.txtscode.Name = "txtscode";
            this.txtscode.Size = new System.Drawing.Size(193, 22);
            this.txtscode.TabIndex = 48;
            // 
            // numericLabhour
            // 
            this.numericLabhour.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.subjectBindingSource, "Labhour", true));
            this.numericLabhour.Location = new System.Drawing.Point(632, 222);
            this.numericLabhour.Name = "numericLabhour";
            this.numericLabhour.Size = new System.Drawing.Size(56, 22);
            this.numericLabhour.TabIndex = 49;
            // 
            // numericThour
            // 
            this.numericThour.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.subjectBindingSource, "Tutehour", true));
            this.numericThour.Location = new System.Drawing.Point(632, 163);
            this.numericThour.Name = "numericThour";
            this.numericThour.Size = new System.Drawing.Size(56, 22);
            this.numericThour.TabIndex = 50;
            // 
            // numericLechour
            // 
            this.numericLechour.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.subjectBindingSource, "Lechour", true));
            this.numericLechour.Location = new System.Drawing.Point(632, 113);
            this.numericLechour.Name = "numericLechour";
            this.numericLechour.Size = new System.Drawing.Size(56, 22);
            this.numericLechour.TabIndex = 51;
            // 
            // subjectBindingSource
            // 
            this.subjectBindingSource.DataSource = typeof(TTMS2.Subject);
            // 
            // frmSubjectInfo
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.numericLechour);
            this.Controls.Add(this.numericThour);
            this.Controls.Add(this.numericLabhour);
            this.Controls.Add(this.txtscode);
            this.Controls.Add(this.txtsname);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.comboOyear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.numericEvahour);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmSubjectInfo";
            this.Text = "Add/Edit Subject";
            this.Load += new System.EventHandler(this.frmSubjectInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericEvahour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericLabhour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericThour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericLechour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numericEvahour;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboOyear;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.TextBox txtsname;
        private System.Windows.Forms.TextBox txtscode;
        private System.Windows.Forms.NumericUpDown numericLabhour;
        private System.Windows.Forms.NumericUpDown numericThour;
        private System.Windows.Forms.NumericUpDown numericLechour;
        private System.Windows.Forms.BindingSource subjectBindingSource;
    }
}