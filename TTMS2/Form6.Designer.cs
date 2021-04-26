
namespace TTMS2
{
    partial class Form6
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
            this.btnClose = new System.Windows.Forms.Button();
            this.dataGridView6 = new System.Windows.Forms.DataGridView();
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.programmeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.programmeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.programmeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.programmeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnClose.Location = new System.Drawing.Point(1034, 824);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(81, 40);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Back";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dataGridView6
            // 
            this.dataGridView6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView6.AutoGenerateColumns = false;
            this.dataGridView6.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridView6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView6.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.programmeIDDataGridViewTextBoxColumn,
            this.programmeNameDataGridViewTextBoxColumn});
            this.dataGridView6.DataSource = this.programmeBindingSource;
            this.dataGridView6.Location = new System.Drawing.Point(205, 145);
            this.dataGridView6.Name = "dataGridView6";
            this.dataGridView6.RowHeadersWidth = 51;
            this.dataGridView6.RowTemplate.Height = 24;
            this.dataGridView6.Size = new System.Drawing.Size(730, 654);
            this.dataGridView6.TabIndex = 5;
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
            this.toolStrip1.TabIndex = 4;
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
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSearch.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.Location = new System.Drawing.Point(640, 59);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(97, 33);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            this.btnSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnSearch_KeyPress);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSearch.Location = new System.Drawing.Point(409, 64);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(225, 22);
            this.txtSearch.TabIndex = 8;
            // 
            // programmeIDDataGridViewTextBoxColumn
            // 
            this.programmeIDDataGridViewTextBoxColumn.DataPropertyName = "ProgrammeID";
            this.programmeIDDataGridViewTextBoxColumn.HeaderText = "ProgrammeID";
            this.programmeIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.programmeIDDataGridViewTextBoxColumn.Name = "programmeIDDataGridViewTextBoxColumn";
            this.programmeIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // programmeNameDataGridViewTextBoxColumn
            // 
            this.programmeNameDataGridViewTextBoxColumn.DataPropertyName = "ProgrammeName";
            this.programmeNameDataGridViewTextBoxColumn.HeaderText = "ProgrammeName";
            this.programmeNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.programmeNameDataGridViewTextBoxColumn.Name = "programmeNameDataGridViewTextBoxColumn";
            this.programmeNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // programmeBindingSource
            // 
            this.programmeBindingSource.DataSource = typeof(TTMS2.Programme);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(1143, 886);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dataGridView6);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form6";
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.programmeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dataGridView6;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn programmeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn programmeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource programmeBindingSource;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
    }
}