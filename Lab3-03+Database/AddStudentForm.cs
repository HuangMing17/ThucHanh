using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab3_03_Database;

namespace Lab3_03
{
    public partial class AddStudentForm : Form
    {

        private Model1 dbContext;

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
            // Kiểm tra các thông tin bắt buộc
            if (string.IsNullOrWhiteSpace(txtMaSo.Text) || string.IsNullOrWhiteSpace(txtTen.Text) || string.IsNullOrWhiteSpace(txtDiem.Text))
            {
                MessageBox.Show("Các thông tin mã số, tên và điểm là bắt buộc.");
                return;
            }

            // Kiểm tra mã số sinh viên có bị trùng hay không
            var existingStudent = dbContext.SinhVien.FirstOrDefault(s => s.MaSo == txtMaSo.Text);
            if (existingStudent != null)
            {
                MessageBox.Show("Mã số sinh viên đã tồn tại.");
                return;
            }

            // Kiểm tra điểm có trong phạm vi 0-10 không
            float diem;
            if (!float.TryParse(txtDiem.Text, out diem) || diem < 0 || diem > 10)
            {
                MessageBox.Show("Điểm phải trong phạm vi từ 0 đến 10.");
                return;
            }

            // Thêm sinh viên mới vào cơ sở dữ liệu
            var newStudent = new SinhVien
            {
                MaSo = txtMaSo.Text,
                Ten = txtTen.Text,
                Khoa = cmbKhoa.SelectedItem.ToString(),
                Diem = diem
            };

            dbContext.SinhVien.Add(newStudent);
            dbContext.SaveChanges();  // Lưu thay đổi vào cơ sở dữ liệu

            MessageBox.Show("Thêm sinh viên thành công!");

            // Đóng form thêm sinh viên
            this.Close();
        }

        

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    
}
