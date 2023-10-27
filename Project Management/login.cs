using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace Project_Management
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
        


        private void button3_Click(object sender, EventArgs e)
        {
            if(tbEmail.Text =="")
            {
                MessageBox.Show("Enter your Email!");
            }    
            else if(tbPass.Text =="")
            {
                MessageBox.Show("Enter your Password!");
            }
            else
            {
                string email = tbEmail.Text;
                string passWord = tbPass.Text;

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=DESKTOP-LOC1JBM\\SQLEXPRESS1;Initial Catalog=QuanLyDuAn;Integrated Security=True";
                con.Open();

                SqlCommand loginCmd = new SqlCommand("Select Email, MatKhau from NHANVIEN where Email='" + tbEmail.Text + "'and MatKhau='" + tbPass.Text + "'", con);
                SqlDataAdapter loginAdapter = new SqlDataAdapter(loginCmd);
                DataTable loginDt = new DataTable();
                loginAdapter.Fill(loginDt);

                if (loginDt.Rows.Count > 0)
                {
                    main mainForm = new main(email);
                    this.Hide();
                    mainForm.Show();
                    
                }
                else
                {
                    MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu, xin kiểm tra lại");
                }
                con.Close();
            }    
            
        }

        private void login_Load(object sender, EventArgs e)
        {
            
        }
    }
}
