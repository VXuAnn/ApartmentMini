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
    public partial class DichVu : Form
    {
        public DichVu()
        {
            InitializeComponent();
        }
        SqlConnection conec = null;
        string stronic = @"Data Source=VUAN;Initial Catalog=APARTMENT;Integrated Security=True;";


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Themdv themdvForm = new Themdv();
            themdvForm.Show();
        }

        private void DichVu_Load(object sender, EventArgs e)
        {
            hienThiDV();
        }

        private void hienThiDV()
        {
            if(conec == null)
            {
                conec = new SqlConnection(stronic); 
            }
            if(conec.State==ConnectionState.Closed) { 
                conec.Open();
            }
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "ttDV";
            cmd.Connection = conec;
            SqlDataReader reader = cmd.ExecuteReader();
            dataGridView1.Rows.Clear();
            while (reader.Read())
            {
                string col1 = reader.GetString(0); 
                double col2 = reader.GetDouble(1);

                dataGridView1.Rows.Add(col1, col2);
            }
        }
    }
}
