namespace Lab02_02
{
    partial class frmQuanLyKhoa
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
            this.txtTongGS = new System.Windows.Forms.TextBox();
            this.txtTenKhoa = new System.Windows.Forms.TextBox();
            this.txtMKhoa = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDSKhoa = new System.Windows.Forms.DataGridView();
            this.dgMKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgTenKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgTongGS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bntThemXoa = new System.Windows.Forms.Button();
            this.bntXoa = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSKhoa)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTongGS);
            this.groupBox1.Controls.Add(this.txtTenKhoa);
            this.groupBox1.Controls.Add(this.txtMKhoa);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(27, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(318, 167);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Khoa";
            // 
            // txtTongGS
            // 
            this.txtTongGS.Location = new System.Drawing.Point(106, 113);
            this.txtTongGS.Name = "txtTongGS";
            this.txtTongGS.Size = new System.Drawing.Size(179, 22);
            this.txtTongGS.TabIndex = 6;
            // 
            // txtTenKhoa
            // 
            this.txtTenKhoa.Location = new System.Drawing.Point(106, 70);
            this.txtTenKhoa.Name = "txtTenKhoa";
            this.txtTenKhoa.Size = new System.Drawing.Size(179, 22);
            this.txtTenKhoa.TabIndex = 6;
            // 
            // txtMKhoa
            // 
            this.txtMKhoa.Location = new System.Drawing.Point(106, 33);
            this.txtMKhoa.Name = "txtMKhoa";
            this.txtMKhoa.Size = new System.Drawing.Size(179, 22);
            this.txtMKhoa.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Tổng GS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên Khoa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã Khoa";
            // 
            // dgvDSKhoa
            // 
            this.dgvDSKhoa.AllowUserToAddRows = false;
            this.dgvDSKhoa.AllowUserToDeleteRows = false;
            this.dgvDSKhoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSKhoa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgMKhoa,
            this.dgTenKhoa,
            this.dgTongGS});
            this.dgvDSKhoa.Location = new System.Drawing.Point(351, 70);
            this.dgvDSKhoa.Name = "dgvDSKhoa";
            this.dgvDSKhoa.ReadOnly = true;
            this.dgvDSKhoa.RowHeadersWidth = 51;
            this.dgvDSKhoa.RowTemplate.Height = 24;
            this.dgvDSKhoa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDSKhoa.Size = new System.Drawing.Size(486, 338);
            this.dgvDSKhoa.TabIndex = 14;
            this.dgvDSKhoa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSSV_CellClick);
            // 
            // dgMKhoa
            // 
            this.dgMKhoa.HeaderText = "Mã Khoa";
            this.dgMKhoa.MinimumWidth = 6;
            this.dgMKhoa.Name = "dgMKhoa";
            this.dgMKhoa.ReadOnly = true;
            this.dgMKhoa.Width = 125;
            // 
            // dgTenKhoa
            // 
            this.dgTenKhoa.HeaderText = "Tên Khoa";
            this.dgTenKhoa.MinimumWidth = 6;
            this.dgTenKhoa.Name = "dgTenKhoa";
            this.dgTenKhoa.ReadOnly = true;
            this.dgTenKhoa.Width = 125;
            // 
            // dgTongGS
            // 
            this.dgTongGS.HeaderText = "Tổng Số GS";
            this.dgTongGS.MinimumWidth = 6;
            this.dgTongGS.Name = "dgTongGS";
            this.dgTongGS.ReadOnly = true;
            this.dgTongGS.Width = 125;
            // 
            // bntThemXoa
            // 
            this.bntThemXoa.Location = new System.Drawing.Point(82, 290);
            this.bntThemXoa.Name = "bntThemXoa";
            this.bntThemXoa.Size = new System.Drawing.Size(91, 23);
            this.bntThemXoa.TabIndex = 15;
            this.bntThemXoa.Text = "Thêm/ Sửa";
            this.bntThemXoa.UseVisualStyleBackColor = true;
            this.bntThemXoa.Click += new System.EventHandler(this.bntThemXoa_Click);
            // 
            // bntXoa
            // 
            this.bntXoa.Location = new System.Drawing.Point(237, 290);
            this.bntXoa.Name = "bntXoa";
            this.bntXoa.Size = new System.Drawing.Size(75, 23);
            this.bntXoa.TabIndex = 15;
            this.bntXoa.Text = "Xóa";
            this.bntXoa.UseVisualStyleBackColor = true;
            this.bntXoa.Click += new System.EventHandler(this.bntXoa_Click);
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(704, 429);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(75, 23);
            this.btnDong.TabIndex = 15;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(203, 13);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 16;
            // 
            // frmQuanLyKhoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 464);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.bntXoa);
            this.Controls.Add(this.bntThemXoa);
            this.Controls.Add(this.dgvDSKhoa);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmQuanLyKhoa";
            this.Text = "Quản Lý Khoa";
            this.Load += new System.EventHandler(this.frmQuanLyKhoa_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSKhoa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTenKhoa;
        private System.Windows.Forms.TextBox txtMKhoa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDSKhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgMKhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgTenKhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgTongGS;
        private System.Windows.Forms.TextBox txtTongGS;
        private System.Windows.Forms.Button bntThemXoa;
        private System.Windows.Forms.Button bntXoa;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}