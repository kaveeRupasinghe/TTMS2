
namespace TTMS2
{
    partial class Form11
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
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
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
            this.dataGridView11 = new System.Windows.Forms.DataGridView();
            this.subjectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.offeredYearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.offeredSemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lecHoursDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tuteHoursDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labHoursDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.evaHoursDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClose = new System.Windows.Forms.Button();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip2
            // 
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbRefresh,
            this.toolStripSeparator1,
            this.tbAdd,
            this.toolStripSeparator2,
            this.tbEdit,
            this.toolStripSeparator3,
            this.tbDelete,
            this.toolStripSeparator4,
            this.tbSave});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(1143, 27);
            this.toolStrip2.TabIndex = 17;
            this.toolStrip2.Text = "toolStrip2";
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
            this.btnSearch.Location = new System.Drawing.Point(650, 99);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(97, 33);
            this.btnSearch.TabIndex = 16;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSearch.Location = new System.Drawing.Point(387, 104);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(257, 22);
            this.txtSearch.TabIndex = 15;
            // 
            // dataGridView11
            // 
            this.dataGridView11.AutoGenerateColumns = false;
            this.dataGridView11.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridView11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView11.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView11.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.offeredYearDataGridViewTextBoxColumn,
            this.offeredSemDataGridViewTextBoxColumn,
            this.subNameDataGridViewTextBoxColumn,
            this.subCodeDataGridViewTextBoxColumn,
            this.lecHoursDataGridViewTextBoxColumn,
            this.tuteHoursDataGridViewTextBoxColumn,
            this.labHoursDataGridViewTextBoxColumn,
            this.evaHoursDataGridViewTextBoxColumn});
            this.dataGridView11.DataSource = this.subjectBindingSource;
            this.dataGridView11.Location = new System.Drawing.Point(75, 240);
            this.dataGridView11.Name = "dataGridView11";
            this.dataGridView11.RowHeadersWidth = 51;
            this.dataGridView11.RowTemplate.Height = 24;
            this.dataGridView11.Size = new System.Drawing.Size(1006, 388);
            this.dataGridView11.TabIndex = 18;
            // 
            // subjectBindingSource
            // 
            this.subjectBindingSource.DataSource = typeof(TTMS2.Subject);
            // 
            // offeredYearDataGridViewTextBoxColumn
            // 
            this.offeredYearDataGridViewTextBoxColumn.DataPropertyName = "OfferedYear";
            this.offeredYearDataGridViewTextBoxColumn.HeaderText = "OfferedYear";
            this.offeredYearDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.offeredYearDataGridViewTextBoxColumn.Name = "offeredYearDataGridViewTextBoxColumn";
            this.offeredYearDataGridViewTextBoxColumn.Width = 125;
            // 
            // offeredSemDataGridViewTextBoxColumn
            // 
            this.offeredSemDataGridViewTextBoxColumn.DataPropertyName = "OfferedSem";
            this.offeredSemDataGridViewTextBoxColumn.HeaderText = "OfferedSem";
            this.offeredSemDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.offeredSemDataGridViewTextBoxColumn.Name = "offeredSemDataGridViewTextBoxColumn";
            this.offeredSemDataGridViewTextBoxColumn.Width = 125;
            // 
            // subNameDataGridViewTextBoxColumn
            // 
            this.subNameDataGridViewTextBoxColumn.DataPropertyName = "SubName";
            this.subNameDataGridViewTextBoxColumn.HeaderText = "SubName";
            this.subNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.subNameDataGridViewTextBoxColumn.Name = "subNameDataGridViewTextBoxColumn";
            this.subNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // subCodeDataGridViewTextBoxColumn
            // 
            this.subCodeDataGridViewTextBoxColumn.DataPropertyName = "SubCode";
            this.subCodeDataGridViewTextBoxColumn.HeaderText = "SubCode";
            this.subCodeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.subCodeDataGridViewTextBoxColumn.Name = "subCodeDataGridViewTextBoxColumn";
            this.subCodeDataGridViewTextBoxColumn.Width = 125;
            // 
            // lecHoursDataGridViewTextBoxColumn
            // 
            this.lecHoursDataGridViewTextBoxColumn.DataPropertyName = "LecHours";
            this.lecHoursDataGridViewTextBoxColumn.HeaderText = "LecHours";
            this.lecHoursDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lecHoursDataGridViewTextBoxColumn.Name = "lecHoursDataGridViewTextBoxColumn";
            this.lecHoursDataGridViewTextBoxColumn.Width = 125;
            // 
            // tuteHoursDataGridViewTextBoxColumn
            // 
            this.tuteHoursDataGridViewTextBoxColumn.DataPropertyName = "TuteHours";
            this.tuteHoursDataGridViewTextBoxColumn.HeaderText = "TuteHours";
            this.tuteHoursDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tuteHoursDataGridViewTextBoxColumn.Name = "tuteHoursDataGridViewTextBoxColumn";
            this.tuteHoursDataGridViewTextBoxColumn.Width = 125;
            // 
            // labHoursDataGridViewTextBoxColumn
            // 
            this.labHoursDataGridViewTextBoxColumn.DataPropertyName = "LabHours";
            this.labHoursDataGridViewTextBoxColumn.HeaderText = "LabHours";
            this.labHoursDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.labHoursDataGridViewTextBoxColumn.Name = "labHoursDataGridViewTextBoxColumn";
            this.labHoursDataGridViewTextBoxColumn.Width = 125;
            // 
            // evaHoursDataGridViewTextBoxColumn
            // 
            this.evaHoursDataGridViewTextBoxColumn.DataPropertyName = "EvaHours";
            this.evaHoursDataGridViewTextBoxColumn.HeaderText = "EvaHours";
            this.evaHoursDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.evaHoursDataGridViewTextBoxColumn.Name = "evaHoursDataGridViewTextBoxColumn";
            this.evaHoursDataGridViewTextBoxColumn.Width = 125;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnClose.Location = new System.Drawing.Point(996, 788);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(85, 38);
            this.btnClose.TabIndex = 19;
            this.btnClose.Text = "Back";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Form11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(1143, 886);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dataGridView11);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Name = "Form11";
            this.Text = "Form11";
            this.Load += new System.EventHandler(this.Form11_Load);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton tbRefresh;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tbAdd;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tbEdit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tbDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton tbSave;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dataGridView11;
        private System.Windows.Forms.DataGridViewTextBoxColumn offeredYearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn offeredSemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lecHoursDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tuteHoursDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn labHoursDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn evaHoursDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource subjectBindingSource;
        private System.Windows.Forms.Button btnClose;
    }
}