namespace Lab3_03
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SoTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaSo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Khoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.chToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmMớiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tìmKiếmTheoTênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ThemMoi = new System.Windows.Forms.ToolStripButton();
            this.btnSearch = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.txtSearch = new System.Windows.Forms.ToolStripTextBox();
            this.ShowAll = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SoTT,
            this.MaSo,
            this.Ten,
            this.Khoa,
            this.Diem});
            this.dataGridView1.Location = new System.Drawing.Point(0, 64);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1054, 396);
            this.dataGridView1.TabIndex = 1;
            // 
            // SoTT
            // 
            this.SoTT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SoTT.HeaderText = "Số TT";
            this.SoTT.MinimumWidth = 6;
            this.SoTT.Name = "SoTT";
            this.SoTT.ReadOnly = true;
            // 
            // MaSo
            // 
            this.MaSo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaSo.HeaderText = "Mã Số SV";
            this.MaSo.MinimumWidth = 6;
            this.MaSo.Name = "MaSo";
            this.MaSo.ReadOnly = true;
            // 
            // Ten
            // 
            this.Ten.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Ten.HeaderText = "Tên Sinh Viên";
            this.Ten.MinimumWidth = 6;
            this.Ten.Name = "Ten";
            this.Ten.ReadOnly = true;
            // 
            // Khoa
            // 
            this.Khoa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Khoa.HeaderText = "Khoa";
            this.Khoa.MinimumWidth = 6;
            this.Khoa.Name = "Khoa";
            this.Khoa.ReadOnly = true;
            // 
            // Diem
            // 
            this.Diem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Diem.HeaderText = "Điểm TB";
            this.Diem.MinimumWidth = 6;
            this.Diem.Name = "Diem";
            this.Diem.ReadOnly = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1067, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // chToolStripMenuItem
            // 
            this.chToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmMớiToolStripMenuItem,
            this.tìmKiếmTheoTênToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.chToolStripMenuItem.Name = "chToolStripMenuItem";
            this.chToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
            this.chToolStripMenuItem.Text = "Chức Năng";
            // 
            // thêmMớiToolStripMenuItem
            // 
            this.thêmMớiToolStripMenuItem.Name = "thêmMớiToolStripMenuItem";
            this.thêmMớiToolStripMenuItem.Size = new System.Drawing.Size(219, 26);
            this.thêmMớiToolStripMenuItem.Text = "Thêm Mới";
            this.thêmMớiToolStripMenuItem.Click += new System.EventHandler(this.thêmMớiToolStripMenuItem_Click);
            // 
            // tìmKiếmTheoTênToolStripMenuItem
            // 
            this.tìmKiếmTheoTênToolStripMenuItem.Name = "tìmKiếmTheoTênToolStripMenuItem";
            this.tìmKiếmTheoTênToolStripMenuItem.Size = new System.Drawing.Size(219, 26);
            this.tìmKiếmTheoTênToolStripMenuItem.Text = "Tìm Kiếm Theo Tên";
            this.tìmKiếmTheoTênToolStripMenuItem.Click += new System.EventHandler(this.tìmKiếmTheoTênToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(219, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ThemMoi,
            this.btnSearch,
            this.toolStripLabel2,
            this.txtSearch,
            this.ShowAll,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1067, 27);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // ThemMoi
            // 
            this.ThemMoi.Image = ((System.Drawing.Image)(resources.GetObject("ThemMoi.Image")));
            this.ThemMoi.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ThemMoi.Name = "ThemMoi";
            this.ThemMoi.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ThemMoi.Size = new System.Drawing.Size(100, 24);
            this.ThemMoi.Text = "Thêm mới";
            this.ThemMoi.Click += new System.EventHandler(this.thêmMớiToolStripMenuItem_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(160, 24);
            this.btnSearch.Text = "Tìm Kiếm Theo Tên";
            this.btnSearch.Click += new System.EventHandler(this.tìmKiếmTheoTênToolStripMenuItem_Click);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(0, 24);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(132, 27);
            // 
            // ShowAll
            // 
            this.ShowAll.Image = ((System.Drawing.Image)(resources.GetObject("ShowAll.Image")));
            this.ShowAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ShowAll.Name = "ShowAll";
            this.ShowAll.Size = new System.Drawing.Size(227, 24);
            this.ShowAll.Text = "Hiển Thị Danh Sách Sinh Viên";
            this.ShowAll.Click += new System.EventHandler(this.ShowAll_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(164, 24);
            this.toolStripButton1.Text = "Chỉnh Sửa Sinh Viên";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem chToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thêmMớiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tìmKiếmTheoTênToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton ThemMoi;
        private System.Windows.Forms.ToolStripButton btnSearch;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn Khoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diem;
        private System.Windows.Forms.ToolStripTextBox txtSearch;
        private System.Windows.Forms.ToolStripButton ShowAll;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}

