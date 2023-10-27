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
    public partial class Employee : Form
    {
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();
        string sql;
        string connectionstring = "Data Source=DESKTOP-LOC1JBM\\SQLEXPRESS1;Initial Catalog=QuanLyDuAn;Integrated Security=True";

        public Employee()
        {
            InitializeComponent();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            EmployeeAdd emadd = new EmployeeAdd();
            emadd.Show();
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            ketnoicsdl();
        }

        private void ketnoicsdl()
        {
            SqlConnection con = new SqlConnection(connectionstring);
            con.Open();

            try
            {
                // ... Code lấy dữ liệu ...
                sql = "SELECT DA.TenDA AS 'PROJECT NAME', NVU.TenNhiemVu AS 'TASK NAME', NV.TenNV AS 'PATICIPANTS', DA.TrangThai AS 'STATUS', NVU.MucDoUuTien AS 'PRIORITY LEVEL', COUNT(TL.MaTL) AS 'FILE', NVU.ThoiGianBD AS 'START DATE', NVU.ThoiGianKT AS 'END DATE', CASE WHEN GETDATE() < NVU.ThoiGianBD THEN '0/' + CONVERT(VARCHAR, DATEDIFF(day, NVU.ThoiGianBD, NVU.ThoiGianKT)) WHEN GETDATE() > NVU.ThoiGianKT THEN CONVERT(VARCHAR, DATEDIFF(day, NVU.ThoiGianBD, NVU.ThoiGianKT)) + '/' + CONVERT(VARCHAR, DATEDIFF(day, NVU.ThoiGianBD, NVU.ThoiGianKT)) ELSE CONVERT(VARCHAR, DATEDIFF(day, NVU.ThoiGianBD, GETDATE())) + '/' + CONVERT(VARCHAR, DATEDIFF(day, NVU.ThoiGianBD, NVU.ThoiGianKT)) END AS 'DAYS' FROM NHIEMVU NVU JOIN NHANVIEN NV ON NVU.MaNV = NV.MaNV JOIN DUAN DA ON NVU.MaDA = DA.MaDA LEFT JOIN TAILIEU TL ON NVU.MaDA = TL.MaDA GROUP BY DA.TenDA, NVU.TenNhiemVu, NV.TenNV, DA.TrangThai, NVU.MucDoUuTien, NVU.ThoiGianBD, NVU.ThoiGianKT ORDER BY NVU.ThoiGianKT;";
                SqlCommand cmd = new SqlCommand(sql, con);
                da = new SqlDataAdapter(cmd);

                da.Fill(dt);
                grDataEmp.DataSource = dt;
                grDataEmp.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            con.Close();
        }
    }
}
