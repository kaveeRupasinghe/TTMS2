
namespace TTMS2
{
    partial class frmRooInfo
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
            this.btnsaveR = new System.Windows.Forms.Button();
            this.numericUDcapacity = new System.Windows.Forms.NumericUpDown();
            this.rooBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRoomName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBuildNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRoomNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboRoomType = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUDcapacity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rooBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnsaveR
            // 
            this.btnsaveR.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnsaveR.Location = new System.Drawing.Point(187, 330);
            this.btnsaveR.Name = "btnsaveR";
            this.btnsaveR.Size = new System.Drawing.Size(75, 29);
            this.btnsaveR.TabIndex = 12;
            this.btnsaveR.Text = "Save";
            this.btnsaveR.UseVisualStyleBackColor = false;
            this.btnsaveR.Click += new System.EventHandler(this.btnsaveR_Click);
            // 
            // numericUDcapacity
            // 
            this.numericUDcapacity.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.rooBindingSource, "Capacity", true));
            this.numericUDcapacity.Location = new System.Drawing.Point(243, 262);
            this.numericUDcapacity.Name = "numericUDcapacity";
            this.numericUDcapacity.Size = new System.Drawing.Size(100, 22);
            this.numericUDcapacity.TabIndex = 13;
            // 
            // rooBindingSource
            // 
            this.rooBindingSource.DataSource = typeof(TTMS2.Roo);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(84, 267);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Capacity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(84, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Room Type";
            // 
            // txtRoomName
            // 
            this.txtRoomName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rooBindingSource, "RoomName", true));
            this.txtRoomName.Location = new System.Drawing.Point(243, 169);
            this.txtRoomName.Name = "txtRoomName";
            this.txtRoomName.Size = new System.Drawing.Size(100, 22);
            this.txtRoomName.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(84, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Room Name";
            // 
            // txtBuildNo
            // 
            this.txtBuildNo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rooBindingSource, "BuildingNumber", true));
            this.txtBuildNo.Location = new System.Drawing.Point(243, 123);
            this.txtBuildNo.Name = "txtBuildNo";
            this.txtBuildNo.Size = new System.Drawing.Size(100, 22);
            this.txtBuildNo.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Building Number";
            // 
            // txtRoomNo
            // 
            this.txtRoomNo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rooBindingSource, "RoomNumber", true));
            this.txtRoomNo.Location = new System.Drawing.Point(243, 78);
            this.txtRoomNo.Name = "txtRoomNo";
            this.txtRoomNo.Size = new System.Drawing.Size(100, 22);
            this.txtRoomNo.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Room Number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(162, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Room Details";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // comboRoomType
            // 
            this.comboRoomType.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.rooBindingSource, "RoomType", true));
            this.comboRoomType.FormattingEnabled = true;
            this.comboRoomType.Items.AddRange(new object[] {
            "Lectuure Hall",
            "Laboratory",
            "Auditorium"});
            this.comboRoomType.Location = new System.Drawing.Point(243, 216);
            this.comboRoomType.Name = "comboRoomType";
            this.comboRoomType.Size = new System.Drawing.Size(147, 24);
            this.comboRoomType.TabIndex = 18;
            // 
            // frmRooInfo
            // 
            this.AcceptButton = this.btnsaveR;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(423, 371);
            this.Controls.Add(this.comboRoomType);
            this.Controls.Add(this.btnsaveR);
            this.Controls.Add(this.numericUDcapacity);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtRoomName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBuildNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtRoomNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmRooInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add/Edit Rooms";
            this.Load += new System.EventHandler(this.frmRooInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUDcapacity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rooBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsaveR;
        private System.Windows.Forms.NumericUpDown numericUDcapacity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRoomName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBuildNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRoomNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource rooBindingSource;
        private System.Windows.Forms.ComboBox comboRoomType;
    }
}