namespace Lab3_03
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
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
            this.dataGridView1.Location = new System.Drawing.Point(0, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(656, 267);
            this.dataGridView1.TabIndex = 1;
            // 
            // SoTT
            // 
            this.SoTT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SoTT.HeaderText = "Số TT";
            this.SoTT.Name = "SoTT";
            this.SoTT.ReadOnly = true;
            // 
            // MaSo
            // 
            this.MaSo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaSo.HeaderText = "Mã Số SV";
            this.MaSo.Name = "MaSo";
            this.MaSo.ReadOnly = true;
            // 
            // Ten
            // 
            this.Ten.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Ten.HeaderText = "Tên Sinh Viên";
            this.Ten.Name = "Ten";
            this.Ten.ReadOnly = true;
            // 
            // Khoa
            // 
            this.Khoa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Khoa.HeaderText = "Khoa";
            this.Khoa.Name = "Khoa";
            this.Khoa.ReadOnly = true;
            // 
            // Diem
            // 
            this.Diem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Diem.HeaderText = "Điểm TB";
            this.Diem.Name = "Diem";
            this.Diem.ReadOnly = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
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
            this.chToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.chToolStripMenuItem.Text = "Chức Năng";
            // 
            // thêmMớiToolStripMenuItem
            // 
            this.thêmMớiToolStripMenuItem.Name = "thêmMớiToolStripMenuItem";
            this.thêmMớiToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.thêmMớiToolStripMenuItem.Text = "Thêm Mới";
            this.thêmMớiToolStripMenuItem.Click += new System.EventHandler(this.thêmMớiToolStripMenuItem_Click);
            // 
            // tìmKiếmTheoTênToolStripMenuItem
            // 
            this.tìmKiếmTheoTênToolStripMenuItem.Name = "tìmKiếmTheoTênToolStripMenuItem";
            this.tìmKiếmTheoTênToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.tìmKiếmTheoTênToolStripMenuItem.Text = "Tìm Kiếm Theo Tên";
            this.tìmKiếmTheoTênToolStripMenuItem.Click += new System.EventHandler(this.tìmKiếmTheoTênToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ThemMoi,
            this.btnSearch,
            this.toolStripLabel2,
            this.txtSearch,
            this.ShowAll});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // ThemMoi
            // 
            this.ThemMoi.Image = ((System.Drawing.Image)(resources.GetObject("ThemMoi.Image")));
            this.ThemMoi.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ThemMoi.Name = "ThemMoi";
            this.ThemMoi.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ThemMoi.Size = new System.Drawing.Size(82, 22);
            this.ThemMoi.Text = "Thêm mới";
            this.ThemMoi.Click += new System.EventHandler(this.thêmMớiToolStripMenuItem_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(130, 22);
            this.btnSearch.Text = "Tìm Kiếm Theo Tên";
            this.btnSearch.Click += new System.EventHandler(this.tìmKiếmTheoTênToolStripMenuItem_Click);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(0, 22);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(100, 25);
            // 
            // ShowAll
            // 
            this.ShowAll.Image = ((System.Drawing.Image)(resources.GetObject("ShowAll.Image")));
            this.ShowAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ShowAll.Name = "ShowAll";
            this.ShowAll.Size = new System.Drawing.Size(183, 22);
            this.ShowAll.Text = "Hiển Thị Danh Sách Sinh Viên";
            this.ShowAll.Click += new System.EventHandler(this.ShowAll_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmMain_Load);
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
    }
}

