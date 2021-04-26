
namespace TTMS2
{
    partial class frmBuildingInfo
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBuildNo = new System.Windows.Forms.TextBox();
            this.txtBuildName = new System.Windows.Forms.TextBox();
            this.txtNoBuild = new System.Windows.Forms.TextBox();
            this.txtNoRoom = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.buildingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.buildingBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Building Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Building Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(98, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "No. of Floors";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(98, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "No. of Rooms";
            // 
            // txtBuildNo
            // 
            this.txtBuildNo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.buildingBindingSource, "BuildingNumber", true));
            this.txtBuildNo.Location = new System.Drawing.Point(221, 67);
            this.txtBuildNo.Name = "txtBuildNo";
            this.txtBuildNo.Size = new System.Drawing.Size(100, 22);
            this.txtBuildNo.TabIndex = 1;
            // 
            // txtBuildName
            // 
            this.txtBuildName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.buildingBindingSource, "BuildingNames", true));
            this.txtBuildName.Location = new System.Drawing.Point(221, 121);
            this.txtBuildName.Name = "txtBuildName";
            this.txtBuildName.Size = new System.Drawing.Size(100, 22);
            this.txtBuildName.TabIndex = 1;
            // 
            // txtNoBuild
            // 
            this.txtNoBuild.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.buildingBindingSource, "NumberOfFloors", true));
            this.txtNoBuild.Location = new System.Drawing.Point(221, 183);
            this.txtNoBuild.Name = "txtNoBuild";
            this.txtNoBuild.Size = new System.Drawing.Size(100, 22);
            this.txtNoBuild.TabIndex = 1;
            // 
            // txtNoRoom
            // 
            this.txtNoRoom.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.buildingBindingSource, "NumberOfRooms", true));
            this.txtNoRoom.Location = new System.Drawing.Point(221, 243);
            this.txtNoRoom.Name = "txtNoRoom";
            this.txtNoRoom.Size = new System.Drawing.Size(100, 22);
            this.txtNoRoom.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnSave.Location = new System.Drawing.Point(176, 304);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 30);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(151, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Building Details";
            // 
            // buildingBindingSource
            // 
            this.buildingBindingSource.DataSource = typeof(TTMS2.Building);
            // 
            // frmBuildingInfo
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(423, 371);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtNoRoom);
            this.Controls.Add(this.txtNoBuild);
            this.Controls.Add(this.txtBuildName);
            this.Controls.Add(this.txtBuildNo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmBuildingInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add/Edit Buildings";
            this.Load += new System.EventHandler(this.frmBuildingInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.buildingBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBuildNo;
        private System.Windows.Forms.TextBox txtBuildName;
        private System.Windows.Forms.TextBox txtNoBuild;
        private System.Windows.Forms.TextBox txtNoRoom;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.BindingSource buildingBindingSource;
        private System.Windows.Forms.Label label5;
    }
}