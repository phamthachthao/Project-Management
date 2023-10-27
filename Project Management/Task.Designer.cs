
namespace Project_Management
{
    partial class Task
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
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.grDataTask = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.idTask = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taskName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Participants = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priority = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.file = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.days = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.change = new System.Windows.Forms.DataGridViewButtonColumn();
            this.delete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grDataTask)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox3
            // 
            this.comboBox3.BackColor = System.Drawing.Color.Gainsboro;
            this.comboBox3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "ALL"});
            this.comboBox3.Location = new System.Drawing.Point(561, 11);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(232, 37);
            this.comboBox3.TabIndex = 8;
            this.comboBox3.Tag = "";
            this.comboBox3.Text = "Project Name";
            // 
            // iconButton2
            // 
            this.iconButton2.BackColor = System.Drawing.Color.RoyalBlue;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.iconButton2.IconColor = System.Drawing.Color.White;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 30;
            this.iconButton2.Location = new System.Drawing.Point(971, 11);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(51, 35);
            this.iconButton2.TabIndex = 7;
            this.iconButton2.UseVisualStyleBackColor = false;
            // 
            // comboBox2
            // 
            this.comboBox2.BackColor = System.Drawing.Color.Gainsboro;
            this.comboBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "ALL"});
            this.comboBox2.Location = new System.Drawing.Point(799, 11);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(166, 37);
            this.comboBox2.TabIndex = 6;
            this.comboBox2.Tag = "";
            this.comboBox2.Text = "Employee";
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
            this.comboBox1.Location = new System.Drawing.Point(357, 11);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(198, 37);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.Text = "Status";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(339, 34);
            this.textBox1.TabIndex = 4;
            this.textBox1.Tag = "";
            // 
            // grDataTask
            // 
            this.grDataTask.BackgroundColor = System.Drawing.Color.White;
            this.grDataTask.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grDataTask.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grDataTask.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idTask,
            this.projectName,
            this.taskName,
            this.Participants,
            this.status,
            this.priority,
            this.file,
            this.startDate,
            this.endDate,
            this.days,
            this.change,
            this.delete});
            this.grDataTask.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grDataTask.Location = new System.Drawing.Point(0, 0);
            this.grDataTask.Name = "grDataTask";
            this.grDataTask.RowHeadersWidth = 51;
            this.grDataTask.RowTemplate.Height = 24;
            this.grDataTask.Size = new System.Drawing.Size(988, 556);
            this.grDataTask.TabIndex = 0;
            this.grDataTask.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grDataTask_CellContentClick);
            this.grDataTask.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grDataTask_CellContentDoubleClick);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.comboBox3);
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Controls.Add(this.comboBox1);
            this.panel3.Controls.Add(this.iconButton2);
            this.panel3.Controls.Add(this.comboBox2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1056, 76);
            this.panel3.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1022, 76);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(34, 556);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 76);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(34, 556);
            this.panel2.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.grDataTask);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(34, 76);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(988, 556);
            this.panel4.TabIndex = 4;
            // 
            // idTask
            // 
            this.idTask.DataPropertyName = "ID TASK";
            this.idTask.HeaderText = "ID TASK";
            this.idTask.MinimumWidth = 6;
            this.idTask.Name = "idTask";
            this.idTask.ReadOnly = true;
            this.idTask.Width = 90;
            // 
            // projectName
            // 
            this.projectName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.projectName.DataPropertyName = "PROJECT NAME";
            this.projectName.HeaderText = "PROJECT NAME";
            this.projectName.MinimumWidth = 6;
            this.projectName.Name = "projectName";
            this.projectName.ReadOnly = true;
            // 
            // taskName
            // 
            this.taskName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.taskName.DataPropertyName = "TASK NAME";
            this.taskName.HeaderText = "TASK NAME";
            this.taskName.MinimumWidth = 6;
            this.taskName.Name = "taskName";
            this.taskName.ReadOnly = true;
            // 
            // Participants
            // 
            this.Participants.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Participants.DataPropertyName = "PATICIPANTS";
            this.Participants.HeaderText = "PATICIPANTS";
            this.Participants.MinimumWidth = 6;
            this.Participants.Name = "Participants";
            this.Participants.ReadOnly = true;
            // 
            // status
            // 
            this.status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.status.DataPropertyName = "STATUS";
            this.status.HeaderText = "STATUS";
            this.status.MinimumWidth = 6;
            this.status.Name = "status";
            this.status.ReadOnly = true;
            this.status.Width = 90;
            // 
            // priority
            // 
            this.priority.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.priority.DataPropertyName = "PRIORITY LEVEL";
            this.priority.HeaderText = "PRIORITY LEVEL";
            this.priority.MinimumWidth = 6;
            this.priority.Name = "priority";
            this.priority.ReadOnly = true;
            // 
            // file
            // 
            this.file.DataPropertyName = "FILE";
            this.file.HeaderText = "FILE";
            this.file.MinimumWidth = 6;
            this.file.Name = "file";
            this.file.ReadOnly = true;
            this.file.Width = 50;
            // 
            // startDate
            // 
            this.startDate.DataPropertyName = "START DATE";
            this.startDate.HeaderText = "START DATE";
            this.startDate.MinimumWidth = 6;
            this.startDate.Name = "startDate";
            this.startDate.Width = 125;
            // 
            // endDate
            // 
            this.endDate.DataPropertyName = "END DATE";
            this.endDate.HeaderText = "END DATE";
            this.endDate.MinimumWidth = 6;
            this.endDate.Name = "endDate";
            this.endDate.Width = 125;
            // 
            // days
            // 
            this.days.DataPropertyName = "DAYS";
            this.days.HeaderText = "DAYS";
            this.days.MinimumWidth = 6;
            this.days.Name = "days";
            this.days.ReadOnly = true;
            this.days.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.days.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.days.Width = 90;
            // 
            // change
            // 
            this.change.HeaderText = "CHANGE";
            this.change.MinimumWidth = 6;
            this.change.Name = "change";
            this.change.ReadOnly = true;
            this.change.Text = "Change";
            this.change.UseColumnTextForButtonValue = true;
            this.change.Width = 80;
            // 
            // delete
            // 
            this.delete.HeaderText = "DEL";
            this.delete.MinimumWidth = 6;
            this.delete.Name = "delete";
            this.delete.ReadOnly = true;
            this.delete.Text = "Del";
            this.delete.UseColumnTextForButtonValue = true;
            this.delete.Width = 50;
            // 
            // Task
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1056, 632);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Task";
            this.Text = "Task";
            this.Load += new System.EventHandler(this.Task_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grDataTask)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private FontAwesome.Sharp.IconButton iconButton2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.DataGridView grDataTask;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTask;
        private System.Windows.Forms.DataGridViewTextBoxColumn projectName;
        private System.Windows.Forms.DataGridViewTextBoxColumn taskName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Participants;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn priority;
        private System.Windows.Forms.DataGridViewTextBoxColumn file;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn days;
        private System.Windows.Forms.DataGridViewButtonColumn change;
        private System.Windows.Forms.DataGridViewButtonColumn delete;
    }
}