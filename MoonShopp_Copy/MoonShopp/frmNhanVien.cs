using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DAL;
namespace MoonShopp
{
    public partial class frmNhanVien : Form
    {
        BLL__Employees nhanvien = new BLL__Employees();
        databaseDataContext db = new databaseDataContext();
        public frmNhanVien()
        {
            InitializeComponent();
            cboQuyen.DataSource = db.EmployeesRoles.ToList();
            cboQuyen.DisplayMember = "empRoleName";
            cboQuyen.ValueMember = "empRole";
        }
        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            dgvNhanVien.DataSource = nhanvien.LoadEmployees();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            //Buoc 1
            Employee nv = new Employee();
            //Buoc 2
            nv.empID = int.Parse(txtMaNhanVien.Text);
            nv.empName = txtTenNhanVien.Text;
            nv.empDate = (DateTime)(dtpNgaySinh.Value);
            nv.empPhoto = txtHinhNhanVien.Text;
            nv.empAddress = txtDiaChi.Text;
            nv.empSalary = int.Parse(txtLuong.Text);
            nv.empPhone = txtSoDienThoai.Text;
            nv.empBonus = int.Parse(txtTienThuong.Text);
            nv.empStartTime = (DateTime)(dtpThoiGianBatDau.Value);
            nv.empEmail = txtEmail.Text;
            nv.empPassword = txtMatKhau.Text;
            nv.empRole = int.Parse(cboQuyen.SelectedValue.ToString());
            //Buoc 3
            db.Employees.InsertOnSubmit(nv);
            //Buoc 4
            db.SubmitChanges();
            //Buoc 5 Refresh data
            var nhanviens = from nv1 in db.Employees select nv1;
            dgvNhanVien.DataSource = nhanviens;
            //show kết quả
            MessageBox.Show("Successful Add", "Thông báo");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            //Buoc 1
            String manv = dgvNhanVien.CurrentRow.Cells[0].Value.ToString();
            Employee nv = db.Employees.Where(t => t.empID == int.Parse(manv)).FirstOrDefault();
            //Buoc 2
            nv.empName = txtTenNhanVien.Text;
            nv.empDate = (DateTime)(dtpNgaySinh.Value);
            nv.empPhoto = txtHinhNhanVien.Text;
            nv.empAddress = txtDiaChi.Text;
            nv.empSalary = int.Parse(txtLuong.Text);
            nv.empBonus = int.Parse(txtTienThuong.Text);
            nv.empStartTime = (DateTime)(dtpThoiGianBatDau.Value);
            nv.empEmail = txtEmail.Text;
            nv.empPhone = txtSoDienThoai.Text;
            nv.empPassword = txtMatKhau.Text;
            nv.empRole = int.Parse(cboQuyen.SelectedValue.ToString());
            //Buoc 3
            //db.Employees.InsertOnSubmit(nv);
            //Buoc 4
            db.SubmitChanges();
            //Buoc 5 Refresh data
            var nhanviens = from nv1 in db.Employees select nv1;
            dgvNhanVien.DataSource = nhanviens;
            //show kết quả
            MessageBox.Show("Successful Repair", "Thông báo");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            //Buoc 1
            String manv = dgvNhanVien.CurrentRow.Cells[0].Value.ToString();
            Employee nv = db.Employees.Where(t => t.empID == int.Parse(manv)).FirstOrDefault();
            //Buoc 2
            //Buoc 3
            db.Employees.DeleteOnSubmit(nv);
            //Buoc 4
            db.SubmitChanges();
            //Buoc 5 Refresh data
            var nhanviens = from nv1 in db.Employees select nv1;
            dgvNhanVien.DataSource = nhanviens;
            //show kết quả
            MessageBox.Show("Successful Delete", "Thông báo");
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn có muốn from Nhân viên không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            string filepath = null;
            OpenFileDialog ofdImages = new OpenFileDialog();
            PictureBox objpt = new PictureBox();
            if (ofdImages.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile("" + ofdImages.FileName);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                filepath = ofdImages.FileName;
            }
            txtHinhNhanVien.Text = filepath;
            //String manv = dgvNhanVien.CurrentRow.Cells[0].Value.ToString();
            //Employee nv = db.Employees.Where(t => t.empPhoto == manv).FirstOrDefault();
        }

        private void dgvNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            String mahnv = dgvNhanVien.CurrentRow.Cells[3].Value.ToString();
            pictureBox1.Image = Image.FromFile(mahnv);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void dgvNhanVien_SelectionChanged(object sender, EventArgs e)
        {
            
        }

        private void dgvNhanVien_Click(object sender, EventArgs e)
        {
            txtMaNhanVien.Text = dgvNhanVien.CurrentRow.Cells[0].Value.ToString();
            txtTenNhanVien.Text = dgvNhanVien.CurrentRow.Cells[1].Value.ToString();
            dtpNgaySinh.Text = dgvNhanVien.CurrentRow.Cells[2].Value.ToString();
            pictureBox1.Image = Image.FromFile(dgvNhanVien.CurrentRow.Cells[3].Value.ToString());
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            txtHinhNhanVien.Text = dgvNhanVien.CurrentRow.Cells[3].Value.ToString();
            txtDiaChi.Text = dgvNhanVien.CurrentRow.Cells[4].Value.ToString();
            txtLuong.Text = dgvNhanVien.CurrentRow.Cells[5].Value.ToString();
            txtTienThuong.Text = dgvNhanVien.CurrentRow.Cells[6].Value.ToString();
            dtpThoiGianBatDau.Text = dgvNhanVien.CurrentRow.Cells[7].Value.ToString();
            txtEmail.Text = dgvNhanVien.CurrentRow.Cells[8].Value.ToString();
            txtSoDienThoai.Text = dgvNhanVien.CurrentRow.Cells[9].Value.ToString();
            txtMatKhau.Text = dgvNhanVien.CurrentRow.Cells[10].Value.ToString();
            cboQuyen.Text = dgvNhanVien.CurrentRow.Cells[11].Value.ToString();
        }
    }
}
