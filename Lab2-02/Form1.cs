using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         
            // Thiết lập mặc định
            cboKhoa.Items.AddRange(new string[] { "QTKD", "CNTT", "NNA" });
            cboKhoa.SelectedIndex = 0; // Chọn QTKD
            rdbNu.Checked = true; // Giới tính mặc định là Nữ
            txtTongNam.Text = " 0";
            txtTongNu.Text = " 0";
        }

        private void TinhTongSinhVien()
        {
            int tongNam = 0;
            int tongNu = 0;

            foreach (DataGridViewRow row in dgvSinhVien.Rows)
            {
                if (row.Cells[2].Value?.ToString() == "Nam")
                    tongNam++;
                else if (row.Cells[2].Value?.ToString() == "Nữ")
                    tongNu++;
            }

            txtTongNam.Text = $"{tongNam}";
            txtTongNu.Text = $"{tongNu}";
        }

        private void btnThemSua_Click(object sender, EventArgs e)
        {
           
            // Kiểm tra thông tin bắt buộc
            if (string.IsNullOrWhiteSpace(txtMSSV.Text) ||
                string.IsNullOrWhiteSpace(txtHoTen.Text) ||
                string.IsNullOrWhiteSpace(txtDiemTB.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string mssv = txtMSSV.Text;
            string hoTen = txtHoTen.Text;
            string gioiTinh = rdbNam.Checked ? "Nam" : "Nữ";
            string diemTB = txtDiemTB.Text;
            string khoa = cboKhoa.SelectedItem.ToString();

            // Kiểm tra MSSV trong DataGridView
            bool isUpdate = false;
            foreach (DataGridViewRow row in dgvSinhVien.Rows)
            {
                if (row.Cells[0].Value?.ToString() == mssv)
                {
                    // Cập nhật
                    row.SetValues(mssv, hoTen, gioiTinh, diemTB, khoa);
                    MessageBox.Show("Cập nhật dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    isUpdate = true;
                    break;
                }
            }

            if (!isUpdate)
            {
                // Thêm mới
                dgvSinhVien.Rows.Add(mssv, hoTen, gioiTinh, diemTB, khoa);
                MessageBox.Show("Thêm mới dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            TinhTongSinhVien(); // Tính lại tổng Nam/Nữ
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
          
            string mssv = txtMSSV.Text;
            bool isFound = false;

            foreach (DataGridViewRow row in dgvSinhVien.Rows)
            {
                if (row.Cells[0].Value?.ToString() == mssv)
                {
                    isFound = true;
                    var result = MessageBox.Show("Bạn có chắc chắn muốn xóa sinh viên này?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        dgvSinhVien.Rows.Remove(row);
                        MessageBox.Show("Xóa sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        TinhTongSinhVien(); // Tính lại tổng Nam/Nữ
                    }
                    break;
                }
            }

            if (!isFound)
            {
                MessageBox.Show("Không tìm thấy MSSV cần xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvSinhVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvSinhVien.Rows[e.RowIndex];
                txtMSSV.Text = row.Cells[0].Value?.ToString();
                txtHoTen.Text = row.Cells[1].Value?.ToString();
                if (row.Cells[2].Value?.ToString() == "Nam")
                    rdbNam.Checked = true;
                else
                    rdbNu.Checked = true;
                txtDiemTB.Text = row.Cells[3].Value?.ToString();
                cboKhoa.SelectedItem = row.Cells[4].Value?.ToString();
            }
        }

        private void dgvSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {


          
            if (e.RowIndex >= 0)
            {
                // Lấy dòng được chọn
                DataGridViewRow row = dgvSinhVien.Rows[e.RowIndex];

                // Gán giá trị trực tiếp
                txtMSSV.Text = row.Cells[0].Value?.ToString(); // Cột 0: MSSV
                txtHoTen.Text = row.Cells[1].Value?.ToString(); // Cột 1: Họ Tên
                txtDiemTB.Text = row.Cells[3].Value?.ToString(); // Cột 3: Điểm TB
                cboKhoa.Text = row.Cells[4].Value?.ToString(); // Cột 4: Khoa

                // Giới tính
                if (row.Cells[2].Value?.ToString() == "Nam") // Cột 2: Giới tính
                    rdbNam.Checked = true;
                else
                    rdbNu.Checked = true;
            }
        }


    }
}

    




