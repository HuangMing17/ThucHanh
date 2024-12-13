using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_03
{
    public partial class AddStudentForm : Form
    {

        // Delegate định nghĩa sự kiện thêm sinh viên
        public delegate void AddStudentHandler(string maSo, string ten, string khoa, string diem);
        public event AddStudentHandler OnAddStudent;
     

        public AddStudentForm()
        {
            InitializeComponent();
        }

        private void AddStudentForm_Load(object sender, EventArgs e)
        {
            cmbKhoa.Items.Add("Công nghệ thông tin");
            cmbKhoa.Items.Add("Ngôn ngữ Anh");
            cmbKhoa.Items.Add("Quản trị kinh doanh");
            cmbKhoa.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbKhoa.SelectedIndex = 0;
        }

        private void add_Click(object sender, EventArgs e)
        {
            // Kiểm tra thông tin bắt buộc
            if (string.IsNullOrWhiteSpace(txtMaSo.Text) || string.IsNullOrWhiteSpace(txtTen.Text) || string.IsNullOrWhiteSpace(txtDiem.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra điểm hợp lệ
            if (!float.TryParse(txtDiem.Text, out float diem) || diem < 0 || diem > 10)
            {
                MessageBox.Show("Điểm phải nằm trong khoảng từ 0 đến 10!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kích hoạt delegate để thông báo về sinh viên mới
            OnAddStudent?.Invoke(txtMaSo.Text, txtTen.Text, cmbKhoa.SelectedItem?.ToString(), txtDiem.Text);

            // Đóng Form sau khi thêm
            this.Close();
        }

        

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    
}
