using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPhepTinh(object sender, EventArgs e)
        {
            float a, b, kq = 0;



            a = float.Parse(txtN1.Text);
            b = float.Parse(txtN2.Text);



            // Lấy phép toán dựa vào nút được nhấn
            string pheptoan = ((Button)sender).Name;

            switch (pheptoan)
            {
                case "btnCong":
                    kq = a + b;
                    break;

                case "btnTru":
                    kq = a - b;
                    break;

                case "btnNhan":
                    kq = a * b;
                    break;

                case "btnChia":
                    // Kiểm tra chia cho 0
                    if (b == 0)
                    {
                        MessageBox.Show("Không thể chia cho 0");
                        return;
                    }
                    kq = a / b;
                    break;

                default:
                    MessageBox.Show("Phép toán không hợp lệ!");
                    return;
            }

            // Hiển thị kết quả
            txtN3.Text = kq.ToString();

        }
    }
}
