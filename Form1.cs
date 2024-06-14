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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private Form currentFormChild;
        private void openChildForm(Form childForm)
        {
            if(currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel =false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel2.Controls.Add(childForm);
            panel2.Tag=childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            openChildForm(new Trangchu());
            label1.Text = button1.Text;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            openChildForm(new Phong());
            label1.Text = buttonPhong.Text;
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {
                
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonDv_Click(object sender, EventArgs e)
        {
            openChildForm(new DichVu());
            label1.Text = buttonDv.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            openChildForm(new chiSoDien());
            label1.Text = button4.Text;
        }

        private void buttonDatphong_Click(object sender, EventArgs e)
        {
            openChildForm(new chiSoNuoc());
            label1.Text = buttonDatphong.Text;
        }

        private void buttonSetting_Click(object sender, EventArgs e)
        {
            openChildForm(new tinhTien());
            label1.Text = buttonSetting.Text;
        }

        private void buttonPhat_Click(object sender, EventArgs e)
        {
            openChildForm(new phieuPhat());
            label1.Text = buttonPhat.Text;
        }

        private void buttonTB_Click(object sender, EventArgs e)
        {
            openChildForm(new thietBi());
            label1.Text = buttonTB.Text;
        }

        private void buttonKH_Click(object sender, EventArgs e)
        {
            openChildForm(new thongTinKh());
            label1.Text = buttonKH.Text;
        }

        private void buttonHoaDon_Click(object sender, EventArgs e)
        {
            openChildForm(new huyDK());
            label1.Text = buttonHoaDon.Text;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
