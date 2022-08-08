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
    public partial class frmSanPham : Form
    {
        databaseDataContext db = new databaseDataContext();
        BLL_Products sanpham = new BLL_Products();   
        public frmSanPham()
        {
            InitializeComponent();
            cboHangSanXuat.DataSource = db.ProducerTypes.ToList();
            cboHangSanXuat.DisplayMember = "proProducerName";
            cboHangSanXuat.ValueMember = "proProducer";
            cboLoaiSanPham.DataSource = db.ProductTypes.ToList();
            cboLoaiSanPham.DisplayMember = "proTypeName";
            cboLoaiSanPham.ValueMember = "proType";

        }

        private void frmSanPham_Load(object sender, EventArgs e)
        {
            dgvSanPham.DataSource = sanpham.LoadProducts();
            dgvSanPham.Columns[0].HeaderText = "Mã sản phẩm";
            dgvSanPham.Columns[1].HeaderText = "Tên sản phẩm";
            dgvSanPham.Columns[2].HeaderText = "Đơn giá";
            dgvSanPham.Columns[3].HeaderText = "Hình ảnh sản phẩm";
            dgvSanPham.Columns[4].HeaderText = "Loại sản phẩm";
            dgvSanPham.Columns[5].HeaderText = "Trang thái sản phẩm";
            dgvSanPham.Columns[6].HeaderText = "Hãng sản xuất";
            dgvSanPham.Columns[7].HeaderText = "Số lượng";
           
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            //Buoc 1
            Product sp = new Product();
            //Buoc 2
            sp.proID = int.Parse(txtMaSanPham.Text);
            sp.proName = txtTenSanPham.Text;
            sp.proPrice = int.Parse(txtGiaTien.Text);
            sp.proPhoto = txtHinhSanPham.Text;
            sp.proType = int.Parse(cboLoaiSanPham.SelectedValue.ToString());
            sp.proStatus = int.Parse(txtTinhTrang.Text);
            sp.proProducer = int.Parse(cboHangSanXuat.SelectedValue.ToString());
            sp.proQuantity = int.Parse(txtSoLuong.Text);
            //Buoc 3
            db.Products.InsertOnSubmit(sp);
            //Buoc 4
            db.SubmitChanges();
            //Buoc 5 Refresh data
            var sanphams = from sp1 in db.Products select sp1;
            dgvSanPham.DataSource = sanphams;
            //show kết quả
            MessageBox.Show("Successful Add", "Thông báo");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            //Buoc 1
            String masp = dgvSanPham.CurrentRow.Cells[0].Value.ToString();
            Product sp = db.Products.Where(t => t.proID == int.Parse(masp)).FirstOrDefault();
            //Buoc 2
            sp.proName = txtTenSanPham.Text;
            sp.proPrice = int.Parse(txtGiaTien.Text);
            sp.proPhoto = txtHinhSanPham.Text;
            sp.proType = int.Parse(cboLoaiSanPham.SelectedValue.ToString());
            sp.proStatus = int.Parse(txtTinhTrang.Text);
            sp.proProducer = int.Parse(cboHangSanXuat.SelectedValue.ToString());
            sp.proQuantity = int.Parse(txtSoLuong.Text);
            //Buoc 3
            //Buoc 4
            db.SubmitChanges();
            //Buoc 5 Refresh data
            var sanphams = from sp1 in db.Products select sp1;
            dgvSanPham.DataSource = sanphams;
            //show kết quả
            MessageBox.Show("Successful Repair", "Thông báo");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            //Buoc 1
            String masp = dgvSanPham.CurrentRow.Cells[0].Value.ToString();
            Product sp = db.Products.Where(t => t.proID == int.Parse(masp)).FirstOrDefault();
            //Buoc 2
            //Buoc 3
            db.Products.DeleteOnSubmit(sp);
            //Buoc 4
            db.SubmitChanges();
            //Buoc 5 Refresh data
            var sanphams = from sp1 in db.Products select sp1;
            dgvSanPham.DataSource = sanphams;
            //show kết quả
            MessageBox.Show("Successful Delete", "Thông báo");
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn có muốn đóng from Sản phẩm không?", "Thông báo",
              MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            this.Close();
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
            txtHinhSanPham.Text = filepath;
            //String mahsp = dgvSanPham.CurrentRow.Cells[0].Value.ToString();
            //Product sp = db.Products.Where(t => t.proPhoto == mahsp).FirstOrDefault();
        }

        private void dgvSanPham_SelectionChanged(object sender, EventArgs e)
        {
            txtMaSanPham.Text = dgvSanPham.CurrentRow.Cells[0].Value.ToString();
            txtTenSanPham.Text = dgvSanPham.CurrentRow.Cells[1].Value.ToString();
            txtGiaTien.Text = dgvSanPham.CurrentRow.Cells[2].Value.ToString();
            pictureBox1.Image = Image.FromFile(dgvSanPham.CurrentRow.Cells[3].Value.ToString());
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            txtHinhSanPham.Text = dgvSanPham.CurrentRow.Cells[3].Value.ToString();
            cboLoaiSanPham.Text = dgvSanPham.CurrentRow.Cells[6].Value.ToString();
            txtTinhTrang.Text = dgvSanPham.CurrentRow.Cells[5].Value.ToString();
            cboHangSanXuat.Text = dgvSanPham.CurrentRow.Cells[6].Value.ToString();
            txtSoLuong.Text = dgvSanPham.CurrentRow.Cells[7].Value.ToString();
        }

        private void dgvSanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            String mahsp = dgvSanPham.CurrentRow.Cells[3].Value.ToString();
            pictureBox1.Image = Image.FromFile(mahsp);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

        }
    }
}
