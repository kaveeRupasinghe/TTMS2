
namespace TTMS2
{
    partial class Form10
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView10 = new System.Windows.Forms.DataGridView();
            this.subjectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.syearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ssemesterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.snameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scodeDataGridViewImageColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lechourDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tutehourDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labhourDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.evhourDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSearch.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.Location = new System.Drawing.Point(638, 62);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 33);
            this.btnSearch.TabIndex = 12;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSearch.Location = new System.Drawing.Point(343, 67);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(279, 22);
            this.txtSearch.TabIndex = 11;
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
            this.toolStrip1.TabIndex = 10;
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
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button1.Location = new System.Drawing.Point(992, 801);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 33);
            this.button1.TabIndex = 13;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView10
            // 
            this.dataGridView10.AutoGenerateColumns = false;
            this.dataGridView10.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridView10.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView10.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.syearDataGridViewTextBoxColumn,
            this.ssemesterDataGridViewTextBoxColumn,
            this.snameDataGridViewTextBoxColumn,
            this.scodeDataGridViewImageColumn,
            this.lechourDataGridViewTextBoxColumn,
            this.tutehourDataGridViewTextBoxColumn,
            this.labhourDataGridViewTextBoxColumn,
            this.evhourDataGridViewTextBoxColumn});
            this.dataGridView10.DataSource = this.subjectBindingSource;
            this.dataGridView10.Location = new System.Drawing.Point(115, 169);
            this.dataGridView10.Name = "dataGridView10";
            this.dataGridView10.RowHeadersWidth = 51;
            this.dataGridView10.RowTemplate.Height = 24;
            this.dataGridView10.Size = new System.Drawing.Size(915, 423);
            this.dataGridView10.TabIndex = 14;
            // 
            // subjectBindingSource
            // 
            this.subjectBindingSource.DataSource = typeof(TTMS2.Subject);
            // 
            // syearDataGridViewTextBoxColumn
            // 
            this.syearDataGridViewTextBoxColumn.DataPropertyName = "Syear";
            this.syearDataGridViewTextBoxColumn.HeaderText = "Syear";
            this.syearDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.syearDataGridViewTextBoxColumn.Name = "syearDataGridViewTextBoxColumn";
            this.syearDataGridViewTextBoxColumn.Width = 125;
            // 
            // ssemesterDataGridViewTextBoxColumn
            // 
            this.ssemesterDataGridViewTextBoxColumn.DataPropertyName = "Ssemester";
            this.ssemesterDataGridViewTextBoxColumn.HeaderText = "Ssemester";
            this.ssemesterDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ssemesterDataGridViewTextBoxColumn.Name = "ssemesterDataGridViewTextBoxColumn";
            this.ssemesterDataGridViewTextBoxColumn.Width = 125;
            // 
            // snameDataGridViewTextBoxColumn
            // 
            this.snameDataGridViewTextBoxColumn.DataPropertyName = "Sname";
            this.snameDataGridViewTextBoxColumn.HeaderText = "Sname";
            this.snameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.snameDataGridViewTextBoxColumn.Name = "snameDataGridViewTextBoxColumn";
            this.snameDataGridViewTextBoxColumn.Width = 125;
            // 
            // scodeDataGridViewImageColumn
            // 
            this.scodeDataGridViewImageColumn.DataPropertyName = "Scode";
            this.scodeDataGridViewImageColumn.HeaderText = "Scode";
            this.scodeDataGridViewImageColumn.MinimumWidth = 6;
            this.scodeDataGridViewImageColumn.Name = "scodeDataGridViewImageColumn";
            this.scodeDataGridViewImageColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.scodeDataGridViewImageColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.scodeDataGridViewImageColumn.Width = 125;
            // 
            // lechourDataGridViewTextBoxColumn
            // 
            this.lechourDataGridViewTextBoxColumn.DataPropertyName = "Lechour";
            this.lechourDataGridViewTextBoxColumn.HeaderText = "Lechour";
            this.lechourDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lechourDataGridViewTextBoxColumn.Name = "lechourDataGridViewTextBoxColumn";
            this.lechourDataGridViewTextBoxColumn.Width = 125;
            // 
            // tutehourDataGridViewTextBoxColumn
            // 
            this.tutehourDataGridViewTextBoxColumn.DataPropertyName = "Tutehour";
            this.tutehourDataGridViewTextBoxColumn.HeaderText = "Tutehour";
            this.tutehourDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tutehourDataGridViewTextBoxColumn.Name = "tutehourDataGridViewTextBoxColumn";
            this.tutehourDataGridViewTextBoxColumn.Width = 125;
            // 
            // labhourDataGridViewTextBoxColumn
            // 
            this.labhourDataGridViewTextBoxColumn.DataPropertyName = "Labhour";
            this.labhourDataGridViewTextBoxColumn.HeaderText = "Labhour";
            this.labhourDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.labhourDataGridViewTextBoxColumn.Name = "labhourDataGridViewTextBoxColumn";
            this.labhourDataGridViewTextBoxColumn.Width = 125;
            // 
            // evhourDataGridViewTextBoxColumn
            // 
            this.evhourDataGridViewTextBoxColumn.DataPropertyName = "Evhour";
            this.evhourDataGridViewTextBoxColumn.HeaderText = "Evhour";
            this.evhourDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.evhourDataGridViewTextBoxColumn.Name = "evhourDataGridViewTextBoxColumn";
            this.evhourDataGridViewTextBoxColumn.Width = 125;
            // 
            // Form10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(1143, 886);
            this.Controls.Add(this.dataGridView10);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form10";
            this.Text = "Form10";
            this.Load += new System.EventHandler(this.Form10_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView10;
        private System.Windows.Forms.DataGridViewTextBoxColumn syearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ssemesterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn snameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn scodeDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lechourDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tutehourDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn labhourDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn evhourDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource subjectBindingSource;
    }
}