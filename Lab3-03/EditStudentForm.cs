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
    public partial class EditStudentForm : Form
    {
        public string Ten { get; private set; }
        public string Khoa { get; private set; }
        public string Diem { get; private set; }

        public EditStudentForm(string maSo, string ten, string khoa, string diem)
        {
            InitializeComponent();

            // Hiển thị thông tin hiện tại
            txtMaSo.Text = maSo;
            txtMaSo.ReadOnly = true; // Không cho sửa mã số sinh viên
            txtTen.Text = ten;
            cmbKhoa.SelectedItem = khoa;
            txtDiem.Text = diem;
        }
        public EditStudentForm()
        {
            InitializeComponent();
        }

        private void save_Click(object sender, EventArgs e)
        {
            // Kiểm tra thông tin hợp lệ
            if (string.IsNullOrWhiteSpace(txtTen.Text) || string.IsNullOrWhiteSpace(txtDiem.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!float.TryParse(txtDiem.Text, out float diem) || diem < 0 || diem > 10)
            {
                MessageBox.Show("Điểm phải nằm trong khoảng từ 0 đến 10!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lưu thông tin
            Ten = txtTen.Text;
            Khoa = cmbKhoa.SelectedItem.ToString();
            Diem = txtDiem.Text;

            // Trả về DialogResult.OK
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void EditStudentForm_Load(object sender, EventArgs e)
        {
            cmbKhoa.Items.Add("Công nghệ thông tin");
            cmbKhoa.Items.Add("Ngôn ngữ Anh");
            cmbKhoa.Items.Add("Quản trị kinh doanh");
            cmbKhoa.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbKhoa.SelectedIndex = 0;
        }
    }
    
}
