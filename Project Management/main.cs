using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using System.Data.SqlClient;


namespace Project_Management
{
    public partial class main : Form
    {
        private IconButton currenttBtn;
        private Form currentChildForm;
        public string email;

        public main(string userEmail)
        {
            InitializeComponent();
            this.email = userEmail;
        }

        //hieu ung btn - active
        private void ActivateBtn (object senderBtn)
        {
            DisableBtn();
            if(senderBtn != null)
            {
                currenttBtn = (IconButton)senderBtn;
                currenttBtn.BackColor = Color.FromArgb(255, 255, 255);
                currenttBtn.ForeColor = Color.FromArgb(0, 0, 0);
                currenttBtn.IconColor = Color.FromArgb(0,0,0);
            }    
        }

        private void DisableBtn()
        {
            if (currenttBtn != null)
            {
                currenttBtn.BackColor = Color.MidnightBlue;
                currenttBtn.ForeColor = Color.White;
                currenttBtn.IconColor = Color.White;
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            ActivateBtn(sender);
            OpenChildForm(new Project());
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            ActivateBtn(sender);
            OpenChildForm(new Task());

        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            ActivateBtn(sender);
            OpenChildForm(new Employee());
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            ActivateBtn(sender);
            OpenChildForm(new Report());

        }

        //xu ly do cot
        bool expand = false;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if(expand == false)
            {
                dropdownContainer.Height += 15;
                if (dropdownContainer.Height >= dropdownContainer.MaximumSize.Height)
                {
                    timer1.Stop();
                    expand = true;
                }    
            }   
            else
            {
                dropdownContainer.Height -= 15;
                if (dropdownContainer.Height <= dropdownContainer.MinimumSize.Height)
                {
                    timer1.Stop();
                    expand = false;
                    DisableBtn();
                }    
            }
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            timer1.Start();
            ActivateBtn(sender);
        }

        //mo form
        private void OpenChildForm (Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            TitleForm.Text = childForm.Text;
        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            
        }

        private void iconButton6_Click_1(object sender, EventArgs e)
        {
            
        }

        private void iconButton6_Click_2(object sender, EventArgs e)
        {
            ActivateBtn(sender);
            OpenChildForm(new Account());
        }

        private void iconButton7_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Password());
            ActivateBtn(sender);
        }

        //logout click
        private void iconButton8_Click(object sender, EventArgs e)
        {
            login login = new login();
            login.Show();
            this.Close();
        }

        private void panelDesktop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconButton9_Click(object sender, EventArgs e)
        {
            ActivateBtn(sender);
            OpenChildForm(new Group());
        }

        private void main_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-LOC1JBM\\SQLEXPRESS1;Initial Catalog=QuanLyDuAn;Integrated Security=True";
            con.Open();

            string sqlQuery = "SELECT * FROM NHANVIEN WHERE Email = '" + email +"'";
            using (SqlCommand command = new SqlCommand(sqlQuery, con))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string ten = reader["TenNV"].ToString();
                        lbEmpName.Text = ten;
                    }
                }
            }
            
        }
    }
}
