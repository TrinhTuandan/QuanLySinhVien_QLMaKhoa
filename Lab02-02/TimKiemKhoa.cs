using Lab02_02.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02_02
{
    public partial class frmTimKiemKhoa : Form
    {
        StudentDBContext context;
        public frmTimKiemKhoa()
        {
            InitializeComponent();
            context = new StudentDBContext();
        } 
        
        private void frmTimKiemKhoa_Load(object sender, EventArgs e)
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
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        // Chức năng tìm kiếm sinh viên 
        private void btnTimKiem_Click(object sender, EventArgs e)
        {

        }


        //Load lại thông tin trên dataGridview
        private void reloadDGV()
        {
            List<Student> ListStudents = context.Student.ToList();
            BindGrid(ListStudents);
        }

        //chức năng Xóa
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
        
        // Chức năng trở về form Quản lý thông tin sinh viên 
        private void btnTrove_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn Trở về", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close(); 
            }
        }
    }
}
