
namespace TTMS2
{
    partial class Form7
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
            this.dataGridView7 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.batchNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.academicYrSemesterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.programmeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subGroupNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subGroupIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.newBatchBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newBatchBindingSource)).BeginInit();
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
            this.tbSave.BackColor = System.Drawing.SystemColors.HighlightText;
            this.tbSave.ForeColor = System.Drawing.Color.SteelBlue;
            this.tbSave.Image = global::TTMS2.Properties.Resources.WhatsApp_Image_2021_04_09_at_8_16_40_AM__1_;
            this.tbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbSave.Name = "tbSave";
            this.tbSave.Size = new System.Drawing.Size(64, 24);
            this.tbSave.Text = "Save";
            this.tbSave.Click += new System.EventHandler(this.tbSave_Click);
            // 
            // dataGridView7
            // 
            this.dataGridView7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView7.AutoGenerateColumns = false;
            this.dataGridView7.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridView7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView7.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView7.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.batchNumberDataGridViewTextBoxColumn,
            this.academicYrSemesterDataGridViewTextBoxColumn,
            this.programmeIDDataGridViewTextBoxColumn,
            this.groupNumberDataGridViewTextBoxColumn,
            this.subGroupNumberDataGridViewTextBoxColumn,
            this.groupIDDataGridViewTextBoxColumn,
            this.subGroupIDDataGridViewTextBoxColumn});
            this.dataGridView7.DataSource = this.newBatchBindingSource;
            this.dataGridView7.Location = new System.Drawing.Point(0, 122);
            this.dataGridView7.Name = "dataGridView7";
            this.dataGridView7.RowHeadersWidth = 51;
            this.dataGridView7.RowTemplate.Height = 24;
            this.dataGridView7.Size = new System.Drawing.Size(1131, 529);
            this.dataGridView7.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button1.Location = new System.Drawing.Point(1021, 828);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 33);
            this.button1.TabIndex = 2;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSearch.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.Location = new System.Drawing.Point(684, 50);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 33);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            this.btnSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnSearch_KeyPress);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSearch.Location = new System.Drawing.Point(389, 55);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(279, 22);
            this.txtSearch.TabIndex = 8;
            // 
            // batchNumberDataGridViewTextBoxColumn
            // 
            this.batchNumberDataGridViewTextBoxColumn.DataPropertyName = "BatchNumber";
            this.batchNumberDataGridViewTextBoxColumn.HeaderText = "BatchNumber";
            this.batchNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.batchNumberDataGridViewTextBoxColumn.Name = "batchNumberDataGridViewTextBoxColumn";
            this.batchNumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // academicYrSemesterDataGridViewTextBoxColumn
            // 
            this.academicYrSemesterDataGridViewTextBoxColumn.DataPropertyName = "AcademicYrSemester";
            this.academicYrSemesterDataGridViewTextBoxColumn.HeaderText = "AcademicYrSemester";
            this.academicYrSemesterDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.academicYrSemesterDataGridViewTextBoxColumn.Name = "academicYrSemesterDataGridViewTextBoxColumn";
            this.academicYrSemesterDataGridViewTextBoxColumn.Width = 140;
            // 
            // programmeIDDataGridViewTextBoxColumn
            // 
            this.programmeIDDataGridViewTextBoxColumn.DataPropertyName = "ProgrammeID";
            this.programmeIDDataGridViewTextBoxColumn.HeaderText = "ProgrammeID";
            this.programmeIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.programmeIDDataGridViewTextBoxColumn.Name = "programmeIDDataGridViewTextBoxColumn";
            this.programmeIDDataGridViewTextBoxColumn.Width = 95;
            // 
            // groupNumberDataGridViewTextBoxColumn
            // 
            this.groupNumberDataGridViewTextBoxColumn.DataPropertyName = "groupNumber";
            this.groupNumberDataGridViewTextBoxColumn.HeaderText = "groupNumber";
            this.groupNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.groupNumberDataGridViewTextBoxColumn.Name = "groupNumberDataGridViewTextBoxColumn";
            this.groupNumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // subGroupNumberDataGridViewTextBoxColumn
            // 
            this.subGroupNumberDataGridViewTextBoxColumn.DataPropertyName = "subGroupNumber";
            this.subGroupNumberDataGridViewTextBoxColumn.HeaderText = "subGroupNumber";
            this.subGroupNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.subGroupNumberDataGridViewTextBoxColumn.Name = "subGroupNumberDataGridViewTextBoxColumn";
            this.subGroupNumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // groupIDDataGridViewTextBoxColumn
            // 
            this.groupIDDataGridViewTextBoxColumn.DataPropertyName = "GroupID";
            this.groupIDDataGridViewTextBoxColumn.HeaderText = "GroupID";
            this.groupIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.groupIDDataGridViewTextBoxColumn.Name = "groupIDDataGridViewTextBoxColumn";
            this.groupIDDataGridViewTextBoxColumn.Width = 70;
            // 
            // subGroupIDDataGridViewTextBoxColumn
            // 
            this.subGroupIDDataGridViewTextBoxColumn.DataPropertyName = "subGroupID";
            this.subGroupIDDataGridViewTextBoxColumn.HeaderText = "subGroupID";
            this.subGroupIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.subGroupIDDataGridViewTextBoxColumn.Name = "subGroupIDDataGridViewTextBoxColumn";
            this.subGroupIDDataGridViewTextBoxColumn.Width = 90;
            // 
            // newBatchBindingSource
            // 
            this.newBatchBindingSource.DataSource = typeof(TTMS2.NewBatch);
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(1143, 886);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView7);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form7";
            this.Text = "Form7";
            this.Load += new System.EventHandler(this.Form7_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newBatchBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tbRefresh;
        private System.Windows.Forms.ToolStripButton tbAdd;
        private System.Windows.Forms.ToolStripButton tbEdit;
        private System.Windows.Forms.ToolStripButton tbDelete;
        private System.Windows.Forms.ToolStripButton tbSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.DataGridView dataGridView7;
        private System.Windows.Forms.DataGridViewTextBoxColumn batchNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn academicYrSemesterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn programmeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subGroupNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subGroupIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource newBatchBindingSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
    }
}