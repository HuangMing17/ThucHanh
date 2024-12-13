using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2_04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private bool KiemTraNhapLieu()
        {
            if (string.IsNullOrWhiteSpace(txtSoTaiKhoan.Text) ||
                string.IsNullOrWhiteSpace(txtTenKH.Text) ||
                string.IsNullOrWhiteSpace(txtDiaChi.Text) ||
                string.IsNullOrWhiteSpace(txtSoTien.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!decimal.TryParse(txtSoTien.Text, out _))
            {
                MessageBox.Show("Số tiền phải là số hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void CapNhatTongTien()
        {
            decimal tongTien = lvTaiKhoan.Items.Cast<ListViewItem>()
                .Sum(item => decimal.Parse(item.SubItems[4].Text.Replace(",", ""))); // SubItems[4] là cột Số Tiền

            txtTongTien.Text = $"{tongTien:N0}đ";
        }

        private void CapNhatSTT()
        {
            for (int i = 0; i < lvTaiKhoan.Items.Count; i++)
            {
                lvTaiKhoan.Items[i].Text = (i + 1).ToString(); // Cột STT là cột đầu tiên
            }
        }

        private void btnThemCapNhat_Click(object sender, EventArgs e)
        {

            if (!KiemTraNhapLieu()) return;

            string soTaiKhoan = txtSoTaiKhoan.Text;
            string tenKH = txtTenKH.Text;
            string diaChi = txtDiaChi.Text;
            decimal soTien = decimal.Parse(txtSoTien.Text);

            // Kiểm tra tài khoản đã tồn tại trong ListView
            ListViewItem existingItem = lvTaiKhoan.Items.Cast<ListViewItem>()
                .FirstOrDefault(item => item.SubItems[1].Text == soTaiKhoan); // SubItems[1] là cột Số Tài Khoản

            if (existingItem == null)
            {
                // Thêm mới tài khoản
                ListViewItem newItem = new ListViewItem((lvTaiKhoan.Items.Count + 1).ToString()); // Cột STT
                newItem.SubItems.Add(soTaiKhoan); // Cột Số Tài Khoản
                newItem.SubItems.Add(tenKH);      // Cột Tên Khách Hàng
                newItem.SubItems.Add(diaChi);     // Cột Địa Chỉ
                newItem.SubItems.Add(soTien.ToString("N0")); // Cột Số Tiền

                lvTaiKhoan.Items.Add(newItem);
                MessageBox.Show("Thêm mới dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Cập nhật tài khoản
                existingItem.SubItems[2].Text = tenKH; // Cột Tên Khách Hàng
                existingItem.SubItems[3].Text = diaChi; // Cột Địa Chỉ
                existingItem.SubItems[4].Text = soTien.ToString("N0"); // Cột Số Tiền
                MessageBox.Show("Cập nhật dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            CapNhatTongTien();
            CapNhatSTT(); // Cập nhật lại STT sau khi thêm hoặc cập nhật
        }


        private void btnXoa_Click(object sender, EventArgs e)
        {

            string soTaiKhoan = txtSoTaiKhoan.Text;

            // Tìm tài khoản trong ListView
            ListViewItem itemToRemove = lvTaiKhoan.Items.Cast<ListViewItem>()
                .FirstOrDefault(item => item.SubItems[1].Text == soTaiKhoan); // SubItems[1] là cột Số Tài Khoản

            if (itemToRemove == null)
            {
                MessageBox.Show("Không tìm thấy số tài khoản cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Hiển thị cảnh báo xác nhận
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa tài khoản này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                lvTaiKhoan.Items.Remove(itemToRemove);
                MessageBox.Show("Xóa tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CapNhatTongTien();
                CapNhatSTT(); // Cập nhật lại STT sau khi xóa
            }
        }

        private void lvTaiKhoan_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (lvTaiKhoan.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lvTaiKhoan.SelectedItems[0];
                txtSoTaiKhoan.Text = selectedItem.SubItems[1].Text; // Cột Số Tài Khoản
                txtTenKH.Text = selectedItem.SubItems[2].Text;      // Cột Tên Khách Hàng
                txtDiaChi.Text = selectedItem.SubItems[3].Text;     // Cột Địa Chỉ
                txtSoTien.Text = selectedItem.SubItems[4].Text.Replace(",", ""); // Loại bỏ dấu phẩy
            }

        }

    }
}



