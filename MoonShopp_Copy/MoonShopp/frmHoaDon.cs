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
    public partial class frmHoaDon : Form
    {
        databaseDataContext db = new databaseDataContext();
        BLL_Orders hoadon = new BLL_Orders();
        public frmHoaDon()
        {
            InitializeComponent();
            comboBox1.DataSource = db.Products.ToList();
            comboBox1.DisplayMember = "proName";
            comboBox1.ValueMember = "proID";
            cboTenNCC.DataSource = db.ProducerTypes.ToList();
            cboTenNCC.DisplayMember = "proProducerName";
            cboTenNCC.ValueMember = "proProducerName";
        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            load();
            label3.Text = DateTime.Now.ToString();
            label4.Text = DateTime.Now.ToString();
            dgvHoaDon.Columns[0].HeaderText = "Mã hóa đơn";
            dgvHoaDon.Columns[1].HeaderText = "Mã sản phẩm";
            dgvHoaDon.Columns[2].HeaderText = "Tên sản phẩm";
            dgvHoaDon.Columns[3].HeaderText = "Hãng sản xuất";
            dgvHoaDon.Columns[4].HeaderText = "Số lượng";
            dgvHoaDon.Columns[5].HeaderText = "Đơn giá";
            dgvHoaDon.Columns[6].HeaderText = "Tổng tiền";
            dgvHoaDon.Columns[7].HeaderText = "Ngày nhập";
            dgvHoaDon.Columns[8].HeaderText = "Ngày nhận";
        }

        private void dgvHoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        void load()
        {
            dgvHoaDon.DataSource = db.NhapHangs.ToList();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            int ma = int.Parse(comboBox1.SelectedValue.ToString());
            var pro = db.Products.FirstOrDefault(a=>a.proID==ma);
            NhapHang n = new NhapHang();
            n.proID = int.Parse(comboBox1.SelectedValue.ToString());
            n.ngaynhap = DateTime.Now;
            n.hangsanxuat= cboTenNCC.SelectedValue.ToString();
            n.orderQuantity = int.Parse(txtsl.Text);
            n.dongia = (int)pro.proPrice;
            n.proName = pro.proName;
            n.tongtien = (int)(pro.proPrice * int.Parse(txtsl.Text));
            db.NhapHangs.InsertOnSubmit(n);
            db.SubmitChanges();
            MessageBox.Show("Thành công");
            load();



        }

        

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
           
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void txtdongia_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtsl_TextChanged(object sender, EventArgs e)
        {
            int tong = int.Parse(txtdongia.Text) * int.Parse(txtsl.Text);
            txttongtien.Text = tong.ToString();
        }
       
        private void bntInHoaDon_Click(object sender, EventArgs e)
        {
            xuatdonnhap xh = new xuatdonnhap();
            var result = db.NhapHangs.ToList();
            xh.SetDataSource(result);
            frmReportHoaDonNhapHang f = new frmReportHoaDonNhapHang();
            f.crystalReportViewer1.ReportSource = xh;
            f.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //Buoc 1
            String mahd = dgvHoaDon.CurrentRow.Cells[0].Value.ToString();
            NhapHang hd = db.NhapHangs.Where(t => t.orderID == int.Parse(mahd)).FirstOrDefault();
            //Buoc 2
            hd.ngaynhan = DateTime.Now;
            //Buoc 3
            //Buoc 4
            db.SubmitChanges();
            //Buoc 5 Refresh data
            var hoadonnhs = from hd1 in db.NhapHangs select hd1;
            dgvHoaDon.DataSource = hoadonnhs;
            //show kết quả
            MessageBox.Show("Successful Update", "Thông báo");
        }

        private void dgvHoaDon_Click_1(object sender, EventArgs e)
        {
            
        }

        private void dgvHoaDon_SelectionChanged(object sender, EventArgs e)
        {
            //comboBox1.Text = dgvHoaDon.CurrentRow.Cells[2].Value.ToString();
            //cboTenNCC.Text = dgvHoaDon.CurrentRow.Cells[3].Value.ToString();
            //txtsl.Text = dgvHoaDon.CurrentRow.Cells[4].Value.ToString();
            //txtdongia.Text = dgvHoaDon.CurrentRow.Cells[5].Value.ToString();
            //txttongtien.Text = dgvHoaDon.CurrentRow.Cells[6].Value.ToString();
            //label3.Text = dgvHoaDon.CurrentRow.Cells[7].Value.ToString();
            //label4.Text = dgvHoaDon.CurrentRow.Cells[8].Value.ToString();
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex.ToString().Equals("0") == false)
            {
                int ma = int.Parse(comboBox1.SelectedValue.ToString());
                var pro = db.Products.FirstOrDefault(a => a.proID == ma);
                txtdongia.Text = pro.proPrice.ToString();

            }
        }
    }
}
