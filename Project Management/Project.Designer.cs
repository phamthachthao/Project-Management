
namespace Project_Management
{
    partial class Project
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSearch = new FontAwesome.Sharp.IconButton();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.grDataProject = new System.Windows.Forms.DataGridView();
            this.projectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Group = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Document = new System.Windows.Forms.DataGridViewLinkColumn();
            this.File = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pTineline = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DAYS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.task = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fix = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dek = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grDataProject)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1086, 96);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnSearch.IconColor = System.Drawing.Color.White;
            this.btnSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSearch.IconSize = 30;
            this.btnSearch.Location = new System.Drawing.Point(784, 25);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(51, 35);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.BackColor = System.Drawing.Color.Gainsboro;
            this.comboBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "ALL"});
            this.comboBox2.Location = new System.Drawing.Point(598, 27);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(166, 37);
            this.comboBox2.TabIndex = 2;
            this.comboBox2.Tag = "";
            this.comboBox2.Text = "Employee";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.iconButton1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(886, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 96);
            this.panel2.TabIndex = 1;
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.RoyalBlue;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.ForeColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 20;
            this.iconButton1.Location = new System.Drawing.Point(21, 22);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(151, 41);
            this.iconButton1.TabIndex = 3;
            this.iconButton1.Text = "New Project";
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "ALL",
            "In Progress",
            "On Hold",
            "Completed",
            "Canceled"});
            this.comboBox1.Location = new System.Drawing.Point(394, 28);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(198, 37);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.Text = "Status";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(32, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(356, 34);
            this.textBox1.TabIndex = 0;
            this.textBox1.Tag = "";
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 96);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(34, 416);
            this.panel3.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(1052, 96);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(34, 416);
            this.panel4.TabIndex = 2;
            // 
            // grDataProject
            // 
            this.grDataProject.BackgroundColor = System.Drawing.Color.White;
            this.grDataProject.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grDataProject.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grDataProject.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grDataProject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grDataProject.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.projectName,
            this.PM,
            this.Group,
            this.Status,
            this.Document,
            this.File,
            this.pTineline,
            this.endDate,
            this.DAYS,
            this.task,
            this.fix,
            this.dek});
            this.grDataProject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grDataProject.Location = new System.Drawing.Point(34, 96);
            this.grDataProject.Name = "grDataProject";
            this.grDataProject.RowHeadersWidth = 51;
            this.grDataProject.RowTemplate.Height = 24;
            this.grDataProject.Size = new System.Drawing.Size(1018, 416);
            this.grDataProject.TabIndex = 3;
            this.grDataProject.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.grDataProject.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grDataProject_CellContentDoubleClick);
            this.grDataProject.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grDataProject_RowHeaderMouseDoubleClick);
            // 
            // projectName
            // 
            this.projectName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.projectName.DataPropertyName = "PN";
            this.projectName.FillWeight = 99.22757F;
            this.projectName.HeaderText = "PROJECT NAME";
            this.projectName.MinimumWidth = 6;
            this.projectName.Name = "projectName";
            this.projectName.ReadOnly = true;
            this.projectName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // PM
            // 
            this.PM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PM.DataPropertyName = "PM";
            this.PM.FillWeight = 99.22757F;
            this.PM.HeaderText = "PM";
            this.PM.MinimumWidth = 6;
            this.PM.Name = "PM";
            this.PM.ReadOnly = true;
            // 
            // Group
            // 
            this.Group.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Group.DataPropertyName = "GROUP";
            this.Group.FillWeight = 99.22757F;
            this.Group.HeaderText = "GROUP";
            this.Group.MinimumWidth = 6;
            this.Group.Name = "Group";
            this.Group.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Status.DataPropertyName = "STATUS";
            this.Status.FillWeight = 99.22757F;
            this.Status.HeaderText = "STATUS";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Width = 125;
            // 
            // Document
            // 
            this.Document.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Document.DataPropertyName = "DOCUMENT";
            this.Document.FillWeight = 99.22757F;
            this.Document.HeaderText = "DOCUMENT";
            this.Document.MinimumWidth = 6;
            this.Document.Name = "Document";
            this.Document.ReadOnly = true;
            this.Document.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Document.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Document.Width = 110;
            // 
            // File
            // 
            this.File.DataPropertyName = "FILE";
            this.File.FillWeight = 106.9519F;
            this.File.HeaderText = "FILE";
            this.File.MinimumWidth = 6;
            this.File.Name = "File";
            this.File.ReadOnly = true;
            this.File.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.File.Width = 50;
            // 
            // pTineline
            // 
            this.pTineline.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.pTineline.DataPropertyName = "STD";
            this.pTineline.FillWeight = 99.22757F;
            this.pTineline.HeaderText = "START DATE";
            this.pTineline.MinimumWidth = 6;
            this.pTineline.Name = "pTineline";
            this.pTineline.ReadOnly = true;
            this.pTineline.Width = 120;
            // 
            // endDate
            // 
            this.endDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.endDate.DataPropertyName = "ED";
            this.endDate.HeaderText = "END DATE";
            this.endDate.MinimumWidth = 6;
            this.endDate.Name = "endDate";
            this.endDate.Width = 125;
            // 
            // DAYS
            // 
            this.DAYS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.DAYS.DataPropertyName = "DAYS";
            this.DAYS.FillWeight = 99.22757F;
            this.DAYS.HeaderText = "DAYS";
            this.DAYS.MinimumWidth = 6;
            this.DAYS.Name = "DAYS";
            this.DAYS.ReadOnly = true;
            this.DAYS.Width = 80;
            // 
            // task
            // 
            this.task.DataPropertyName = "TASK";
            this.task.HeaderText = "TASK";
            this.task.MinimumWidth = 6;
            this.task.Name = "task";
            this.task.ReadOnly = true;
            this.task.Width = 80;
            // 
            // fix
            // 
            this.fix.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.fix.FillWeight = 99.22757F;
            this.fix.HeaderText = "CHANGE";
            this.fix.MinimumWidth = 6;
            this.fix.Name = "fix";
            this.fix.ReadOnly = true;
            this.fix.Text = "Change";
            this.fix.UseColumnTextForButtonValue = true;
            this.fix.Width = 80;
            // 
            // dek
            // 
            this.dek.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dek.FillWeight = 99.22757F;
            this.dek.HeaderText = "DEL";
            this.dek.MinimumWidth = 6;
            this.dek.Name = "dek";
            this.dek.ReadOnly = true;
            this.dek.Text = "DEL";
            this.dek.UseColumnTextForButtonValue = true;
            this.dek.Width = 50;
            // 
            // Project
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1086, 512);
            this.Controls.Add(this.grDataProject);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Project";
            this.Text = "Project";
            this.Load += new System.EventHandler(this.Project_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grDataProject)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton btnSearch;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView grDataProject;
        private System.Windows.Forms.DataGridViewTextBoxColumn projectName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PM;
        private System.Windows.Forms.DataGridViewTextBoxColumn Group;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewLinkColumn Document;
        private System.Windows.Forms.DataGridViewTextBoxColumn File;
        private System.Windows.Forms.DataGridViewTextBoxColumn pTineline;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn DAYS;
        private System.Windows.Forms.DataGridViewTextBoxColumn task;
        private System.Windows.Forms.DataGridViewButtonColumn fix;
        private System.Windows.Forms.DataGridViewButtonColumn dek;
    }
}