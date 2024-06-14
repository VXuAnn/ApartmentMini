using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ApartmentMini_Management_System
{
    public partial class tThongPhong : UserControl
    {
        public tThongPhong()
        {
            InitializeComponent();
        }
        public void UpdateInfo(string maSoPhong, string loaiPhong, string hoTen, string gia)
        {
            textBox1.Text = maSoPhong;
            textBox2.Text = loaiPhong;
            textBox3.Text = hoTen;
            textBox4.Text = gia + " vnđ";
        }
        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void tThongPhong_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
