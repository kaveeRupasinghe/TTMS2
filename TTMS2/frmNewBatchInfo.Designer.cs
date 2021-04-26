
namespace TTMS2
{
    partial class frmNewBatchInfo
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtbatchNo = new System.Windows.Forms.TextBox();
            this.comboAYS = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboProID = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtGID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSGID = new System.Windows.Forms.TextBox();
            this.newBatchBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.newBatchBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnSave.Location = new System.Drawing.Point(120, 436);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(91, 30);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Academic Year Semester";
            // 
            // txtbatchNo
            // 
            this.txtbatchNo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.newBatchBindingSource, "BatchNumber", true));
            this.txtbatchNo.Location = new System.Drawing.Point(227, 109);
            this.txtbatchNo.Name = "txtbatchNo";
            this.txtbatchNo.Size = new System.Drawing.Size(100, 22);
            this.txtbatchNo.TabIndex = 2;
            // 
            // comboAYS
            // 
            this.comboAYS.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.newBatchBindingSource, "AcademicYrSemester", true));
            this.comboAYS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboAYS.FormattingEnabled = true;
            this.comboAYS.Items.AddRange(new object[] {
            "Y1S1",
            "Y1S2",
            "Y2S1",
            "Y2S2",
            "Y3S1",
            "Y3S2",
            "Y4S1",
            "Y4S2"});
            this.comboAYS.Location = new System.Drawing.Point(227, 165);
            this.comboAYS.Name = "comboAYS";
            this.comboAYS.Size = new System.Drawing.Size(121, 24);
            this.comboAYS.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Batch Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(366, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Batch Details";
            // 
            // comboProID
            // 
            this.comboProID.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.newBatchBindingSource, "ProgrammeID", true));
            this.comboProID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboProID.FormattingEnabled = true;
            this.comboProID.Items.AddRange(new object[] {
            "IT",
            "SE",
            "DS",
            "CS",
            "CSNE",
            "IM",
            "ISE"});
            this.comboProID.Location = new System.Drawing.Point(227, 222);
            this.comboProID.Name = "comboProID";
            this.comboProID.Size = new System.Drawing.Size(121, 24);
            this.comboProID.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Program ID";
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnGenerate.Location = new System.Drawing.Point(508, 248);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(123, 33);
            this.btnGenerate.TabIndex = 8;
            this.btnGenerate.Text = "Generate ID";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 288);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Group Number";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 342);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Sub Group Number";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(420, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Group ID";
            // 
            // txtGID
            // 
            this.txtGID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.newBatchBindingSource, "GroupID", true));
            this.txtGID.Location = new System.Drawing.Point(603, 109);
            this.txtGID.Name = "txtGID";
            this.txtGID.Size = new System.Drawing.Size(100, 22);
            this.txtGID.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(420, 170);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "Sub Group ID";
            // 
            // txtSGID
            // 
            this.txtSGID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.newBatchBindingSource, "subGroupID", true));
            this.txtSGID.Location = new System.Drawing.Point(603, 165);
            this.txtSGID.Name = "txtSGID";
            this.txtSGID.Size = new System.Drawing.Size(100, 22);
            this.txtSGID.TabIndex = 15;
            // 
            // newBatchBindingSource
            // 
            this.newBatchBindingSource.DataSource = typeof(TTMS2.NewBatch);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.newBatchBindingSource, "groupNumber", true));
            this.numericUpDown1.Location = new System.Drawing.Point(227, 282);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown1.TabIndex = 17;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.newBatchBindingSource, "subGroupNumber", true));
            this.numericUpDown2.Location = new System.Drawing.Point(227, 337);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown2.TabIndex = 18;
            // 
            // frmNewBatchInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(800, 517);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtSGID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtGID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.comboProID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboAYS);
            this.Controls.Add(this.txtbatchNo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmNewBatchInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add/Edit Batches";
            this.Load += new System.EventHandler(this.frmNewBatchInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.newBatchBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbatchNo;
        private System.Windows.Forms.ComboBox comboAYS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboProID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtGID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSGID;
        private System.Windows.Forms.BindingSource newBatchBindingSource;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
    }
}