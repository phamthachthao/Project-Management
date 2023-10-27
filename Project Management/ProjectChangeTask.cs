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
    public partial class ProjectChangeTask : Form
    {
        string PName, TName;
        public ProjectChangeTask(string PN, string TN)
        {
            InitializeComponent();
            this.PName = PN;
            this.TName = TN;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void ProjectChangeTask_Load(object sender, EventArgs e)
        {
            txtPN.Text = PName;
            txtTN.Text = TName;

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-LOC1JBM\\SQLEXPRESS1;Initial Catalog=QuanLyDuAn;Integrated Security=True";
            con.Open();

            string sqlQuery = "SELECT  NV.TenNV AS TenNhanVien,NV.MucDoUuTien,NV.GhiChu,NV.ThoiGianBD,NV.ThoiGianKT,NVU.TenNhiemVu FROM NHIEMVU NVU JOIN NHANVIEN NV ON NVU.MaNV = NV.MaNV JOIN DUAN DA ON NVU.MaDA = DA.MaDA WHERE NVU.TenNhiemVu = '"+TName+"' AND DA.TenDA = '"+PName+"'";
            using (SqlCommand command = new SqlCommand(sqlQuery, con))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string Note = reader["GhiChu"].ToString();
                        string TenNV = reader["TenNhanVien"].ToString();
                        string Status = reader["MucDoUuTien"].ToString();
                        DateTime S = Convert.ToDateTime(reader["ThoiGianBD"]);
                        DateTime E = Convert.ToDateTime(reader["ThoiGianKT"]);

                        txtNote.Text = Note;
                        txtP.Text = TenNV;
                        cmbStatus.Text = Status;

                        Sdate.Value = S;
                        Edate.Value = E;
                    }
                }
            }
        }
    }
}
