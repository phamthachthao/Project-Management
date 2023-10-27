
namespace Project_Management
{
    partial class Employee
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.grDataEmp = new System.Windows.Forms.DataGridView();
            this.pic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.project = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.work = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.task = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Change = new System.Windows.Forms.DataGridViewButtonColumn();
            this.del = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grDataEmp)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(941, 84);
            this.panel1.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.iconButton1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(686, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(255, 84);
            this.panel5.TabIndex = 9;
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
            this.iconButton1.Location = new System.Drawing.Point(38, 22);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(162, 41);
            this.iconButton1.TabIndex = 8;
            this.iconButton1.Text = "Add Employee";
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 84);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(34, 550);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(907, 84);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(34, 550);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.grDataEmp);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(34, 84);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(873, 550);
            this.panel4.TabIndex = 3;
            // 
            // grDataEmp
            // 
            this.grDataEmp.BackgroundColor = System.Drawing.Color.White;
            this.grDataEmp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grDataEmp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grDataEmp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pic,
            this.name,
            this.gender,
            this.email,
            this.dob,
            this.role,
            this.project,
            this.work,
            this.task,
            this.Change,
            this.del});
            this.grDataEmp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grDataEmp.Location = new System.Drawing.Point(0, 0);
            this.grDataEmp.Name = "grDataEmp";
            this.grDataEmp.RowHeadersWidth = 51;
            this.grDataEmp.RowTemplate.Height = 24;
            this.grDataEmp.Size = new System.Drawing.Size(873, 550);
            this.grDataEmp.TabIndex = 0;
            // 
            // pic
            // 
            this.pic.HeaderText = "";
            this.pic.MinimumWidth = 6;
            this.pic.Name = "pic";
            this.pic.Width = 50;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.HeaderText = "NAME";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // gender
            // 
            this.gender.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.gender.HeaderText = "GENDER";
            this.gender.MinimumWidth = 6;
            this.gender.Name = "gender";
            this.gender.ReadOnly = true;
            this.gender.Width = 125;
            // 
            // email
            // 
            this.email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.email.HeaderText = "EMAIL";
            this.email.MinimumWidth = 6;
            this.email.Name = "email";
            this.email.ReadOnly = true;
            // 
            // dob
            // 
            this.dob.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dob.HeaderText = "DATE OF BIRTH";
            this.dob.MinimumWidth = 6;
            this.dob.Name = "dob";
            this.dob.ReadOnly = true;
            // 
            // role
            // 
            this.role.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.role.HeaderText = "ROLE";
            this.role.MinimumWidth = 6;
            this.role.Name = "role";
            this.role.ReadOnly = true;
            // 
            // project
            // 
            this.project.HeaderText = "PROJECT";
            this.project.MinimumWidth = 6;
            this.project.Name = "project";
            this.project.Width = 90;
            // 
            // work
            // 
            this.work.HeaderText = "Tiến trình (sẽ xóa)";
            this.work.MinimumWidth = 6;
            this.work.Name = "work";
            this.work.ReadOnly = true;
            this.work.Width = 200;
            // 
            // task
            // 
            this.task.HeaderText = "TASK";
            this.task.MinimumWidth = 6;
            this.task.Name = "task";
            this.task.ReadOnly = true;
            this.task.Width = 90;
            // 
            // Change
            // 
            this.Change.HeaderText = "CHANGE";
            this.Change.MinimumWidth = 6;
            this.Change.Name = "Change";
            this.Change.ReadOnly = true;
            this.Change.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Change.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Change.Width = 80;
            // 
            // del
            // 
            this.del.HeaderText = "DEL";
            this.del.MinimumWidth = 6;
            this.del.Name = "del";
            this.del.ReadOnly = true;
            this.del.Width = 50;
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(941, 634);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Employee";
            this.Text = "Employee";
            this.Load += new System.EventHandler(this.Employee_Load);
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grDataEmp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView grDataEmp;
        private System.Windows.Forms.DataGridViewTextBoxColumn pic;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn dob;
        private System.Windows.Forms.DataGridViewTextBoxColumn role;
        private System.Windows.Forms.DataGridViewTextBoxColumn project;
        private System.Windows.Forms.DataGridViewTextBoxColumn work;
        private System.Windows.Forms.DataGridViewTextBoxColumn task;
        private System.Windows.Forms.DataGridViewButtonColumn Change;
        private System.Windows.Forms.DataGridViewButtonColumn del;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Panel panel5;
    }
}