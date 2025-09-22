using System;
using System.Windows.Forms;
using System.Management;

namespace ChangeDNS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Gán sự kiện CheckedChanged cho các RadioButton
            DNS_1.CheckedChanged += new EventHandler(DNS_CheckedChanged);
            DNS_2.CheckedChanged += new EventHandler(DNS_CheckedChanged);

            // Gán sự kiện Click cho nút Apply And Exit
            button1.Click += new EventHandler(button1_Click);
        }

        private void DNS_CheckedChanged(object sender, EventArgs e)
        {
            // Không thực hiện thay đổi DNS ngay, chỉ lưu trạng thái
            // Thay đổi sẽ được áp dụng khi nhấn nút "Apply And Exit"
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Kiểm tra RadioButton nào được chọn và thay đổi DNS
            if (DNS_1.Checked)
            {
                SetDNS(""); // Đặt lại DNS mặc định (DHCP)
                MessageBox.Show("Đã đặt DNS thành mặc định!");
            }
            else if (DNS_2.Checked)
            {
                SetDNS("8.8.8.8,8.8.4.4"); // Đặt DNS của Google
                MessageBox.Show("Đã đặt DNS thành Google DNS!");
            }

            // Đóng ứng dụng sau khi áp dụng
            Application.Exit();
        }

        private void SetDNS(string dns)
        {
            try
            {
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_NetworkAdapterConfiguration WHERE IPEnabled = 'TRUE'");
                ManagementObjectCollection collection = searcher.Get();

                foreach (ManagementObject obj in collection)
                {
                    ManagementBaseObject inParams = obj.GetMethodParameters("SetDNSServerSearchOrder");
                    if (string.IsNullOrEmpty(dns))
                    {
                        inParams["DNSServerSearchOrder"] = null; // Đặt lại thành DHCP (mặc định)
                    }
                    else
                    {
                        inParams["DNSServerSearchOrder"] = dns.Split(','); // Set DNS Google
                    }

                    ManagementBaseObject outParams = obj.InvokeMethod("SetDNSServerSearchOrder", inParams, null);
                    if ((uint)outParams["ReturnValue"] != 0)
                    {
                        MessageBox.Show("Không thể thay đổi DNS. Vui lòng kiểm tra quyền admin.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void DNS_1_CheckedChanged(object sender, EventArgs e)
        {
            // Sự kiện này đã được gán trong Form1_Load, không cần thêm code ở đây
        }
    }
}