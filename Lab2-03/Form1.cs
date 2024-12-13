using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSeat(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn.BackColor == Color.White)
                btn.BackColor = Color.Blue;
            else if (btn.BackColor == Color.Blue)
                btn.BackColor = Color.White;
            else if (btn.BackColor == Color.Yellow)
                MessageBox.Show("Ghế đã được bán!!");

        }

        private void btnChon(object sender, EventArgs e)
        {
            int total = 0;

            foreach (Control group in this.Controls.OfType<GroupBox>())
            {
                foreach (Button seat in group.Controls.OfType<Button>())
                {
                    if (seat.BackColor == Color.Blue)
                    {
                        seat.BackColor = Color.Yellow; // Đánh dấu ghế đã bán
                        int seatNumber = int.Parse(seat.Text);
                        total += GetSeatPrice(seatNumber);
                    }
                }
            }

            txtTotal.Text = $" {total}đ";
        }

        private int GetSeatPrice(int seatNumber)
        {
            if (seatNumber >= 1 && seatNumber <= 5) return 30000;
            if (seatNumber >= 6 && seatNumber <= 10) return 40000;
            if (seatNumber >= 11 && seatNumber <= 15) return 50000;
            return 80000;
        }

        private void btnCacel_Click(object sender, EventArgs e)
        {
            
            foreach (Control group in this.Controls.OfType<GroupBox>())
            {
                foreach (Button seat in group.Controls.OfType<Button>())
                {
                    if (seat.BackColor == Color.Blue)
                    {
                        seat.BackColor = Color.White; // Bỏ chọn ghế
                    }
                }
            }

            txtTotal.Text = " 0đ";
        }

    }
}
    

