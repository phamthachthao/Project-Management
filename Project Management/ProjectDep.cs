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
    public partial class ProjectDep : Form
    {
        public string PN;
        public ProjectDep(string cellValue)
        {
            InitializeComponent();
            this.PN = cellValue;
        }

        private void ProjectDep_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-LOC1JBM\\SQLEXPRESS1;Initial Catalog=QuanLyDuAn;Integrated Security=True";
            con.Open();

            string sqlQuery = "SELECT * FROM DUAN WHERE TenDA = '" + PN + "'";
            using (SqlCommand command = new SqlCommand(sqlQuery, con))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string Mota = reader["MoTa"].ToString();
                        txtPN.Text = PN;
                        txtDep.Text = Mota;
                    }
                }
            }
        }
    }
}
