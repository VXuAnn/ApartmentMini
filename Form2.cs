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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private Form currentFormChild;
        bool sidebarExpand;

        bool TimerCheck1,TimerCheck2, TimerCheck3;
        private void openChildForm(Form childForm, Panel panelBody)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelBody.Controls.Add(childForm);
            panelBody.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void panelBody_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            openChildForm(new Phong(), panelBody);

        }
        private void Button2_MouseEnter(object sender, EventArgs e)
        {
            Button2.BackColor = Color.FromArgb(224, 255, 255);
            Button2.ForeColor = Color.FromArgb(24, 103, 206);
        }

        private void Button2_MouseLeave(object sender, EventArgs e)
        {
            Button2.BackColor = Color.FromArgb(249, 251, 252);
            Button2.ForeColor = Color.FromArgb(0,0,0);
        }
        private void Button3_MouseEnter(object sender, EventArgs e)
        {
            TButton2.BackColor = Color.FromArgb(224, 255, 255);
            TButton2.ForeColor = Color.FromArgb(24, 103, 206);
        }

        private void Button3_MouseLeave(object sender, EventArgs e)
        {
            TButton2.BackColor = Color.FromArgb(249, 251, 252);
            TButton2.ForeColor = Color.FromArgb(91, 106, 130);
        }


        private void Button3_Click_1(object sender, EventArgs e)
        {

        }

        private void Button3_MouseEnter_1(object sender, EventArgs e)
        {
            TButton2.ImageAlign = ContentAlignment.MiddleLeft;
            TButton2.BackColor = Color.FromArgb(224, 255, 255);
            TButton2.ForeColor = Color.FromArgb(24, 103, 206);
        }

        private void Button3_MouseLeave_1(object sender, EventArgs e)
        {
            TButton2.ImageAlign = ContentAlignment.MiddleRight;
            TButton2.BackColor = Color.FromArgb(249, 251, 252);
            TButton2.ForeColor = Color.FromArgb(91, 106, 130);
        }

        private void Button4_MouseLeave(object sender, EventArgs e)
        {
            TButton4.ImageAlign = ContentAlignment.MiddleRight;
            TButton4.BackColor = Color.FromArgb(249, 251, 252);
            TButton4.ForeColor = Color.FromArgb(91, 106, 130);
        }
         
        private void Button6_MouseLeave(object sender, EventArgs e)
        {
            DButton1.BackColor = Color.FromArgb(249, 251, 252);
            DButton1.ForeColor = Color.FromArgb(0,0,0);
        }

        private void Button4_MouseEnter(object sender, EventArgs e)
        {
            TButton4.ImageAlign = ContentAlignment.MiddleLeft;
            TButton4.BackColor = Color.FromArgb(224, 255, 255);
            TButton4.ForeColor = Color.FromArgb(24, 103, 206);
        }

        private void Button5_MouseEnter(object sender, EventArgs e)
        {
            MButton1.BackColor = Color.FromArgb(224, 255, 255);
            MButton1.ForeColor = Color.FromArgb(24, 103, 206);
        }

        private void Button6_MouseEnter(object sender, EventArgs e)
        {
            DButton1.BackColor = Color.FromArgb(224, 255, 255);
            DButton1.ForeColor = Color.FromArgb(24, 103, 206);
        }

        private void Button5_MouseLeave(object sender, EventArgs e)
        {
            MButton1.BackColor = Color.FromArgb(249, 251, 252);
            MButton1.ForeColor = Color.FromArgb(0,0,0);
        }

        private void TButton1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(TimerCheck1)
            { 
                    PanelMenu1.Height = PanelMenu1.MaximumSize.Height;
                    TimerCheck1 = false;
                    timer1.Stop(); 
            }
            else
            { 
                    PanelMenu1.Height = PanelMenu1.MinimumSize.Height;
                    TimerCheck1 = true;
                    timer1.Stop(); 
            }
        }

        private void TButton1_MouseEnter(object sender, EventArgs e)
        {
            TButton1.BackColor = Color.FromArgb(224, 255, 255);
            TButton1.ForeColor = Color.FromArgb(24, 103, 206);
        }

        private void TButton1_MouseLeave(object sender, EventArgs e)
        {
            TButton1.BackColor = Color.FromArgb(249, 251, 252);
            TButton1.ForeColor = Color.FromArgb(0, 0, 0);
        }

        private void TButton3_MouseEnter(object sender, EventArgs e)
        {
            TButton3.ImageAlign = ContentAlignment.MiddleLeft;
            TButton3.BackColor = Color.FromArgb(224, 255, 255);
            TButton3.ForeColor = Color.FromArgb(24, 103, 206);
        }

        private void TButton3_MouseLeave(object sender, EventArgs e)
        {
            TButton3.ImageAlign = ContentAlignment.MiddleRight;
            TButton3.BackColor = Color.FromArgb(249, 251, 252);
            TButton3.ForeColor = Color.FromArgb(91, 106, 130);
        }

        private void TButton3_Click(object sender, EventArgs e)
        {

        }

        private void TButton4_Click(object sender, EventArgs e)
        {

        }

        private void MButton2_MouseEnter(object sender, EventArgs e)
        {
            MButton2.ImageAlign = ContentAlignment.MiddleLeft;
            MButton2.BackColor = Color.FromArgb(224, 255, 255);
            MButton2.ForeColor = Color.FromArgb(24, 103, 206);
        }

        private void MButton2_MouseLeave(object sender, EventArgs e)
        {
            MButton2.ImageAlign = ContentAlignment.MiddleRight;
            MButton2.BackColor = Color.FromArgb(249, 251, 252);
            MButton2.ForeColor = Color.FromArgb(91, 106, 130);
        }

        private void TButton5_MouseEnter(object sender, EventArgs e)
        {
            TButton5.ImageAlign = ContentAlignment.MiddleLeft;
            TButton5.BackColor = Color.FromArgb(224, 255, 255);
            TButton5.ForeColor = Color.FromArgb(24, 103, 206);
        }

        private void TButton5_MouseLeave(object sender, EventArgs e)
        {
            TButton5.ImageAlign = ContentAlignment.MiddleRight;
            TButton5.BackColor = Color.FromArgb(249, 251, 252);
            TButton5.ForeColor = Color.FromArgb(91, 106, 130);
        }

        private void rjButton1_MouseEnter(object sender, EventArgs e)
        {
            MButton3.ImageAlign = ContentAlignment.MiddleLeft;
            MButton3.BackColor = Color.FromArgb(224, 255, 255);
            MButton3.ForeColor = Color.FromArgb(24, 103, 206);
        }

        private void MButton3_MouseLeave(object sender, EventArgs e)
        {
            MButton3.ImageAlign = ContentAlignment.MiddleRight;
            MButton3.BackColor = Color.FromArgb(249, 251, 252);
            MButton3.ForeColor = Color.FromArgb(91, 106, 130);
        }

        private void MButton1_Click(object sender, EventArgs e)
        {
            timer2.Start(); 
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {

        }

        private void DButton2_MouseEnter(object sender, EventArgs e)
        {
            DButton2.ImageAlign = ContentAlignment.MiddleLeft;
            DButton2.BackColor = Color.FromArgb(224, 255, 255);
            DButton2.ForeColor = Color.FromArgb(24, 103, 206);
        }

        private void DButton2_MouseLeave(object sender, EventArgs e)
        {
            DButton2.ImageAlign = ContentAlignment.MiddleRight;
            DButton2.BackColor = Color.FromArgb(249, 251, 252);
            DButton2.ForeColor = Color.FromArgb(91, 106, 130);
        }

        private void DButton3_MouseEnter(object sender, EventArgs e)
        {
            DButton3.ImageAlign = ContentAlignment.MiddleLeft;
            DButton3.BackColor = Color.FromArgb(224, 255, 255);
            DButton3.ForeColor = Color.FromArgb(24, 103, 206);
        }

        private void DButton3_MouseLeave(object sender, EventArgs e)
        {
            DButton3.ImageAlign = ContentAlignment.MiddleRight;
            DButton3.BackColor = Color.FromArgb(249, 251, 252);
            DButton3.ForeColor = Color.FromArgb(91, 106, 130);
        }

        private void DButton4_MouseHover(object sender, EventArgs e)
        {

        }

        private void DButton4_MouseEnter(object sender, EventArgs e)
        {
            DButton4.ImageAlign = ContentAlignment.MiddleLeft;
            DButton4.BackColor = Color.FromArgb(224, 255, 255);
            DButton4.ForeColor = Color.FromArgb(24, 103, 206);
        }

        private void DButton4_MouseLeave(object sender, EventArgs e)
        {
            DButton4.ImageAlign = ContentAlignment.MiddleRight;
            DButton4.BackColor = Color.FromArgb(249, 251, 252);
            DButton4.ForeColor = Color.FromArgb(91, 106, 130);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                panelMenu.Width -= 10;
                if (panelMenu.Width == panelMenu.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTimer.Stop();
                }
            }
            else
            {
                panelMenu.Width += 10;
                if (panelMenu.Width == panelMenu.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebarTimer.Stop();
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }

        private void panelBody_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void DButton1_Click(object sender, EventArgs e)
        {
            if (TimerCheck3)
            {
                PanelMenu3.Height = PanelMenu3.MaximumSize.Height;
                TimerCheck3 = false;
            }
            else
            {
                PanelMenu3.Height = PanelMenu3.MinimumSize.Height;
                TimerCheck3 = true;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (TimerCheck2)
            { 
                    PanelMenu2.Height = PanelMenu2.MaximumSize.Height;
                    TimerCheck2 = false;
                    timer2.Stop(); 
            }
            else
            { 
                    PanelMenu2.Height = PanelMenu2.MinimumSize.Height;
                    TimerCheck2 = true;
                    timer2.Stop(); 
            }
        }
    }
}
