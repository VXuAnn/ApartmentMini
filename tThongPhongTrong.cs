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
    public partial class tThongPhongTrong : UserControl
    {
        public tThongPhongTrong()
        {
            InitializeComponent();
        }

        public void UpdateInfo2(string maSoPhong, string loaiPhong, string gia)
        {
            textBox1.Text = maSoPhong;
            textBox2.Text = loaiPhong;
            textBox3.Text = gia + " vnđ";
        }
    }
}
