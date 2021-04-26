
namespace TTMS2
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
            this.components = new System.ComponentModel.Container();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tbRefresh = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tbAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tbEdit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tbDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tbSave = new System.Windows.Forms.ToolStripButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnclose1 = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.buildingNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buildingNamesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberOfFloorsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberOfRoomsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buildingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buildingBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbRefresh,
            this.toolStripSeparator1,
            this.tbAdd,
            this.toolStripSeparator2,
            this.tbEdit,
            this.toolStripSeparator3,
            this.tbDelete,
            this.toolStripSeparator4,
            this.tbSave});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1143, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tbRefresh
            // 
            this.tbRefresh.ForeColor = System.Drawing.Color.SteelBlue;
            this.tbRefresh.Image = global::TTMS2.Properties.Resources.WhatsApp_Image_2021_04_09_at_8_16_40_AM;
            this.tbRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbRefresh.Name = "tbRefresh";
            this.tbRefresh.Size = new System.Drawing.Size(82, 24);
            this.tbRefresh.Text = "Refresh";
            this.tbRefresh.Click += new System.EventHandler(this.tbRefresh_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // tbAdd
            // 
            this.tbAdd.ForeColor = System.Drawing.Color.SteelBlue;
            this.tbAdd.Image = global::TTMS2.Properties.Resources.WhatsApp_Image_2021_04_09_at_8_16_39_AM;
            this.tbAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbAdd.Name = "tbAdd";
            this.tbAdd.Size = new System.Drawing.Size(61, 24);
            this.tbAdd.Text = "Add";
            this.tbAdd.Click += new System.EventHandler(this.tbAdd_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // tbEdit
            // 
            this.tbEdit.ForeColor = System.Drawing.Color.SteelBlue;
            this.tbEdit.Image = global::TTMS2.Properties.Resources.editbutton;
            this.tbEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbEdit.Name = "tbEdit";
            this.tbEdit.Size = new System.Drawing.Size(59, 24);
            this.tbEdit.Text = "Edit";
            this.tbEdit.Click += new System.EventHandler(this.tbEdit_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // tbDelete
            // 
            this.tbDelete.ForeColor = System.Drawing.Color.SteelBlue;
            this.tbDelete.Image = global::TTMS2.Properties.Resources.WhatsApp_Image_2021_04_09_at_8_16_39_AM__1_;
            this.tbDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbDelete.Name = "tbDelete";
            this.tbDelete.Size = new System.Drawing.Size(77, 24);
            this.tbDelete.Text = "Delete";
            this.tbDelete.Click += new System.EventHandler(this.tbDelete_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 27);
            // 
            // tbSave
            // 
            this.tbSave.ForeColor = System.Drawing.Color.SteelBlue;
            this.tbSave.Image = global::TTMS2.Properties.Resources.WhatsApp_Image_2021_04_09_at_8_16_40_AM__1_;
            this.tbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbSave.Name = "tbSave";
            this.tbSave.Size = new System.Drawing.Size(64, 24);
            this.tbSave.Text = "Save";
            this.tbSave.Click += new System.EventHandler(this.tbSave_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.buildingNumberDataGridViewTextBoxColumn,
            this.buildingNamesDataGridViewTextBoxColumn,
            this.numberOfFloorsDataGridViewTextBoxColumn,
            this.numberOfRoomsDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.buildingBindingSource;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.Location = new System.Drawing.Point(116, 142);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(935, 638);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnclose1
            // 
            this.btnclose1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnclose1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnclose1.Location = new System.Drawing.Point(1039, 817);
            this.btnclose1.Name = "btnclose1";
            this.btnclose1.Size = new System.Drawing.Size(71, 41);
            this.btnclose1.TabIndex = 2;
            this.btnclose1.Text = "Back";
            this.btnclose1.UseVisualStyleBackColor = false;
            this.btnclose1.Click += new System.EventHandler(this.btnclose1_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSearch.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnSearch.Location = new System.Drawing.Point(667, 65);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 33);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSearch.Location = new System.Drawing.Point(393, 68);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(252, 22);
            this.txtSearch.TabIndex = 8;
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // buildingNumberDataGridViewTextBoxColumn
            // 
            this.buildingNumberDataGridViewTextBoxColumn.DataPropertyName = "BuildingNumber";
            this.buildingNumberDataGridViewTextBoxColumn.HeaderText = "BuildingNumber";
            this.buildingNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.buildingNumberDataGridViewTextBoxColumn.Name = "buildingNumberDataGridViewTextBoxColumn";
            this.buildingNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.buildingNumberDataGridViewTextBoxColumn.Width = 110;
            // 
            // buildingNamesDataGridViewTextBoxColumn
            // 
            this.buildingNamesDataGridViewTextBoxColumn.DataPropertyName = "BuildingNames";
            this.buildingNamesDataGridViewTextBoxColumn.HeaderText = "BuildingNames";
            this.buildingNamesDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.buildingNamesDataGridViewTextBoxColumn.Name = "buildingNamesDataGridViewTextBoxColumn";
            this.buildingNamesDataGridViewTextBoxColumn.Width = 110;
            // 
            // numberOfFloorsDataGridViewTextBoxColumn
            // 
            this.numberOfFloorsDataGridViewTextBoxColumn.DataPropertyName = "NumberOfFloors";
            this.numberOfFloorsDataGridViewTextBoxColumn.HeaderText = "NumberOfFloors";
            this.numberOfFloorsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numberOfFloorsDataGridViewTextBoxColumn.Name = "numberOfFloorsDataGridViewTextBoxColumn";
            this.numberOfFloorsDataGridViewTextBoxColumn.Width = 115;
            // 
            // numberOfRoomsDataGridViewTextBoxColumn
            // 
            this.numberOfRoomsDataGridViewTextBoxColumn.DataPropertyName = "NumberOfRooms";
            this.numberOfRoomsDataGridViewTextBoxColumn.HeaderText = "NumberOfRooms";
            this.numberOfRoomsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numberOfRoomsDataGridViewTextBoxColumn.Name = "numberOfRoomsDataGridViewTextBoxColumn";
            this.numberOfRoomsDataGridViewTextBoxColumn.Width = 120;
            // 
            // buildingBindingSource
            // 
            this.buildingBindingSource.DataSource = typeof(TTMS2.Building);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(1143, 886);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnclose1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buildingBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tbRefresh;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tbAdd;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tbEdit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tbDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton tbSave;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn buildingNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn buildingNamesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberOfFloorsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberOfRoomsDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource buildingBindingSource;
        private System.Windows.Forms.Button btnclose1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
    }
}

