using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoonShopp
{
    public partial class frmTrangChu : Form
    {
        databaseDataContext db = new databaseDataContext();
        public frmTrangChu()
        {
            InitializeComponent();
            LoadDienThoai();
        }
        private Employee acc;
        public frmTrangChu(Employee acc) : this()
        {
            this.acc = acc;
            btnnhanvien.Text = acc.empName;

            //MessageBox.Show(acc.accUserName);
        }
        private void LoadDienThoai()
        {

            IList<Product> listItems = db.Products.ToList();
            pnDienThoai.Controls.Clear();
            int i = 0;
            foreach (var item in listItems)
            {
                TaoKhungTrangChu(20 + 280 * (i / 3), 50 + 250 * (i % 3), item);
                i++;
            }
        }
        private void TaoKhungTrangChu(int topPN, int leftPN, Product dienThoai)
        {
            Panel pn = new Panel();
            pn.Parent = pnDienThoai;
            pn.Top = topPN;
            pn.Left = leftPN;
            pn.Width = 170;
            pn.Height = 260;
            pn.BackColor = Color.LightPink;
            pn.Anchor = AnchorStyles.Top;

            PictureBox ptb = new PictureBox();
            ptb.Parent = pn;
            ptb.Top = 10;
            ptb.Left = 15;
            ptb.Width = 140;
            ptb.Height = 150;
            ptb.BackColor = Color.Red;
            ptb.SizeMode = PictureBoxSizeMode.StretchImage; 
            ptb.ImageLocation=(dienThoai.proPhoto);
            //ptb.ImageLocation=(@"C:\Users\HONG HAC\Desktop\DoAnWinForm\MoonShopp_Copy\MoonShopp\bin\Debug\Images\Phone\" + dienThoai.proPhoto);

                

            int topLBTen = 170;
            Label lbTenDienThoai = new Label();
            lbTenDienThoai.Parent = pn;
            lbTenDienThoai.Top = topLBTen;
            lbTenDienThoai.Left = 15;
            lbTenDienThoai.Width = 140;
            lbTenDienThoai.Height = 14;
            lbTenDienThoai.Text = dienThoai.proName;
            lbTenDienThoai.TextAlign = ContentAlignment.MiddleCenter;
            lbTenDienThoai.Font = new Font(Label.DefaultFont, FontStyle.Bold);

            Label lbGiaDienThoai = new Label();
            lbGiaDienThoai.Parent = pn;
            lbGiaDienThoai.Top = topLBTen + 20;
            lbGiaDienThoai.Left = 15;
            lbGiaDienThoai.Width = 140;
            lbGiaDienThoai.Height = 14;
            lbGiaDienThoai.ForeColor = Color.Red;
            lbGiaDienThoai.Text = "Giá: " + dienThoai.proPrice.ToString() + " vnđ";
            lbGiaDienThoai.TextAlign = ContentAlignment.MiddleCenter;

            Label lbSLDienThoai = new Label();
            lbSLDienThoai.Parent = pn;
            lbSLDienThoai.Top = topLBTen + 40;
            lbSLDienThoai.Left = 15;
            lbSLDienThoai.Width = 140;
            lbSLDienThoai.Height = 14;
            lbSLDienThoai.Text = "Số Lượng: " + dienThoai.proQuantity;
            lbSLDienThoai.TextAlign = ContentAlignment.MiddleCenter;

            Button btnThemVaoGio = new Button();
            btnThemVaoGio.Parent = pn;
            btnThemVaoGio.Top = topLBTen + 60;
            btnThemVaoGio.Left = 43;
            btnThemVaoGio.AutoSize = true;
            btnThemVaoGio.Text = "Mua Ngay";
            btnThemVaoGio.Tag = dienThoai;
            btnThemVaoGio.Click += BtnThemVaoGio_Click;

        }
        private void BtnThemVaoGio_Click(object sender, System.EventArgs e)
        {
            Button btn = (Button)sender;
            Product dienThoai = (Product)btn.Tag;
         
           Cart z = db.Carts.FirstOrDefault(n => n.proID == dienThoai.proID);
           if(z!=null)
            {
                z.cartQuantity = z.cartQuantity + 1;
                z.cartMoney = z.cartQuantity * z.proPrice;
                db.SubmitChanges();
                MessageBox.Show("Cập nhật thành công sản phẩm " + dienThoai.proName);
                int tong1 = int.Parse(db.Carts.Sum(n => n.cartMoney).ToString());
                txttongtien.Text = tong1 + "";
                loadcart();
                return;
              
            }
           else
            {
                Cart c = new Cart();
                c.proID = dienThoai.proID;
                c.proPrice = (int)dienThoai.proPrice;
                c.cartQuantity = 1;
                c.cartMoney = dienThoai.proPrice;
                db.Carts.InsertOnSubmit(c);
                db.SubmitChanges();
                MessageBox.Show("Chọn thành công sản phẩm " + dienThoai.proName);
                int tong = int.Parse(db.Carts.Sum(n => n.cartMoney).ToString());
                txttongtien.Text = tong + "";
                loadcart();
            }
         

        }
        DAL_Carts dc = new DAL_Carts();
        public void loadcart()
        {
           dgvGioHang.DataSource= dc.LoadCarts();
        }

        private void frmTrangChu_Load(object sender, EventArgs e)
        {
            TaoCBBLoaiDienThoai();
            loadcart();
            //tong tien
            var item = db.Carts.ToList();
            if(item!=null)
            {
                int tong = int.Parse(db.Carts.ToList().Sum(n => n.cartMoney).Value.ToString());
                txttongtien.Text = tong + "";
                dgvGioHang.Columns[0].HeaderText = "ID";
                dgvGioHang.Columns[1].HeaderText = "Mã sản phẩm";
                dgvGioHang.Columns[2].HeaderText = "Giá sản phẩm";
                dgvGioHang.Columns[3].HeaderText = "Số lượng";
                dgvGioHang.Columns[4].HeaderText = "Tổng tiền";
            }    
         





        }
        //--------------------------------------------------------------
        private void TaoCBBLoaiDienThoai()
        {

            var listLoaiDienThoai = db.ProducerTypes.ToList();
            //cbbproductstype.DataSource = listLoaiDienThoai;
            //cbbproductstype.DisplayMember = "proProducerName";

            //cbbproductstype.ValueMember = "proProducer";
            ProducerType tmpAll = new ProducerType
            {
                proProducer = 00,
                proProducerName = "Tất Cả"
            };
            cboLoadSP.Items.Add(tmpAll);

            foreach (var item in listLoaiDienThoai)
            {
                cboLoadSP.DataSource = listLoaiDienThoai;
                cboLoadSP.DisplayMember = "proProducerName";
            }
            cboLoadSP.Text = "Tất Cả";
        }

        private void cboLoadSP_SelectedValueChanged(object sender, EventArgs e)
        {
           
        }

        private void bntTim_Click(object sender, EventArgs e)
        {
            IList<Product> listItems = db.Products.Where(n => n.proName.Contains(txtsearch.Text)).ToList();
            pnDienThoai.Controls.Clear();
            int i = 0;
            foreach (var item in listItems)
            {
                TaoKhungTrangChu(20 + 280 * (i / 3), 50 + 250 * (i % 3), item);
                i++;
            }
        }


        private void txttienkhachdua_TextChanged(object sender, EventArgs e)
        {
            if (txttienkhachdua.TextLength != 0)
            {
                double tong = float.Parse(txttongtien.Text);
                double tien = float.Parse(txttienkhachdua.Text);
                double thua = tien - tong;
                txttienthua.Text = thua + "";
            }
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
            int tong = int.Parse(db.Carts.ToList().Sum(n => n.cartMoney).ToString());
            txttongtien.Text = tong + "";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            ////Buoc 1
            //String magh = dgvGioHang.CurrentRow.Cells[0].Value.ToString();
            //Cart gh = db.Carts.Where(t => t.cartID == int.Parse(magh)).FirstOrDefault();
            ////Buoc 2
            //gh.proID = int.Parse(txtMaSanPham.Text);
            //gh.proPrice = int.Parse(txtGiaTienSanPham.Text);
            //gh.CartQuantity = int.Parse(txtSoLuongGioHang.Text);
            //gh.CartMoney = int.Parse(txtTongTienHoaDon.Text);
            ////buoc 3
            ////Buoc 4
            //db.SubmitChanges();
            ////Buoc 5 Refresh data
            //var carts = from gh1 in db.Carts select gh1;
            //dgvGioHang.DataSource = carts;
            ////show kết quả
            //MessageBox.Show("Successful Add", "Thông báo");

        }

        private void bntDangXuat_Click(object sender, EventArgs e)
        {
            frmLogin dangnhap = new frmLogin();
            dangnhap.Show();
            this.Hide();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            var cart = db.Carts.ToList();
          
            foreach(var item in cart)
            {
                var pro = db.Products.FirstOrDefault(n => n.proID == item.proID);
                Order d = new Order();
                d.empID = acc.empID;
                d.cusID = idkh;
                d.proName = pro.proName;
                d.proPrice = (int)pro.proPrice;
                d.proID = item.proID;
                d.orderDate = DateTime.Now;
                d.orderQuantity = (int)item.cartQuantity;
                d.orderMoney = (int)((int) item.cartQuantity *item.proPrice);
                db.Orders.InsertOnSubmit(d);
                db.SubmitChanges();
               
            }
            db.Carts.DeleteAllOnSubmit(cart);
            db.SubmitChanges();
            MessageBox.Show("Thành công");
            loadcart();
            xuathoadon xh = new xuathoadon();
            var resut = db.Orders.Where(n => n.cusID == idkh).Select(n => new {
                n.orderID,
                n.orderDate,
                n.proPrice,         
                n.orderQuantity,
                n.orderMoney,
                n.proName


            }).ToList();
            xh.SetDataSource(resut);
            frmReportHoaDonNhapHang f = new frmReportHoaDonNhapHang();
            f.crystalReportViewer1.ReportSource = xh;
            f.Show();
        }
     

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            if(txtsearch.Text.Equals(""))
            {
                IList<Product> listItem = db.Products.ToList();
                pnDienThoai.Controls.Clear();
                int ii = 0;
                foreach (var item in listItem)
                {
                    TaoKhungTrangChu(20 + 280 * (ii / 3), 50 + 250 * (ii % 3), item);
                    ii++;
                }
            }    
            IList<Product> listItems = db.Products.Where(n => n.proName.Contains(txtsearch.Text)).ToList();
            pnDienThoai.Controls.Clear();
            int i = 0;
            foreach (var item in listItems)
            {
                TaoKhungTrangChu(20 + 280 * (i / 3), 50 + 250 * (i % 3), item);
                i++;
            }
        }
        private int idkh;
        private void btnTimTV_Click(object sender, EventArgs e)
        {
            var tv = db.Customers.FirstOrDefault(n => n.cusPhone == txtTimTV.Text);
            if (tv == null)
            {
                MessageBox.Show("Bạn chưa đăng kí thành viên");
                frmDangKyThanhVien fm = new frmDangKyThanhVien();
                fm.Show();
                return;
            }
            else
            {
                txtMaKhachHang.Text = tv.cusName;
                idkh = tv.cusID;
                MessageBox.Show("Bạn được giảm 15000đ");
                txtGiamGia.Text = 15000 + "";
                if (txtGiamGia.Text != null && txttongtien.Text != null)
                {
                    int tien = int.Parse(txttongtien.Text) - int.Parse(txtGiamGia.Text);
                    txttienkhachdua.Text = tien + "";
                }
            }
        }

        private void cboLoadSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboLoadSP.SelectedIndex.ToString().Equals("0")==false)
            {
                int idLoaiDienThoai = ((ProducerType)cboLoadSP.SelectedItem).proProducer;
                if (cboLoadSP.SelectedValue.Equals("Tất Cả"))
                {
                    LoadDienThoai();
                }
                else
                {
                    var loaidt = db.Products.Where(n => n.proProducer == idLoaiDienThoai).ToList();
                    pnDienThoai.Controls.Clear();
                    int i = 0;
                    foreach (var item in loaidt)
                    {
                        TaoKhungTrangChu(20 + 280 * (i / 3), 50 + 250 * (i % 3), item);
                        i++;
                    }
                }
            }
           
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn có thực sự muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
