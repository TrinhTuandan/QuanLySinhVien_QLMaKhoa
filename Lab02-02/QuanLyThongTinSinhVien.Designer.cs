namespace Lab02_02
{
    partial class frmQuanLySinhVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLySinhVien));
            this.btnXoa = new System.Windows.Forms.Button();
            this.txtMSSV = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmdKhoa = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDtb = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.dgvDSSV = new System.Windows.Forms.DataGridView();
            this.dgMSSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgHoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgDTB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ChucNangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmQuanLyKhoa = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmTimKiem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsQuanLyKhoa = new System.Windows.Forms.ToolStripButton();
            this.tsTimKiem = new System.Windows.Forms.ToolStripButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSSV)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(223, 374);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(95, 53);
            this.btnXoa.TabIndex = 1;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // txtMSSV
            // 
            this.txtMSSV.Location = new System.Drawing.Point(126, 48);
            this.txtMSSV.Name = "txtMSSV";
            this.txtMSSV.Size = new System.Drawing.Size(164, 22);
            this.txtMSSV.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmdKhoa);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtDtb);
            this.groupBox1.Controls.Add(this.txtHoTen);
            this.groupBox1.Controls.Add(this.txtMSSV);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 103);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(315, 225);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Sinh Viên";
            // 
            // cmdKhoa
            // 
            this.cmdKhoa.FormattingEnabled = true;
            this.cmdKhoa.Items.AddRange(new object[] {
            "QTKD",
            "CNTT",
            "NNA"});
            this.cmdKhoa.Location = new System.Drawing.Point(126, 131);
            this.cmdKhoa.Name = "cmdKhoa";
            this.cmdKhoa.Size = new System.Drawing.Size(164, 24);
            this.cmdKhoa.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Chuyên Ngành";
            // 
            // txtDtb
            // 
            this.txtDtb.Location = new System.Drawing.Point(126, 175);
            this.txtDtb.Name = "txtDtb";
            this.txtDtb.Size = new System.Drawing.Size(164, 22);
            this.txtDtb.TabIndex = 4;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(126, 90);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(164, 22);
            this.txtHoTen.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Điểm TB";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ Tên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Sinh Viên";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label8.Location = new System.Drawing.Point(259, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(536, 42);
            this.label8.TabIndex = 1;
            this.label8.Text = "Quản Lý Thông Tin Sinh Viên";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(17, 374);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(95, 53);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dgvDSSV
            // 
            this.dgvDSSV.AllowUserToAddRows = false;
            this.dgvDSSV.AllowUserToDeleteRows = false;
            this.dgvDSSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSSV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgMSSV,
            this.dgHoTen,
            this.dgKhoa,
            this.dgDTB});
            this.dgvDSSV.Location = new System.Drawing.Point(347, 113);
            this.dgvDSSV.Name = "dgvDSSV";
            this.dgvDSSV.ReadOnly = true;
            this.dgvDSSV.RowHeadersWidth = 51;
            this.dgvDSSV.RowTemplate.Height = 24;
            this.dgvDSSV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDSSV.Size = new System.Drawing.Size(643, 314);
            this.dgvDSSV.TabIndex = 6;
            this.dgvDSSV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSSV_CellClick);
            // 
            // dgMSSV
            // 
            this.dgMSSV.HeaderText = "Mã Số SV";
            this.dgMSSV.MinimumWidth = 6;
            this.dgMSSV.Name = "dgMSSV";
            this.dgMSSV.ReadOnly = true;
            this.dgMSSV.Width = 125;
            // 
            // dgHoTen
            // 
            this.dgHoTen.HeaderText = "Họ Tên";
            this.dgHoTen.MinimumWidth = 6;
            this.dgHoTen.Name = "dgHoTen";
            this.dgHoTen.ReadOnly = true;
            this.dgHoTen.Width = 125;
            // 
            // dgKhoa
            // 
            this.dgKhoa.HeaderText = "Tên Khoa";
            this.dgKhoa.MinimumWidth = 6;
            this.dgKhoa.Name = "dgKhoa";
            this.dgKhoa.ReadOnly = true;
            this.dgKhoa.Width = 125;
            // 
            // dgDTB
            // 
            this.dgDTB.HeaderText = "Điểm TB";
            this.dgDTB.MinimumWidth = 6;
            this.dgDTB.Name = "dgDTB";
            this.dgDTB.ReadOnly = true;
            this.dgDTB.Width = 125;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(124, 374);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(93, 53);
            this.btnSua.TabIndex = 7;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(841, 446);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 8;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(138, 334);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 9;
            this.btnRefresh.Text = "Refresh Các Ô";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ChucNangToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1018, 28);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ChucNangToolStripMenuItem
            // 
            this.ChucNangToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmQuanLyKhoa,
            this.tsmTimKiem,
            this.toolStripSeparator1,
            this.thoátToolStripMenuItem});
            this.ChucNangToolStripMenuItem.Name = "ChucNangToolStripMenuItem";
            this.ChucNangToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
            this.ChucNangToolStripMenuItem.Text = "Chức Năng";
            // 
            // tsmQuanLyKhoa
            // 
            this.tsmQuanLyKhoa.Name = "tsmQuanLyKhoa";
            this.tsmQuanLyKhoa.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.tsmQuanLyKhoa.Size = new System.Drawing.Size(208, 26);
            this.tsmQuanLyKhoa.Text = "Quản lý khoa ";
            this.tsmQuanLyKhoa.Click += new System.EventHandler(this.tsQuanLyKhoa_Click);
            // 
            // tsmTimKiem
            // 
            this.tsmTimKiem.Name = "tsmTimKiem";
            this.tsmTimKiem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.tsmTimKiem.Size = new System.Drawing.Size(208, 26);
            this.tsmTimKiem.Text = "Tìm Kiếm ";
            this.tsmTimKiem.Click += new System.EventHandler(this.tsTimKiem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(205, 6);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(208, 26);
            this.thoátToolStripMenuItem.Text = "Thoát ";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsQuanLyKhoa,
            this.tsTimKiem});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1018, 27);
            this.toolStrip1.TabIndex = 11;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsQuanLyKhoa
            // 
            this.tsQuanLyKhoa.Image = ((System.Drawing.Image)(resources.GetObject("tsQuanLyKhoa.Image")));
            this.tsQuanLyKhoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsQuanLyKhoa.Name = "tsQuanLyKhoa";
            this.tsQuanLyKhoa.Size = new System.Drawing.Size(119, 24);
            this.tsQuanLyKhoa.Text = "Quản lý khoa";
            this.tsQuanLyKhoa.Click += new System.EventHandler(this.tsQuanLyKhoa_Click);
            // 
            // tsTimKiem
            // 
            this.tsTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("tsTimKiem.Image")));
            this.tsTimKiem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsTimKiem.Name = "tsTimKiem";
            this.tsTimKiem.Size = new System.Drawing.Size(96, 24);
            this.tsTimKiem.Text = "Tìm Kiếm";
            this.tsTimKiem.Click += new System.EventHandler(this.tsTimKiem_Click);
            // 
            // frmQuanLySinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 513);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.dgvDSSV);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.label8);
            this.Name = "frmQuanLySinhVien";
            this.Text = "Quản Lý Thông Tin Sinh Vien";
            this.Load += new System.EventHandler(this.frmQuanLySinhVien_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSSV)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.TextBox txtMSSV;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmdKhoa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dgvDSSV;
        private System.Windows.Forms.TextBox txtDtb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgMSSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgHoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgKhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgDTB;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ChucNangToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmQuanLyKhoa;
        private System.Windows.Forms.ToolStripMenuItem tsmTimKiem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsQuanLyKhoa;
        private System.Windows.Forms.ToolStripButton tsTimKiem;
    }
}

