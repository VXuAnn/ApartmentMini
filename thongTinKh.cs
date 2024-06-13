using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApartmentMini_Management_System
{
    public partial class thongTinKh : Form
    {
        public thongTinKh()
        {
            InitializeComponent();
        }
        SqlConnection conec = null;
        string stronic = @"Data Source=VUAN;Initial Catalog=APARTMENT;Integrated Security=True;";
        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void hienThiKhachHang()
        {
            if (conec == null)
            {
                conec = new SqlConnection(stronic);
            }
            if (conec.State == ConnectionState.Closed)
            {
                conec.Open();
            }
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "dsKH";
            command.Connection=conec;
            SqlDataReader reader =command.ExecuteReader();
            dataGridView1.Rows.Clear();
            while(reader.Read())
            {
                string col1 = reader.GetString(0); // Ví dụ: Cột đầu tiên
                string col2 = reader.GetString(1);
                DateTime col3 = reader.GetDateTime(2);// Ví dụ: Cột thứ hai
               
                string col4 = reader.GetString(3); // Ví dụ: Cột thứ hai
                string col5 = reader.GetString(4); // Ví dụ: Cột thứ hai
                string col6 = reader.GetString(5); // Ví dụ: Cột thứ hai
                bool bitValue = reader.IsDBNull(6) ? false : reader.GetBoolean(6);

                string col7 = bitValue ? "Nam" : "Nữ";
                DateTime col8 = reader.GetDateTime(7);
                dataGridView1.Rows.Add(col1, col2, col3, col4,col5, col6,col7, col8);
            }
        }

        private void thongTinKh_Load(object sender, EventArgs e)
        {
            hienThiKhachHang();
        }
    }
}
