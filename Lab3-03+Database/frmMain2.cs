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
    public partial class frmMain2 : Form
    {
        private Model1 dbContext;


        public frmMain2()
        {
            InitializeComponent();
            dbContext = new Model1();
        }
        // Hàm để tải dữ liệu sinh viên từ cơ sở dữ liệu vào DataGridView
        private void LoadData()
        {
            // Lấy danh sách sinh viên từ cơ sở dữ liệu
            var sinhViens = dbContext.SinhVien.ToList();

            // Gán dữ liệu vào DataGridView
            dataGridView1.DataSource = sinhViens;
        }
        private void thêmMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var addForm = new AddStudentForm();
            addForm.ShowDialog();  // Hiển thị form nhập liệu sinh viên

           
            LoadData();
        }
   

        private void tìmKiếmTheoTênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var searchText = txtSearch.Text.ToLower();

            // Tìm sinh viên theo tên (không phân biệt chữ hoa chữ thường)
            var result = dbContext.SinhVien
                                  .Where(s => s.Ten.ToLower().Contains(searchText))
                                  .ToList();        
            dataGridView1.DataSource = result;
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

        private void frmMain2_Load(object sender, EventArgs e)
        {
            LoadData(); 
        }
    }
}

