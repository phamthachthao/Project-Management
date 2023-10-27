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
    public partial class Project : Form
    {
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();
        string sql;
        string connectionstring = "Data Source=DESKTOP-LOC1JBM\\SQLEXPRESS1;Initial Catalog=QuanLyDuAn;Integrated Security=True";

        public Project()
        {
            InitializeComponent();

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            ProjectAdd adpj = new ProjectAdd();
            adpj.Show();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Project_Load(object sender, EventArgs e)
        {
            
        }
        private void ketnoicsdl()
        {
            SqlConnection con = new SqlConnection(connectionstring);
            con.Open();

            try
            {
                // ... Code lấy dữ liệu ...
                sql = "SELECT DUAN.TenDA AS 'PN', NHANVIEN.TenNV AS 'PM', NHOM.TenNhom AS 'GROUP', DUAN.TrangThai AS 'STATUS', 'Open file' AS 'DOCUMENT', COUNT(TAILIEU.MaTL) AS 'FILE', DUAN.ThoiGianBD AS 'STD', DUAN.ThoiGianKT AS 'ED', CASE WHEN GETDATE() < DUAN.ThoiGianBD THEN CONCAT('0/', DATEDIFF(day, DUAN.ThoiGianBD, DUAN.ThoiGianKT)) WHEN GETDATE() > DUAN.ThoiGianKT THEN CONCAT(DATEDIFF(day, DUAN.ThoiGianBD, DUAN.ThoiGianKT), '/', DATEDIFF(day, DUAN.ThoiGianBD, DUAN.ThoiGianKT)) ELSE CONCAT(DATEDIFF(day, DUAN.ThoiGianBD, GETDATE()), '/', DATEDIFF(day, DUAN.ThoiGianBD, DUAN.ThoiGianKT)) END AS 'DAYS', COUNT(NHIEMVU.MaNhiemVu) AS 'TASK' FROM DUAN JOIN NHOM ON DUAN.MaNhom = NHOM.MaNhom JOIN NHANVIEN ON NHOM.MaNhomTruong = NHANVIEN.MaNV LEFT JOIN TAILIEU ON DUAN.MaDA = TAILIEU.MaDA LEFT JOIN NHIEMVU ON DUAN.MaDA = NHIEMVU.MaDA GROUP BY DUAN.TenDA, NHANVIEN.TenNV, NHOM.TenNhom, DUAN.TrangThai, NHANVIEN.ViTri, DUAN.ThoiGianBD, DUAN.ThoiGianKT;";

                SqlCommand cmd = new SqlCommand(sql, con);
                da = new SqlDataAdapter(cmd);

                da.Fill(dt);
                grDataProject.DataSource = dt;
                grDataProject.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            con.Close();
        }

        private void Project_Load_1(object sender, EventArgs e)
        {
            ketnoicsdl();
        }

        private void grDataProject_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
        }

        private void grDataProject_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Lấy giá trị từ ô được nhấp đúp
                var cellValue = grDataProject.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();

                // Mở Form mới và chuyển giá trị cần thiết
                ProjectDep a = new ProjectDep(cellValue);
                a.Show();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
