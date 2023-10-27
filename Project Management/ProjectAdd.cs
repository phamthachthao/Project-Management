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
    public partial class ProjectAdd : Form
    {
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();
        string sql;
        string MaNhomTruonng;
        string connectionstring = "Data Source=DESKTOP-LOC1JBM\\SQLEXPRESS1;Initial Catalog=QuanLyDuAn;Integrated Security=True";

        public ProjectAdd()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void ProjectAdd_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionstring);
            con.Open();

            // Thực hiện truy vấn SQL để lấy dữ liệu
            string query = "SELECT * FROM NHOM";
            SqlCommand cmd = new SqlCommand(query, con);

            // Sử dụng SqlDataReader để đọc dữ liệu từ kết quả truy vấn
            SqlDataReader reader = cmd.ExecuteReader();

            // Xóa các mục cũ trong ComboBox
            cmbGr.Items.Clear();

            // Duyệt qua từng dòng dữ liệu và thêm vào ComboBox
            while (reader.Read())
            {
                string TenNhom = reader.GetString(1);
                MaNhomTruonng = reader.GetString(3);
                // Thêm vào ComboBox
                cmbGr.Items.Add(TenNhom);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProjectAddFile f = new ProjectAddFile();
            f.Show();
        }
    }
}
