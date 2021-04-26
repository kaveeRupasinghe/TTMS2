
namespace TTMS2
{
    partial class frmRoomInfo
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtRoomNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBuildNo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRoomName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRoomType = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUDcapacity = new System.Windows.Forms.NumericUpDown();
            this.btnsaveR = new System.Windows.Forms.Button();
            this.roomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numericUDcapacity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(155, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Room Details";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Room Number";
            // 
            // txtRoomNo
            // 
            this.txtRoomNo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomBindingSource, "RoomNumber", true));
            this.txtRoomNo.Location = new System.Drawing.Point(236, 67);
            this.txtRoomNo.Name = "txtRoomNo";
            this.txtRoomNo.Size = new System.Drawing.Size(100, 22);
            this.txtRoomNo.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Building Number";
            // 
            // txtBuildNo
            // 
            this.txtBuildNo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomBindingSource, "BuildingNumber", true));
            this.txtBuildNo.Location = new System.Drawing.Point(236, 112);
            this.txtBuildNo.Name = "txtBuildNo";
            this.txtBuildNo.Size = new System.Drawing.Size(100, 22);
            this.txtBuildNo.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(77, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Room Name";
            // 
            // txtRoomName
            // 
            this.txtRoomName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomBindingSource, "RoomName", true));
            this.txtRoomName.Location = new System.Drawing.Point(236, 158);
            this.txtRoomName.Name = "txtRoomName";
            this.txtRoomName.Size = new System.Drawing.Size(100, 22);
            this.txtRoomName.TabIndex = 5;
            this.txtRoomName.TextChanged += new System.EventHandler(this.txtRoomName_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(77, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Room Type";
            // 
            // txtRoomType
            // 
            this.txtRoomType.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomBindingSource, "RoomType", true));
            this.txtRoomType.Location = new System.Drawing.Point(236, 205);
            this.txtRoomType.Name = "txtRoomType";
            this.txtRoomType.Size = new System.Drawing.Size(100, 22);
            this.txtRoomType.TabIndex = 5;
            this.txtRoomType.TextChanged += new System.EventHandler(this.txtRoomType_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(77, 256);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "Capacity";
            // 
            // numericUDcapacity
            // 
            this.numericUDcapacity.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.roomBindingSource, "Capacity", true));
            this.numericUDcapacity.Location = new System.Drawing.Point(236, 251);
            this.numericUDcapacity.Name = "numericUDcapacity";
            this.numericUDcapacity.Size = new System.Drawing.Size(100, 22);
            this.numericUDcapacity.TabIndex = 5;
            // 
            // btnsaveR
            // 
            this.btnsaveR.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnsaveR.Location = new System.Drawing.Point(180, 319);
            this.btnsaveR.Name = "btnsaveR";
            this.btnsaveR.Size = new System.Drawing.Size(75, 29);
            this.btnsaveR.TabIndex = 5;
            this.btnsaveR.Text = "Save";
            this.btnsaveR.UseVisualStyleBackColor = false;
            this.btnsaveR.Click += new System.EventHandler(this.btnsaveR_Click);
            // 
            // roomBindingSource
            // 
            this.roomBindingSource.DataSource = typeof(TTMS2.Room);
            // 
            // frmRoomInfo
            // 
            this.AcceptButton = this.btnsaveR;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(423, 371);
            this.Controls.Add(this.btnsaveR);
            this.Controls.Add(this.numericUDcapacity);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtRoomType);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtRoomName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBuildNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtRoomNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmRoomInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add/Edit Rooms";
            this.Load += new System.EventHandler(this.frmRoomInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUDcapacity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRoomNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBuildNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRoomName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRoomType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUDcapacity;
        private System.Windows.Forms.Button btnsaveR;
        private System.Windows.Forms.BindingSource roomBindingSource;
    }
}