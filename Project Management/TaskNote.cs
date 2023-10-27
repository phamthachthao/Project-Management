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
    public partial class TaskNote : Form
    {
        string TaskID;
        public TaskNote(string cellValue)
        {
            InitializeComponent();
            this.TaskID = cellValue;
        }

        private void TaskNote_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-LOC1JBM\\SQLEXPRESS1;Initial Catalog=QuanLyDuAn;Integrated Security=True";
            con.Open();

            string sqlQuery = "SELECT NV.TenNhiemVu, DA.TenDA, NV.GhiChu FROM NHIEMVU NV JOIN DUAN DA ON NV.MaDA = DA.MaDA WHERE NV.MaNhiemVu = '" + TaskID + "'";
            using (SqlCommand command = new SqlCommand(sqlQuery, con))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string TN = reader["TenNhiemVu"].ToString();
                        txtTN.Text = TN;
                        string Ghichu = reader["GhiChu"].ToString();
                        txtTD.Text = Ghichu;
                    }
                }
            }
            con.Close();
        }
    }
}
