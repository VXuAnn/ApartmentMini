using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApartmentMini_Management_System
{
    public partial class Trangchu : Form
    {
        
       /* public Trangchu()
        {
            InitializeComponent();
            dataGridView1.Columns.Add("Phòng", "Phòng");
            dataGridView1.Columns.Add("Loại phòng", "Loại phòng");

            // Khởi tạo các cột cho dataGridView2
            dataGridView2.Columns.Add("Phòng", "Phòng");
            dataGridView2.Columns.Add("Khách", "Khách");
            dataGridView2.Columns.Add("Tháng", "Tháng");
            dataGridView2.Columns.Add("Số tiền", "Số tiền");
        }*/
        public Trangchu()
        {
            InitializeComponent();

            // Khởi tạo các cột cho dataGridView1 và dataGridView2
            InitializeDataGridView1(dataGridView1);
            InitializeDataGridView2(dataGridView2);
        }
        private void InitializeDataGridView1(DataGridView dataGridView)
        {
            // Add các cột cho dataGridView
            dataGridView.Columns.Add("Phòng", "Phòng");
            dataGridView.Columns.Add("Loại phòng", " Loại phòng");
       
            // Đặt AutoSizeMode của mỗi cột thành Fill
            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }
        private void InitializeDataGridView2(DataGridView dataGridView)
        {
            // Add các cột cho dataGridView
            dataGridView.Columns.Add("Phòng", "Phòng");
            dataGridView.Columns.Add("Khách", "Khách");
            dataGridView.Columns.Add("Tháng", "Tháng");
            dataGridView.Columns.Add("Số tiền", "Số tiền");

            // Đặt AutoSizeMode của mỗi cột thành Fill
            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
