using System;
using System.Windows.Forms;
using S7.Net;

namespace S7_1200_with_CSharp
{
    public partial class Form1 : Form
    {
        Plc plc_s7_1200;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Các phần tử giao diện (UI) sẽ được thêm qua Form Designer (kéo thả trong giao diện thiết kế).
        }

        // Sự kiện Click của nút "Kết nối" (btnConnect) để kết nối tới PLC
        private void btnConnect_Click_1(object sender, EventArgs e)
        {
            string ipAddress = txtIpAddress.Text; // Lấy địa chỉ IP từ TextBox mà người dùng nhập vào
            try
            {
                // Tạo đối tượng PLC với loại CPU S71200, địa chỉ IP và Rack và Slot của PLC
                plc_s7_1200 = new Plc(CpuType.S71200, ipAddress, 0, 1);
                plc_s7_1200.Open(); // Mở kết nối tới PLC

                // Kiểm tra nếu kết nối thành công
                if (plc_s7_1200.IsConnected)
                {
                    lblStatus.Text = "Trạng thái: Đã kết nối"; // Hiển thị trạng thái kết nối
                    MessageBox.Show("Kết nối thành công với PLC!"); // Thông báo thành công
                }
                else
                {
                    lblStatus.Text = "Trạng thái: Kết nối thất bại"; // Hiển thị trạng thái kết nối thất bại
                    MessageBox.Show("Kết nối PLC thất bại."); // Thông báo thất bại
                }
            }
            catch (Exception exp)
            {
                // Bắt lỗi nếu có ngoại lệ xảy ra trong quá trình kết nối
                lblStatus.Text = "Trạng thái: Lỗi kết nối";
                MessageBox.Show(exp.Message); // Hiển thị thông báo lỗi
            }
        }

        // Phương thức kiểm tra kết nối PLC còn hoạt động hay không
        private bool IsPlcConnected()
        {
            if (plc_s7_1200 != null && plc_s7_1200.IsConnected)
            {
                lblStatus.Text = "Trạng thái: Đã kết nối"; // Cập nhật trạng thái hiển thị
                return true; // Trả về true nếu PLC đang kết nối
            }
            else
            {
                lblStatus.Text = "Trạng thái: Không kết nối"; // Cập nhật trạng thái khi mất kết nối
                MessageBox.Show("PLC không còn kết nối."); // Hiển thị thông báo lỗi
                return false; // Trả về false nếu PLC không còn kết nối
            }
        }

        // Sự kiện Click của nút "Ghi dữ liệu" (btnWrite) để ghi dữ liệu xuống PLC
        private void btnWrite_Click_1(object sender, EventArgs e)
        {
            // Kiểm tra xem PLC có còn kết nối không trước khi thực hiện ghi
            if (IsPlcConnected())
            {
                try
                {
                    // Lấy dữ liệu từ TextBox (chuỗi nhập liệu) và chuyển thành số nguyên
                    int dataToWrite = int.Parse(txtWriteData.Text);
                    // Ghi dữ liệu xuống địa chỉ nhớ "MW0" của PLC
                    plc_s7_1200.Write("DB1.DBW6", dataToWrite);

                    MessageBox.Show("Đã ghi dữ liệu thành công xuống PLC!"); // Thông báo ghi thành công
                }
                catch (Exception exp)
                {
                    // Bắt lỗi nếu có lỗi khi thực hiện ghi dữ liệu
                    MessageBox.Show("Ghi dữ liệu thất bại: " + exp.Message); // Hiển thị lỗi ghi
                }
            }
        }

        // Sự kiện Click của nút "Đọc dữ liệu" (btnRead) để đọc dữ liệu từ PLC
        private void btnRead_Click_1(object sender, EventArgs e)
        {
            // Kiểm tra xem PLC có còn kết nối không trước khi thực hiện đọc
            if (IsPlcConnected())
            {
                try
                {
                    // Đọc dữ liệu từ PLC dưới dạng 32-bit (4 bytes)
                    var readData = plc_s7_1200.Read("DB1.DBW0");

                    // Hiển thị dữ liệu đã đọc vào TextBox
                    txtReadData.Text = readData.ToString();
                }
                catch (Exception exp)
                {
                    // Bắt lỗi nếu có lỗi khi thực hiện đọc dữ liệu
                    MessageBox.Show("Đọc dữ liệu thất bại: " + exp.Message); // Hiển thị lỗi đọc
                }
            }
        }


        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (plc_s7_1200 != null && plc_s7_1200.IsConnected)
                {
                    plc_s7_1200.Close(); // Ngắt kết nối với PLC
                    lblStatus.Text = "Trạng thái: Đã ngắt kết nối"; // Cập nhật trạng thái
                    MessageBox.Show("Đã ngắt kết nối với PLC!");
                }
                else
                {
                    MessageBox.Show("PLC đã ngắt kết nối hoặc chưa kết nối.");
                }
            }
            catch (Exception exp)
            {
                lblStatus.Text = "Trạng thái: Lỗi khi ngắt kết nối";
                MessageBox.Show("Lỗi khi ngắt kết nối: " + exp.Message); // Hiển thị lỗi ngắt kết nối
            }
        }

        private void btnReadFloat_Click(object sender, EventArgs e)
        {
            if (IsPlcConnected())
            {
                try
                {
                    // Đọc dữ liệu từ PLC dưới dạng 32-bit (4 bytes)
                    uint readData = (uint)plc_s7_1200.Read("DB1.DBD8");

                    // Chuyển đổi 4 bytes thành float
                    byte[] dataToWrite = BitConverter.GetBytes(readData);
                    float outf = BitConverter.ToSingle(dataToWrite, 0);

                    // Hiển thị dữ liệu đã đọc vào TextBox
                    txtReadData.Text = outf.ToString();
                }
                catch (Exception exp)
                {
                    // Bắt lỗi nếu có lỗi khi thực hiện đọc dữ liệu
                    MessageBox.Show("Đọc dữ liệu thất bại: " + exp.Message); // Hiển thị lỗi đọc
                }
            }
        }

        private void btnWriteFloat_Click(object sender, EventArgs e)
        {
            if (IsPlcConnected())
            {
                try
                {
                    // Lấy giá trị float từ TextBox
                    float inputValue = float.Parse(txtWriteData.Text); // TextBox nhập dữ liệu

                    // Chuyển đổi float thành 4 bytes
                    byte[] floatBytes = BitConverter.GetBytes(inputValue);

                    // Chuyển đổi 4 bytes thành uint để ghi vào PLC
                    uint writeData = BitConverter.ToUInt32(floatBytes, 0);

                    // Ghi dữ liệu vào PLC
                    plc_s7_1200.Write("DB1.DBD8", writeData);

                    // Hiển thị thông báo thành công
                    MessageBox.Show("Ghi dữ liệu thành công!");
                }
                catch (FormatException)
                {
                    MessageBox.Show("Giá trị nhập không hợp lệ! Vui lòng nhập một số thực.");
                }
                catch (Exception exp)
                {
                    // Bắt lỗi nếu có lỗi khi thực hiện ghi dữ liệu
                    MessageBox.Show("Ghi dữ liệu thất bại: " + exp.Message); // Hiển thị lỗi ghi
                }
            }
        }
    }
}
