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
    public partial class frmGioHang : Form
    {
        databaseDataContext db = new databaseDataContext();
        BLL_Carts giohang = new BLL_Carts();
        public frmGioHang()
        {
            InitializeComponent();
        }

        private void frmGioHang_Load(object sender, EventArgs e)
        {
            dgvGioHang.DataSource = giohang.LoadCarts();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            //Buoc 1
            Cart gh = new Cart();
            //Buoc 2
            gh.catID = int.Parse(txtMaGioHang.Text);
            gh.proID = int.Parse(txtMaSanPham.Text);
            gh.proPrice= int.Parse(txtGiaTienSanPham.Text);
            gh.catID = int.Parse(txtSoLuongGioHang.Text);
            gh.cartMoney = int.Parse(txtTongTienHoaDon.Text);
            //Buoc 3
            db.Carts.InsertOnSubmit(gh);
            //Buoc 4
            db.SubmitChanges();
            //Buoc 5 Refresh data
            var carts = from gh1 in db.Carts select gh1;
            dgvGioHang.DataSource = carts;
            //show kết quả
            MessageBox.Show("Successful Add", "Thông báo");
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            //Buoc 1
            String magh = dgvGioHang.CurrentRow.Cells[0].Value.ToString();
            Cart gh = db.Carts.Where(t => t.catID == int.Parse(magh)).FirstOrDefault();
            //Buoc 2

            //Buoc 3
            db.Carts.DeleteOnSubmit(gh);
            //Buoc 4
            db.SubmitChanges();
            //Buoc 5 Refresh data
            var carts = from gh1 in db.Carts select gh1;
            dgvGioHang.DataSource = carts;
           
            //show kết quả
            MessageBox.Show("Successful Delete", "Thông báo");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            //Buoc 1
            String magh = dgvGioHang.CurrentRow.Cells[0].Value.ToString();
            Cart gh = db.Carts.Where(t => t.catID == int.Parse(magh)).FirstOrDefault();
            //Buoc 2
            gh.proID = int.Parse(txtMaSanPham.Text);
            gh.proPrice = int.Parse(txtGiaTienSanPham.Text);
            gh.cartMoney = int.Parse(txtSoLuongGioHang.Text);
            gh.cartMoney = int.Parse(txtTongTienHoaDon.Text);
            //buoc 3
            //Buoc 4
            db.SubmitChanges();
            //Buoc 5 Refresh data
            var carts = from gh1 in db.Carts select gh1;
            dgvGioHang.DataSource = carts;
            //show kết quả
            MessageBox.Show("Successful Add", "Thông báo");

        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn có muốn đóng from Hãng Sản Xuất không?", "Thông báo",
              MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            this.Close();
        }

        private void dgvGioHang_SelectionChanged(object sender, EventArgs e)
        {
            txtMaGioHang.Text = dgvGioHang.CurrentRow.Cells[0].Value.ToString();
            txtMaSanPham.Text = dgvGioHang.CurrentRow.Cells[1].Value.ToString();
            txtGiaTienSanPham.Text = dgvGioHang.CurrentRow.Cells[2].Value.ToString();
            txtSoLuongGioHang.Text = dgvGioHang.CurrentRow.Cells[3].Value.ToString();
            txtTongTienHoaDon.Text = dgvGioHang.CurrentRow.Cells[4].Value.ToString();
        }

        private void dgvGioHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
