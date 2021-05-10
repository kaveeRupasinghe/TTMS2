
namespace TTMS2
{
    partial class frmSubjectsInfo
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
            this.label1 = new System.Windows.Forms.Label();
            this.numericlech = new System.Windows.Forms.NumericUpDown();
            this.subjectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.numerictuteh = new System.Windows.Forms.NumericUpDown();
            this.numericlabh = new System.Windows.Forms.NumericUpDown();
            this.numericevah = new System.Windows.Forms.NumericUpDown();
            this.btnSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtOsemester = new System.Windows.Forms.TextBox();
            this.txtSname = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtscode = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbOYear = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericlech)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numerictuteh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericlabh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericevah)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Offered Year";
            // 
            // numericlech
            // 
            this.numericlech.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.subjectBindingSource, "LecHours", true));
            this.numericlech.Location = new System.Drawing.Point(613, 112);
            this.numericlech.Name = "numericlech";
            this.numericlech.Size = new System.Drawing.Size(82, 22);
            this.numericlech.TabIndex = 2;
            // 
            // subjectBindingSource
            // 
            this.subjectBindingSource.DataSource = typeof(TTMS2.Subject);
            // 
            // numerictuteh
            // 
            this.numerictuteh.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.subjectBindingSource, "TuteHours", true));
            this.numerictuteh.Location = new System.Drawing.Point(613, 178);
            this.numerictuteh.Name = "numerictuteh";
            this.numerictuteh.Size = new System.Drawing.Size(82, 22);
            this.numerictuteh.TabIndex = 3;
            // 
            // numericlabh
            // 
            this.numericlabh.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.subjectBindingSource, "LabHours", true));
            this.numericlabh.Location = new System.Drawing.Point(613, 236);
            this.numericlabh.Name = "numericlabh";
            this.numericlabh.Size = new System.Drawing.Size(82, 22);
            this.numericlabh.TabIndex = 4;
            // 
            // numericevah
            // 
            this.numericevah.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.subjectBindingSource, "EvaHours", true));
            this.numericevah.Location = new System.Drawing.Point(613, 293);
            this.numericevah.Name = "numericevah";
            this.numericevah.Size = new System.Drawing.Size(82, 22);
            this.numericevah.TabIndex = 5;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnSave.Location = new System.Drawing.Point(363, 359);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 30);
            this.btnSave.TabIndex = 26;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(443, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 17);
            this.label2.TabIndex = 27;
            this.label2.Text = "No of Tute Hours";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(443, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 17);
            this.label3.TabIndex = 28;
            this.label3.Text = "No of Lecture Hours";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 17);
            this.label4.TabIndex = 29;
            this.label4.Text = "Offered Semester";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(321, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 17);
            this.label5.TabIndex = 30;
            this.label5.Text = "Subject Details";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtOsemester
            // 
            this.txtOsemester.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.subjectBindingSource, "OfferedSem", true));
            this.txtOsemester.Location = new System.Drawing.Point(186, 175);
            this.txtOsemester.Name = "txtOsemester";
            this.txtOsemester.Size = new System.Drawing.Size(150, 22);
            this.txtOsemester.TabIndex = 31;
            // 
            // txtSname
            // 
            this.txtSname.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.subjectBindingSource, "SubName", true));
            this.txtSname.Location = new System.Drawing.Point(186, 233);
            this.txtSname.Name = "txtSname";
            this.txtSname.Size = new System.Drawing.Size(150, 22);
            this.txtSname.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(69, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Subject Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(69, 296);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 17);
            this.label7.TabIndex = 29;
            this.label7.Text = "Subject Code";
            // 
            // txtscode
            // 
            this.txtscode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.subjectBindingSource, "SubCode", true));
            this.txtscode.Location = new System.Drawing.Point(186, 296);
            this.txtscode.Name = "txtscode";
            this.txtscode.Size = new System.Drawing.Size(150, 22);
            this.txtscode.TabIndex = 31;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(443, 233);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 17);
            this.label8.TabIndex = 32;
            this.label8.Text = "No of Lab Hours";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(443, 296);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(154, 17);
            this.label9.TabIndex = 33;
            this.label9.Text = "No of Evaluation Hours";
            // 
            // cmbOYear
            // 
            this.cmbOYear.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.subjectBindingSource, "OfferedYear", true));
            this.cmbOYear.FormattingEnabled = true;
            this.cmbOYear.Items.AddRange(new object[] {
            "2018",
            "2019",
            "2020",
            "2021"});
            this.cmbOYear.Location = new System.Drawing.Point(186, 109);
            this.cmbOYear.Name = "cmbOYear";
            this.cmbOYear.Size = new System.Drawing.Size(150, 24);
            this.cmbOYear.TabIndex = 34;
            // 
            // frmSubjectsInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbOYear);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtscode);
            this.Controls.Add(this.txtOsemester);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.numericevah);
            this.Controls.Add(this.numericlabh);
            this.Controls.Add(this.numerictuteh);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numericlech);
            this.Controls.Add(this.txtSname);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmSubjectsInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmSubjectsInfo";
            this.Load += new System.EventHandler(this.frmSubjectsInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericlech)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numerictuteh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericlabh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericevah)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericlech;
        private System.Windows.Forms.NumericUpDown numerictuteh;
        private System.Windows.Forms.NumericUpDown numericlabh;
        private System.Windows.Forms.NumericUpDown numericevah;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtOsemester;
        private System.Windows.Forms.TextBox txtSname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtscode;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbOYear;
        private System.Windows.Forms.BindingSource subjectBindingSource;
    }
}