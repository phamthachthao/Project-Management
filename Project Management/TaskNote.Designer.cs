
namespace Project_Management
{
    partial class TaskNote
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtTD = new System.Windows.Forms.TextBox();
            this.txtTN = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 25);
            this.label1.TabIndex = 43;
            this.label1.Text = "Description";
            // 
            // txtTD
            // 
            this.txtTD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTD.Location = new System.Drawing.Point(164, 96);
            this.txtTD.Multiline = true;
            this.txtTD.Name = "txtTD";
            this.txtTD.ReadOnly = true;
            this.txtTD.Size = new System.Drawing.Size(396, 302);
            this.txtTD.TabIndex = 42;
            // 
            // txtTN
            // 
            this.txtTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTN.Location = new System.Drawing.Point(164, 26);
            this.txtTN.Name = "txtTN";
            this.txtTN.ReadOnly = true;
            this.txtTN.Size = new System.Drawing.Size(396, 30);
            this.txtTN.TabIndex = 41;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 25);
            this.label4.TabIndex = 40;
            this.label4.Text = "Task Name";
            // 
            // TaskNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 425);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTD);
            this.Controls.Add(this.txtTN);
            this.Controls.Add(this.label4);
            this.Name = "TaskNote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TaskNote";
            this.Load += new System.EventHandler(this.TaskNote_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTD;
        private System.Windows.Forms.TextBox txtTN;
        private System.Windows.Forms.Label label4;
    }
}