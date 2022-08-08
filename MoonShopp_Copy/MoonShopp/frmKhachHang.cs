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
    public partial class frmKhachHang : Form
    {
        BLL_Customers khachhang = new BLL_Customers();
        databaseDataContext db = new databaseDataContext();
        public frmKhachHang()
        {
            InitializeComponent();
            cboNhomKH.DataSource = db.CustomerTypes.ToList();
            cboNhomKH.DisplayMember = "cusTypeName"; 
            cboNhomKH.ValueMember = "cusType";
            cboTrangThai.DataSource = db.CustomerStatus.ToList();
            cboTrangThai.DisplayMember = "cusStatusName"; 
            cboTrangThai.ValueMember = "cusStatus";
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            dgvKhachHang.DataSource = khachhang.LoadCustomers();
            dgvKhachHang.Columns[0].HeaderText = "Mã khách hàng";
            dgvKhachHang.Columns[1].HeaderText = "Tên khách hàng";
            dgvKhachHang.Columns[2].HeaderText = "Email";
            dgvKhachHang.Columns[3].HeaderText = "Số điện thoại ";
            dgvKhachHang.Columns[4].HeaderText = "Loại khách hàng";
            dgvKhachHang.Columns[5].HeaderText = "Trạng thái khách hàng";
            
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            //Buoc 1
            Customer kh = new Customer();
            //Buoc 2
            kh.cusID = int.Parse(txtMaKhachHang.Text);
            kh.cusName = txtTenKhachHang.Text;
            kh.cusEmail = txtEmail.Text;
            kh.cusPhone = txtSoDienThoai.Text;
            kh.cusType = int.Parse(cboNhomKH.SelectedValue.ToString());
            kh.cusStatus = int.Parse(cboTrangThai.SelectedValue.ToString());
            //Buoc 3
            db.Customers.InsertOnSubmit(kh);
            //Buoc 4
            db.SubmitChanges();
            //Buoc 5 Refresh data
            var khachhangs = from kh1 in db.Customers select kh1;
            dgvKhachHang.DataSource = khachhangs;
            //show kết quả
            MessageBox.Show("Successful Add", "Thông báo");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            //Buoc 1
            String makh = dgvKhachHang.CurrentRow.Cells[0].Value.ToString();
            Customer kh = db.Customers.Where(t => t.cusID == int.Parse(makh)).FirstOrDefault();
            //Buoc 2
            //Buoc 3
            db.Customers.DeleteOnSubmit(kh);
            //Buoc 4
            db.SubmitChanges();
            //Buoc 5 Refresh data
            var khachhangs = from kh1 in db.Customers select kh1;
            dgvKhachHang.DataSource = khachhangs;
            //show kết quả
            MessageBox.Show("Successful Delete", "Thông báo");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            //Buoc 1
            String makh = dgvKhachHang.CurrentRow.Cells[0].Value.ToString();
            Customer kh = db.Customers.Where(t => t.cusID == int.Parse(makh)).FirstOrDefault();
            //Buoc 2
            kh.cusName = txtTenKhachHang.Text;
            kh.cusEmail = txtEmail.Text;
            kh.cusPhone = txtSoDienThoai.Text;
            kh.cusType = int.Parse(cboNhomKH.SelectedValue.ToString());
            kh.cusStatus = int.Parse(cboTrangThai.SelectedValue.ToString());
            //Buoc 3
            //Buoc 4
            db.SubmitChanges();
            //Buoc 5 Refresh data
            var khachhangs = from kh1 in db.Customers select kh1;
            dgvKhachHang.DataSource = khachhangs;
            //show kết quả
            MessageBox.Show("Successful Repair", "Thông báo");
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn muốn thoát from Khách hàng không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void frmKhachHang_Click(object sender, EventArgs e)
        {
            
           
        }

        private void dgvKhachHang_Click(object sender, EventArgs e)
        {
            txtMaKhachHang.Text = dgvKhachHang.CurrentRow.Cells[0].Value.ToString();
            txtTenKhachHang.Text = dgvKhachHang.CurrentRow.Cells[1].Value.ToString();
            txtEmail.Text = dgvKhachHang.CurrentRow.Cells[2].Value.ToString();
            txtSoDienThoai.Text = dgvKhachHang.CurrentRow.Cells[3].Value.ToString();
            cboNhomKH.Text = dgvKhachHang.CurrentRow.Cells[4].Value.ToString();
            cboTrangThai.Text = dgvKhachHang.CurrentRow.Cells[5].Value.ToString();
        }

        private void dgvKhachHang_SelectionChanged(object sender, EventArgs e)
        {
            
        }
    }
}
