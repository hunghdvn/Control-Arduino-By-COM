using System;
using System.Drawing;
using System.IO.Ports;
using System.Windows.Forms;

namespace DemoWinApp
{
    /* Create  by: HungHD
     * Create date: 06/05/2019
     * Kết nối và điều khiển mạch Arduino qua COM Port
     */

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CheckConnect();
            //Lấy danh sách Port đang tồn tại trên máy
            cbbPort.DataSource = SerialPort.GetPortNames();
        }

        private void CheckConnect()
        {
            //Kiểm tra kết nối
            if (serialPort.IsOpen)
            {
                btnConnect.Text = "Ngắt kết nối";
                btnConnect.BackColor = Color.Red;
                btnConnect.ForeColor = Color.White;

            }
            else
            {
                btnConnect.Text = "Kết nối";
                btnConnect.BackColor = Color.LimeGreen;
                btnConnect.ForeColor = Color.Black;
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (!serialPort.IsOpen)
            {
                serialPort.PortName = cbbPort.Text;
                serialPort.Open();
            }
            else
            {
                serialPort.Close();
            }
            CheckConnect();
        }

        private void btnOn1_Click(object sender, EventArgs e)
        {
            serialPort.Write("2");
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            CheckConnect();
        }

        private void btnOn2_Click(object sender, EventArgs e)
        {
            serialPort.Write("4");
        }

        private void btnOff1_Click(object sender, EventArgs e)
        {
            serialPort.Write("1");
        }

        private void btnOff2_Click(object sender, EventArgs e)
        {
            serialPort.Write("3");
        }
    }
}
