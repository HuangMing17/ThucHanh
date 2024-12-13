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
    public partial class frmMain : Form
    {
        private List<Student> students = new List<Student>();


        public frmMain()
        {
            InitializeComponent();
        }

        private void thêmMớiToolStripMenuItem_Click(object sender, EventArgs e)
        { // Tạo Form Thêm sinh viên
            AddStudentForm addForm = new AddStudentForm();

            // Đăng ký hành động cho delegate OnAddStudent
            addForm.OnAddStudent += (maSo, ten, khoa, diem) =>
            {
                // Kiểm tra trùng Mã số SV
                foreach (var student in students)
                {
                    if (student.MaSo == maSo)
                    {
                        MessageBox.Show("Mã số sinh viên bị trùng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                // Kiểm tra điểm hợp lệ
                if (float.TryParse(diem, out float diemTB))
                {
                    if (diemTB < 0 || diemTB > 10)
                    {
                        MessageBox.Show("Điểm phải nằm trong khoảng từ 0 đến 10!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                // Thêm sinh viên vào danh sách
                students.Add(new Student
                {
                    MaSo = maSo,
                    Ten = ten,
                    Khoa = khoa,
                    Diem = diem
                });

                // Cập nhật DataGridView
                UpdateDataGridView();

                // Hiển thị thông báo thêm sinh viên thành công
                MessageBox.Show("Sinh viên đã được thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            };

            // Hiển thị Form Thêm sinh viên
            addForm.ShowDialog();
        }
        private void UpdateDataGridView()
        {
            dataGridView1.Rows.Clear();
            foreach (var student in students)
            {
                dataGridView1.Rows.Add(dataGridView1.Rows.Count + 1, student.MaSo, student.Ten, student.Khoa, student.Diem);
            }
        }

        private void tìmKiếmTheoTênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.ToLower();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["Ten"].Value != null && row.Cells["Ten"].Value.ToString().ToLower().Contains(keyword))
                {
                    row.Visible = true;
                }
                else
                {
                    row.Visible = false;
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ShowAll_Click(object sender, EventArgs e)
        {
            //hiển thị danh sách sinh viên
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.Visible = true;
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
           
            // Kiểm tra xem có dòng nào được chọn không
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một sinh viên để sửa thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy thông tin sinh viên từ dòng được chọn
            DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
            string maSo = selectedRow.Cells["MaSo"].Value.ToString();
            string ten = selectedRow.Cells["Ten"].Value.ToString();
            string khoa = selectedRow.Cells["Khoa"].Value.ToString();
            string diem = selectedRow.Cells["Diem"].Value.ToString();

            // Hiển thị Form sửa thông tin
            EditStudentForm editForm = new EditStudentForm(maSo, ten, khoa, diem);
            if (editForm.ShowDialog() == DialogResult.OK)
            {
                // Cập nhật thông tin sinh viên trong DataGridView
                selectedRow.Cells["Ten"].Value = editForm.Ten;
                selectedRow.Cells["Khoa"].Value = editForm.Khoa;
                selectedRow.Cells["Diem"].Value = editForm.Diem;
            }
        }

        
    }
}


