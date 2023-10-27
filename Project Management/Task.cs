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
    public partial class Task : Form
    {
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();
        string sql;
        string connectionstring = "Data Source=DESKTOP-LOC1JBM\\SQLEXPRESS1;Initial Catalog=QuanLyDuAn;Integrated Security=True";
        public Task()
        {
            InitializeComponent();
        }

        private void Task_Load(object sender, EventArgs e)
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
                sql = "SELECT NVU.MaNhiemVu as 'ID TASK', DA.TenDA AS 'PROJECT NAME', NVU.TenNhiemVu AS 'TASK NAME', NV.TenNV AS 'PATICIPANTS', DA.TrangThai AS 'STATUS', NVU.MucDoUuTien AS 'PRIORITY LEVEL', COUNT(TL.MaTL) AS 'FILE', NVU.ThoiGianBD AS 'START DATE', NVU.ThoiGianKT AS 'END DATE', CASE WHEN GETDATE() < NVU.ThoiGianBD THEN '0/' + CONVERT(VARCHAR, DATEDIFF(day, GETDATE(), NVU.ThoiGianBD)) WHEN GETDATE() > NVU.ThoiGianKT THEN CONVERT(VARCHAR, DATEDIFF(day, NVU.ThoiGianBD, NVU.ThoiGianKT)) + '/' + CONVERT(VARCHAR, DATEDIFF(day, NVU.ThoiGianBD, NVU.ThoiGianKT)) ELSE CONVERT(VARCHAR, DATEDIFF(day, GETDATE(), NVU.ThoiGianKT)) + '/' + CONVERT(VARCHAR, DATEDIFF(day, NVU.ThoiGianBD, NVU.ThoiGianKT)) END AS 'DAYS' FROM NHIEMVU NVU JOIN NHANVIEN NV ON NVU.MaNV = NV.MaNV JOIN DUAN DA ON NVU.MaDA = DA.MaDA LEFT JOIN TAILIEU TL ON NVU.MaDA = TL.MaDA GROUP BY NVU.MaNhiemVu, DA.TenDA, DA.TrangThai, NVU.TenNhiemVu, NV.TenNV, NVU.MucDoUuTien, NVU.ThoiGianBD, NVU.ThoiGianKT ORDER BY NVU.ThoiGianKT; ";
                SqlCommand cmd = new SqlCommand(sql, con);
                da = new SqlDataAdapter(cmd);

                da.Fill(dt);
                grDataTask.DataSource = dt;
                //grDataTask.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            con.Close();
        }

        private void grDataTask_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                // Lấy giá trị từ ô được nhấp đúp
                var cellValue = grDataTask.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();


                // Mở Form mới và chuyển giá trị cần thiết
                TaskNote t = new TaskNote(cellValue);
                t.Show();
            }
        }

        private void grDataTask_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = grDataTask.Rows[e.RowIndex];
            string PN, TN;
            PN = Convert.ToString(grDataTask.Rows[e.RowIndex].Cells["projectName"].Value);
            TN = Convert.ToString(grDataTask.Rows[e.RowIndex].Cells["taskName"].Value);

            //Nút xóa
            if (e.ColumnIndex == 1)
            {
                SqlConnection con = new SqlConnection(connectionstring);
                con.Open();

                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa dữ liệu không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        sql = "DELETE FROM NHIEMVU WHERE MaNhiemVu IN(SELECT NHIEMVU.MaNhiemVu FROM NHIEMVU JOIN DUAN ON NHIEMVU.MaDA = DUAN.MaDA WHERE NHIEMVU.TenNhiemVu = '" + TN + "'AND DUAN.TenDA = '" + PN + "')";
                        SqlCommand cmd = new SqlCommand(sql, con);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            grDataTask.Rows.RemoveAt(e.RowIndex);
                            MessageBox.Show("Dữ liệu đã được xóa thành công.");
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy dữ liệu để xóa.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                    con.Close();
                }
                else
                {
                    MessageBox.Show("Dữ liệu không được xóa.");
                }
            }

            //Nút sửa
            if (e.ColumnIndex == 0)
            {
                //ProjectChangeTask p = new ProjectChangeTask(PN, TN);
                //p.Show();
                MessageBox.Show("Button Clicked in Change ");
            }
        }
    }
}
