namespace Lab2_04
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtSoTaiKhoan = new System.Windows.Forms.TextBox();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtSoTien = new System.Windows.Forms.TextBox();
            this.lvTaiKhoan = new System.Windows.Forms.ListView();
            this.STT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MaTK = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnThemCapNhat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtSoTaiKhoan
            // 
            this.txtSoTaiKhoan.Location = new System.Drawing.Point(273, 91);
            this.txtSoTaiKhoan.Name = "txtSoTaiKhoan";
            this.txtSoTaiKhoan.Size = new System.Drawing.Size(309, 20);
            this.txtSoTaiKhoan.TabIndex = 0;
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(273, 127);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(309, 20);
            this.txtTenKH.TabIndex = 0;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(273, 163);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(309, 20);
            this.txtDiaChi.TabIndex = 0;
            // 
            // txtSoTien
            // 
            this.txtSoTien.Location = new System.Drawing.Point(273, 200);
            this.txtSoTien.Name = "txtSoTien";
            this.txtSoTien.Size = new System.Drawing.Size(309, 20);
            this.txtSoTien.TabIndex = 0;
            // 
            // lvTaiKhoan
            // 
            this.lvTaiKhoan.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.STT,
            this.MaTK,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvTaiKhoan.HideSelection = false;
            this.lvTaiKhoan.Location = new System.Drawing.Point(94, 279);
            this.lvTaiKhoan.Name = "lvTaiKhoan";
            this.lvTaiKhoan.Size = new System.Drawing.Size(642, 245);
            this.lvTaiKhoan.TabIndex = 1;
            this.lvTaiKhoan.UseCompatibleStateImageBehavior = false;
            this.lvTaiKhoan.View = System.Windows.Forms.View.Details;
            this.lvTaiKhoan.SelectedIndexChanged += new System.EventHandler(this.lvTaiKhoan_SelectedIndexChanged);
            // 
            // STT
            // 
            this.STT.Text = "STT";
            // 
            // MaTK
            // 
            this.MaTK.Text = "Mã Tài Khoản";
            this.MaTK.Width = 118;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Họ Tên Khách Hàng";
            this.columnHeader1.Width = 197;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Địa Chỉ";
            this.columnHeader2.Width = 112;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Số tiền";
            this.columnHeader3.Width = 375;
            // 
            // btnThemCapNhat
            // 
            this.btnThemCapNhat.Location = new System.Drawing.Point(205, 238);
            this.btnThemCapNhat.Name = "btnThemCapNhat";
            this.btnThemCapNhat.Size = new System.Drawing.Size(116, 23);
            this.btnThemCapNhat.TabIndex = 2;
            this.btnThemCapNhat.Text = "Thêm / Cập Nhật";
            this.btnThemCapNhat.UseVisualStyleBackColor = true;
            this.btnThemCapNhat.Click += new System.EventHandler(this.btnThemCapNhat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(373, 238);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(487, 238);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Thoát";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label1.Location = new System.Drawing.Point(145, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Số Tài Khoản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label2.Location = new System.Drawing.Point(116, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên Khách Hàng :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label3.Location = new System.Drawing.Point(96, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Địa Chỉ Khách Hàng :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label4.Location = new System.Drawing.Point(63, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(204, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Số Tiền Trong Tài Khoản :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(289, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(318, 39);
            this.label5.TabIndex = 3;
            this.label5.Text = "Quản Lí Tài Khoản";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label6.Location = new System.Drawing.Point(415, 563);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Tổng Tiền :";
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(515, 560);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(179, 20);
            this.txtTongTien.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 598);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThemCapNhat);
            this.Controls.Add(this.lvTaiKhoan);
            this.Controls.Add(this.txtSoTien);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.txtTenKH);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.txtSoTaiKhoan);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSoTaiKhoan;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtSoTien;
        private System.Windows.Forms.ListView lvTaiKhoan;
        private System.Windows.Forms.Button btnThemCapNhat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ColumnHeader STT;
        private System.Windows.Forms.ColumnHeader MaTK;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTongTien;
    }
}

