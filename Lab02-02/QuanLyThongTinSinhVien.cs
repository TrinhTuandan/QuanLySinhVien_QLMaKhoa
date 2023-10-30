using System;
using Lab02_02;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Lab02_02.Models;
using System.Runtime.Remoting.Contexts;
using System.Data.Entity.Migrations;
using System.Diagnostics.Eventing.Reader;
using System.Data.Entity.Core.Common.CommandTrees;

namespace Lab02_02
{
    public partial class frmQuanLySinhVien : Form
    {
        StudentDBContext context;
        public frmQuanLySinhVien()
        {
            InitializeComponent();
            context = new StudentDBContext();
        }

        // Load thông tin sinh viên và khoa 
        private void frmQuanLySinhVien_Load(object sender, EventArgs e)
        {
            cmdKhoa.SelectedIndex = 0;
            try
            {               
                List<Faculty> listFalcultys = context.Faculty.ToList(); //lây các khoa
                List<Student> listStudent = context.Student.ToList(); //lây sinh viên
                FillFalcultyCombobox(listFalcultys);
                BindGrid(listStudent);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Hàm binding list có tên hiển thị là tên khoa, giá trị là Mã khoa - Phương thức FillFalcultyCombobox được sử dụng để đổ danh sách khoa vào combobox cmdKhoa.
        private void FillFalcultyCombobox(List<Faculty> listFalcultys)
        {
            this.cmdKhoa.DataSource = listFalcultys;
            this.cmdKhoa.DisplayMember = "FacultyName";
            this.cmdKhoa.ValueMember = "FacultyID";
        }
        //Phương thức BindGrid được sử dụng để hiển thị danh sách sinh viên lên DataGridView 
        private void BindGrid(List<Student> listStudent)
        {
            dgvDSSV.Rows.Clear();
            foreach (var item in listStudent)
            {
                int index = dgvDSSV.Rows.Add();
                dgvDSSV.Rows[index].Cells[0].Value = item.StudentID;
                dgvDSSV.Rows[index].Cells[1].Value = item.FullName;
                dgvDSSV.Rows[index].Cells[2].Value = item.Faculty.FacultyName;
                dgvDSSV.Rows[index].Cells[3].Value = item.AverageScore;
            }
        }

        //click DataGridView
        private void dgvDSSV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvDSSV.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dgvDSSV.CurrentRow.Selected = true;

                    txtMSSV.Text = dgvDSSV.Rows[e.RowIndex].Cells["dgMSSV"].FormattedValue.ToString();
                    txtHoTen.Text = dgvDSSV.Rows[e.RowIndex].Cells["dgHoTen"].FormattedValue.ToString();
                    cmdKhoa.SelectedIndex = cmdKhoa.FindString(dgvDSSV.Rows[e.RowIndex].Cells["dgKhoa"].FormattedValue.ToString());
                    txtDtb.Text = dgvDSSV.Rows[e.RowIndex].Cells["dgDTB"].FormattedValue.ToString();
               
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        //-------------------------------------------------------------------------------------------------------
        //Đây là một phương thức dùng để tìm dòng được chọn trong bảng dữ liệu (dgvDSSV) dựa trên MSSV (Mã số sinh viên) được truyền vào.
        private int GetSeclectedRow(string MSSV)
        {
            for (int i = 0; i < dgvDSSV.Rows.Count; i++)
            {
                if (dgvDSSV.Rows[i].Cells[0].Value != null)
                {
                   if (dgvDSSV.Rows[i].Cells[0].Value.ToString() == MSSV)
                   {
                        return i;
                   } 
                }        
            }
            return -1;
        }
        // check validate
        private bool CheckValidate()
        {
            if (txtMSSV.Text == "" || txtHoTen.Text == "" || txtDtb.Text == "")
            {
                MessageBox.Show("Vui long Nhập Đây Đủ Thông Tin Sinh Viên!", "Thông Báo", MessageBoxButtons.OK);
                return false;
            }
            
            return true;
        }

        //Load lại thông tin trên dataGridview
        private void reloadDGV()
        {
            List<Student> ListStudents = context.Student.ToList();
            BindGrid(ListStudents);
        }

        // Refresh các ô nhập dữ liệu
        private void Refresh()
        {
            txtMSSV.Text = "";
            txtHoTen.Text = "";
            txtDtb.Text = "";
            cmdKhoa.SelectedIndex = 0;
        }

        // Thêm Sinh Viên
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (CheckValidate())
            {
                string mssv = txtMSSV.Text.Trim();
                int rowIndex = GetSeclectedRow(mssv);
                if (rowIndex == -1)
                {
                    Student newStudent = new Student
                    {
                        StudentID = mssv,
                        FullName = txtHoTen.Text,
                        AverageScore = double.Parse(txtDtb.Text),
                        FacultyID = int.Parse(cmdKhoa.SelectedValue.ToString()),
                    };
                    context.Student.AddOrUpdate(newStudent);
                    context.SaveChanges();

                    reloadDGV();
                    Refresh();

                    MessageBox.Show("Thêm mới dữ liệu thành công!", "Thông Báo", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Sinh viên đã tồn tại!", "Thông Báo", MessageBoxButtons.OK);
                }
            }          
        }

        //Thay Đổi thông tin Sinh Viên
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (CheckValidate())
            {
                // Tìm sinh viên theo MSSV cũ
                Student dbUpdate = context.Student.FirstOrDefault(p => p.StudentID == txtMSSV.Text);
                if ( dbUpdate != null)
                {

                    dbUpdate.FullName = txtHoTen.Text;
                    dbUpdate.AverageScore = double.Parse(txtDtb.Text);
                    dbUpdate.FacultyID = int.Parse(cmdKhoa.SelectedValue.ToString());
                    

                    context.SaveChanges();// Lưu Thay đổi 

                    reloadDGV();

                    Refresh();
                    MessageBox.Show("Thêm Mới Dữ Liệu Thành Cộng!", "Thông Báo", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("không tìm thấy Sinh viên Cần Sửa!", "Thông Báo", MessageBoxButtons.OK);
                }
            }
        }

        // Xoa 1 Dong trong dataGridview
        private void btnXoa_Click(object sender, EventArgs e)
        {
            Student dbDelete = context.Student.FirstOrDefault(p => p.StudentID == txtMSSV.Text);
            if (dbDelete != null)
            {
                context.Student.Remove(dbDelete);
                context.SaveChanges();
                reloadDGV();
                Refresh();
                MessageBox.Show("Xóa Sinh Viên Thành Cộng!", "Thông Báo", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("không tìm thấy Sinh viên Cần Xóa!", "Thông Báo", MessageBoxButtons.OK);
            }

        }
    
        // Thoát Khỏi Form
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Refresh các ô nhập dữ liệu
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Refresh();
        }



        // Mở form Quản Lý Khoa
        private void tsQuanLyKhoa_Click(object sender, EventArgs e)
        {
            frmQuanLyKhoa KNTT = new frmQuanLyKhoa();
            KNTT.ShowDialog();
        }

        // Mở form Tìm Kiếm
        private void tsTimKiem_Click(object sender, EventArgs e)
        {          
            frmTimKiemKhoa KNTT = new frmTimKiemKhoa();//Khai báo biến đại diện cho from Con
            KNTT.ShowDialog(); // Mở form Tìm Kiêm Khoa
        }

    }
}