namespace Lab02_02
{
    partial class frmTimKiemKhoa
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmdKhoa = new System.Windows.Forms.ComboBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtMSSV = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.dgvDSSV = new System.Windows.Forms.DataGridView();
            this.dgMSSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgHoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgDTB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTrove = new System.Windows.Forms.Button();
            this.txtSoSv = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSSV)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmdKhoa);
            this.groupBox1.Controls.Add(this.txtHoTen);
            this.groupBox1.Controls.Add(this.txtMSSV);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(221, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(361, 167);
            this.groupBox1.TabIndex = 0;
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
            this.cmdKhoa.Location = new System.Drawing.Point(154, 116);
            this.cmdKhoa.Name = "cmdKhoa";
            this.cmdKhoa.Size = new System.Drawing.Size(179, 24);
            this.cmdKhoa.TabIndex = 7;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(154, 73);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(179, 22);
            this.txtHoTen.TabIndex = 6;
            // 
            // txtMSSV
            // 
            this.txtMSSV.Location = new System.Drawing.Point(154, 36);
            this.txtMSSV.Name = "txtMSSV";
            this.txtMSSV.Size = new System.Drawing.Size(179, 22);
            this.txtMSSV.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Chuyên Ngành";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Họ Tên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã Sinh Viên";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(221, 237);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(95, 38);
            this.btnTimKiem.TabIndex = 11;
            this.btnTimKiem.Text = "Tìm Kiếm ";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(358, 237);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(95, 38);
            this.btnXoa.TabIndex = 12;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
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
            this.dgvDSSV.Location = new System.Drawing.Point(12, 281);
            this.dgvDSSV.Name = "dgvDSSV";
            this.dgvDSSV.ReadOnly = true;
            this.dgvDSSV.RowHeadersWidth = 51;
            this.dgvDSSV.RowTemplate.Height = 24;
            this.dgvDSSV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDSSV.Size = new System.Drawing.Size(751, 210);
            this.dgvDSSV.TabIndex = 13;
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
            // btnTrove
            // 
            this.btnTrove.Location = new System.Drawing.Point(486, 237);
            this.btnTrove.Name = "btnTrove";
            this.btnTrove.Size = new System.Drawing.Size(96, 38);
            this.btnTrove.TabIndex = 14;
            this.btnTrove.Text = "Trở về";
            this.btnTrove.UseVisualStyleBackColor = true;
            this.btnTrove.Click += new System.EventHandler(this.btnTrove_Click);
            // 
            // txtSoSv
            // 
            this.txtSoSv.Location = new System.Drawing.Point(670, 515);
            this.txtSoSv.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoSv.Name = "txtSoSv";
            this.txtSoSv.Size = new System.Drawing.Size(94, 22);
            this.txtSoSv.TabIndex = 15;
            this.txtSoSv.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(556, 518);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "Kết quả tìm kiếm ";
            // 
            // frmTimKiemKhoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 550);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSoSv);
            this.Controls.Add(this.btnTrove);
            this.Controls.Add(this.dgvDSSV);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmTimKiemKhoa";
            this.Text = "Tìm Kiếm";
            this.Load += new System.EventHandler(this.frmTimKiemKhoa_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSSV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmdKhoa;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtMSSV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.DataGridView dgvDSSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgMSSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgHoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgKhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgDTB;
        private System.Windows.Forms.Button btnTrove;
        private System.Windows.Forms.TextBox txtSoSv;
        private System.Windows.Forms.Label label3;
    }
}