using Lab02_02.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02_02
{
    public partial class frmQuanLyKhoa : Form
    {
        StudentDBContext context;
        public frmQuanLyKhoa()
        {
            InitializeComponent();
            context = new StudentDBContext();
        }

        // Load thông tin  khoa 
        private void frmQuanLyKhoa_Load(object sender, EventArgs e)
        {
           
            try
            {
                List<Faculty> listFalcultys = context.Faculty.ToList(); //lây các khoa
                List<Student> listStudent = context.Student.ToList(); //lây sinh viên
                FillFalcultyCombobox(listFalcultys);
                BindGrid(listStudent);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Hàm binding list có tên hiển thị là tên khoa, giá trị là Mã khoa , Tổng 
        private void FillFalcultyCombobox(List<Faculty> listFalcultys)
        {
            // Assuming txtMKhoa is your ComboBox for selecting faculties
           // txtMKhoa.DataSource = listFalcultys;
           // txtMKhoa.DisplayMember = "FacultyName";
           // txtMKhoa.ValueMember = "FacultyID";
        }
        //Phương thức BindGrid được sử dụng để hiển thị danh sách sinh viên lên DataGridView 
        private void BindGrid(List<Student> listStudent)
        {
            dgvDSKhoa.Rows.Clear();

            foreach (var student in listStudent)
            {
                int index = dgvDSKhoa.Rows.Add();
                dgvDSKhoa.Rows[index].Cells[0].Value = student.StudentID;
                dgvDSKhoa.Rows[index].Cells[1].Value = student.FullName;
                dgvDSKhoa.Rows[index].Cells[2].Value = student.Faculty.FacultyName;
                dgvDSKhoa.Rows[index].Cells[3].Value = student.AverageScore;
            }
        }

        //click DataGridView
        private void dgvDSSV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvDSKhoa.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dgvDSKhoa.CurrentRow.Selected = true;
                    txtMKhoa.Text = dgvDSKhoa.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                    txtTenKhoa.Text = dgvDSKhoa.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                    txtTongGS.Text = dgvDSKhoa.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn Đóng ", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void bntThemXoa_Click(object sender, EventArgs e)
        {

        }

        private void bntXoa_Click(object sender, EventArgs e)
        {

        }

    
    }
}
