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
    public partial class thietBi : Form
    {
        public thietBi()
        {
            InitializeComponent();
        }
        SqlConnection conec = null;
        string stronic = @"Data Source=VUAN;Initial Catalog=APARTMENT;Integrated Security=True;";
        private void thietBi_Load(object sender, EventArgs e)
        {
            hienThiTb();
        }

        private void hienThiTb()
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
            command.CommandText = "dsTB";
            command.Connection = conec;
            SqlDataReader reader = command.ExecuteReader();
            dataGridView2.Rows.Clear();
            while (reader.Read())
            {
                string col1 = reader.GetString(0); // Ví dụ: Cột đầu tiên
                string col2 = reader.GetString(1);
                double col3 = reader.GetDouble(2);

                int col4 = reader.GetInt32(3);
                bool bitValue = reader.GetBoolean(4);
                string col5 = bitValue ? "Tốt" : "Hỏng";
                string col6 = reader.GetString(5); // Ví dụ: Cột thứ hai
                
                dataGridView2.Rows.Add(col1, col2, col3, col4, col5, col6);
            }
        }
    }
}
