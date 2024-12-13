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
    public partial class Main : Form
    {
        private DatabaseHelper dbHelper;


        public Main()
        {
            InitializeComponent();
            dbHelper = new DatabaseHelper();
        }
        private void LoadStudents()
        {
            DataTable dt = dbHelper.GetAllStudents();
            dataGridView1.DataSource = dt;
        }
        private void thêmMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddStudentForm addForm = new AddStudentForm();
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                // Nhận dữ liệu từ Form AddStudentForm
                string maSo = addForm.MaSo;
                string ten = addForm.Ten;
                string khoa = addForm.Khoa;
                string diemStr = addForm.Diem;

                // Kiểm tra điểm hợp lệ
                if (float.TryParse(diemStr, out float diem))
                {
                    try
                    {
                        dbHelper.AddStudent(maSo, ten, khoa, diem);
                        MessageBox.Show("Thêm mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadStudents(); // Tải lại dữ liệu
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Điểm không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
      

        private void tìmKiếmTheoTênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.ToLower();
            DataTable dt = dbHelper.GetAllStudents();
            DataView dv = dt.DefaultView;
            dv.RowFilter = $"Ten LIKE '%{keyword}%'";
            dataGridView1.DataSource = dv.ToTable();
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

        private void frmMain_Load(object sender, EventArgs e)
        {
            LoadStudents();
        }
    }
}

