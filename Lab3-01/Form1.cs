using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

     

        

        private void timerT1(object sender, EventArgs e)
        {
            var date = DateTime.Now.ToString("dd/MM/yyyy");
            var time = DateTime.Now.ToString("hh:mm:ss tt");
            this.toolStripStatusLabel1.Text = string.Format($"Hôm Nay Là Ngày : {date} - Bây Giờ là {time}");
        }

        private void openfile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Video Files| *.mp4;*.avi;*.mkv;*.wmv";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                axWindowsMediaPlayer1.URL = openFileDialog.FileName;
            }
        }

        private void exit(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
