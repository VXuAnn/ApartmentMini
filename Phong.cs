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
    public partial class Phong : Form
    {
        string connectionString = "Data Source=VUAN;Initial Catalog=APARTMENT;Integrated Security=True;";
        public Phong()
        {
            InitializeComponent();
        }

        private void LoadPhongInfo()
        {
            
            string query = "SELECT * FROM PHONG";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                int panelWidth = 150;
                int panelHeight = 180;
                int horizontalSpacing = 30; // Khoảng cách ngang giữa các panel
                int verticalSpacing = 10; // Khoảng cách dọc giữa các panel
                int maxPanelsPerRow = 5; // Số lượng panel tối đa trên mỗi hàng
                int panelCount = 0;
                int row = 0;
                int column = 0;
                int panelsInCurrentRow = 0; // Số lượng panel đã thêm vào hàng hiện tại

                while (reader.Read())
                {
                    string maSoPhong = reader["MASOPHONG"].ToString();
                    string loaiPhong = reader["LOAIPHONG"].ToString();
                    decimal gia = Convert.ToDecimal(reader["GIA"]); // Chuyển đổi dữ liệu thành decimal
                    bool tinhTrang = Convert.ToBoolean(reader["TINHTRANG"]); // Chuyển đổi dữ liệu thành boolean

                    // Tạo panel mới cho mỗi mã số phòng
                    Panel panel = new Panel();
                    panel.BorderStyle = BorderStyle.FixedSingle;
                    panel.Width = panelWidth;
                    panel.Height = panelHeight;

                    // Tạo các label hiển thị thông tin phòng
                    string maSoPhongFormatted = "P" + maSoPhong.Substring(1); // Lấy phần số từ index 1 của mã số phòng
                    Label labelMaSoPhong = new Label();
                    labelMaSoPhong.Text = "Mã số phòng: " + maSoPhongFormatted;
                    labelMaSoPhong.Location = new Point(horizontalSpacing, verticalSpacing);

                    Label labelLoaiPhong = new Label();
                    labelLoaiPhong.Text = "Loại phòng: " + loaiPhong;
                    labelLoaiPhong.Location = new Point(horizontalSpacing, labelMaSoPhong.Bottom + verticalSpacing);

                    Label labelGia = new Label();
                    labelGia.Text = "Giá: " + gia.ToString("N0") + " VND"; // Hiển thị giá theo định dạng số có dấu phẩy ngăn cách hàng nghìn
                    labelGia.Location = new Point(horizontalSpacing, labelLoaiPhong.Bottom + verticalSpacing);

                    Label labelTinhTrang = new Label();
                    labelTinhTrang.Text = "Tình trạng: " + (tinhTrang ? "Bận" : "Trống"); // Hiển thị tình trạng dựa trên giá trị boolean
                    labelTinhTrang.Location = new Point(horizontalSpacing, labelGia.Bottom + verticalSpacing);

                    // Thêm các control vào panel
                    panel.Controls.Add(labelMaSoPhong);
                    panel.Controls.Add(labelLoaiPhong);
                    panel.Controls.Add(labelGia);
                    panel.Controls.Add(labelTinhTrang);

                    // Thiết lập màu nền của panel dựa trên trạng thái thuê
                    if (tinhTrang)
                    {
                        // Nếu phòng bận, màu nền là màu xanh dương
                        panel.BackColor = Color.LightCoral;
                    }
                    else
                    {
                        // Nếu phòng trống, màu nền là màu xanh lá cây nhạt
                        panel.BackColor = Color.LightGreen;
                    }
                   
                    // Đặt vị trí của panel trên panel2
                    panel.Location = new Point((panelWidth + horizontalSpacing) * column, (panelHeight + verticalSpacing) * row);

                    // Thêm panel vào panel2 của form
                    panel2.Controls.Add(panel);

                    // Tính toán vị trí của panel tiếp theo
                    panelCount++;
                    column++;
                    panelsInCurrentRow++;

                    // Nếu đã đủ số lượng panel trên một hàng, chuyển sang hàng mới
                    if (panelsInCurrentRow >= maxPanelsPerRow)
                    {
                        row++;
                        column = 0;
                        panelsInCurrentRow = 0;
                    }
                }

                reader.Close();
            }
        }
        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

       
        private void AddScrollBar()
        {
            // Tạo một thanh cuộn mới
            VScrollBar vScrollBar = new VScrollBar();
            vScrollBar.Dock = DockStyle.Right; // Đặt thanh cuộn ở cạnh phải của panel
            vScrollBar.Scroll += VScrollBar_Scroll; // Gắn sự kiện Scroll

            // Thêm thanh cuộn vào form
            Controls.Add(vScrollBar);
        }

        private void VScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            // Thiết lập vị trí của Panel2 dựa trên giá trị cuộn của thanh cuộn
            panel2.AutoScrollPosition = new Point(panel2.AutoScrollPosition.X, e.NewValue);
        }
        private void Phong_Load(object sender, EventArgs e)
        {
            AddScrollBar();
            LoadPhongInfo();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {


        }
        

    }
}
