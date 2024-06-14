using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace ApartmentMini_Management_System
{
    public partial class Phong : Form
    {
        SqlConnection conec = null;
        string stronic = @"Data Source=VUAN;Initial Catalog=APARTMENT;Integrated Security=True;";
        private int currentPage = 1;
        private const int roomsPerPage = 8;

        public Phong()
        {
            InitializeComponent();
        }

        private void openChildControl(UserControl childControl, Panel targetPanel)
        {
            targetPanel.Controls.Clear();
            childControl.Dock = DockStyle.Fill;
            targetPanel.Controls.Add(childControl);
            childControl.BringToFront();
            childControl.Show();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }


        private void AddScrollBar()
        {
            panel2.AutoScroll = true;
        }

        private void Phong_Load(object sender, EventArgs e)
        {
            AddScrollBar();
            DisplayCurrentPage();
        }

        private void DisplayCurrentPage()
        {
            List<UserControl> rooms = thongtinPhong(currentPage, roomsPerPage);
            ClearPanels();
            
            foreach (var room in rooms)
            {
                if (room is tThongPhong)
                {
                    tThongPhong roomControl = (tThongPhong)room;
                    int panelNumber = rooms.IndexOf(room) + 3; // Map to panel3 to panel10
                    Panel targetPanel = (Panel)panel2.Controls.Find($"panel{panelNumber}", true).FirstOrDefault();
                    if (targetPanel != null)
                    {
                        openChildControl(room, targetPanel);
                    }
                }
                else if (room is tThongPhongTrong)
                {
                    tThongPhongTrong emptyRoomControl = (tThongPhongTrong)room;
                    int panelNumber = rooms.IndexOf(room) + 3; // Map to panel3 to panel10
                    Panel targetPanel = (Panel)panel2.Controls.Find($"panel{panelNumber}", true).FirstOrDefault();
                    if (targetPanel != null)
                    {
                        openChildControl(emptyRoomControl, targetPanel);
                    }
                   
                }
            }
            
        }





        private List<UserControl> thongtinPhong(int pageNumber, int pageSize)
        {
            List<UserControl> rooms = new List<UserControl>();

            if (conec == null)
            {
                conec = new SqlConnection(stronic);
            }
            if (conec.State == ConnectionState.Closed)
            {
                conec.Open();
            }

            SqlCommand command = new SqlCommand
            {
                CommandType = CommandType.StoredProcedure,
                CommandText = "ttPhong",
                Connection = conec
            };

            command.Parameters.AddWithValue("@PageNumber", pageNumber);
            command.Parameters.AddWithValue("@PageSize", pageSize);

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                bool tinhTrang = Convert.ToBoolean(reader["TINHTRANG"]);

                if (tinhTrang)
                {
                    // TINHTRANG is true, use tThongPhong
                    string maSoPhong = reader["MASOPHONG"].ToString();
                    string loaiPhong = reader["LOAIPHONG"].ToString();
                    string hoTen = reader["HOTEN"].ToString();
                    string gia = reader["GIA"].ToString();

                    tThongPhong roomControl = new tThongPhong();
                    roomControl.UpdateInfo(maSoPhong, loaiPhong, hoTen, gia);
                    rooms.Add(roomControl);
                }
                else
                {
                    // TINHTRANG is false, use tThongPhongTrong
                    string maSoPhong = reader["MASOPHONG"].ToString();
                    string loaiPhong = reader["LOAIPHONG"].ToString();
                    string gia = reader["GIA"].ToString();

                    tThongPhongTrong emptyRoomControl = new tThongPhongTrong();
                    emptyRoomControl.UpdateInfo2(maSoPhong, loaiPhong, gia);
                    rooms.Add(emptyRoomControl);
                }
            }

            reader.Close();
            return rooms;
        }



        private void ClearPanels()
        {
            for (int i = 3; i <= 10; i++)
            {
                Panel targetPanel = (Panel)panel2.Controls.Find($"panel{i}", true).FirstOrDefault();
                if (targetPanel != null)
                {
                    targetPanel.Controls.Clear();
                }
            }
        }

        private void button6_Click(object sender, EventArgs e) // Trang Trước
        {
            if (currentPage > 1)
            {
                currentPage--;
                DisplayCurrentPage();
            }
        }

        private void button3_Click(object sender, EventArgs e) // Trang Sau
        {
            currentPage++;
            List<UserControl> rooms = thongtinPhong(currentPage, roomsPerPage);

            if (rooms.Count > 0)
            {
                DisplayCurrentPage();
            }
            else
            {
                currentPage--; // Không tăng trang nếu không có dữ liệu
            }
        }
    }
}
