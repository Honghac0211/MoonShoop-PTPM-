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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
         
        }
        private Employee acc;
        public frmMain(Employee acc):this()
        {
            this.acc = acc;
            //MessageBox.Show(acc.accUserName);
            if(acc.empRole==2)
            {
                btnHoaDon.Enabled =btnnhanvien.Enabled=bntDoanhThu.Enabled= false;
            }    
        }
        private void tabControl1_Click(object sender, EventArgs e)
        {

        }

        private void btnnhanvien_Click(object sender, EventArgs e)
        {
            frmNhanVien fm = new frmNhanVien();
            fm.TopLevel = false;
            panel1.Controls.Add(fm);
            fm.Dock = DockStyle.Fill;
            fm.Show();


        }

        private void btnkhachhang_Click(object sender, EventArgs e)
        {
            frmKhachHang fm = new frmKhachHang();
            fm.TopLevel = false;

            panel1.Controls.Add(fm);
            fm.Dock = DockStyle.Fill;
            fm.Show();
        }

        private void btnsanpham_Click(object sender, EventArgs e)
        {
            frmSanPham fm = new frmSanPham();
            fm.TopLevel = false;

            panel1.Controls.Add(fm);
            fm.Dock = DockStyle.Fill;
            fm.Show();
        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
        //    fr fm = new frmNhanVien();
        //    fm.TopLevel = false;

        //    panel1.Controls.Add(fm);
        //    fm.Dock = DockStyle.Fill;
        //    fm.Show();
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            frmHoaDon fm = new frmHoaDon();
            fm.TopLevel = false;

            panel1.Controls.Add(fm);
            fm.Dock = DockStyle.Fill;
            fm.Show();
        }

        private void bntDoanhThu_Click(object sender, EventArgs e)
        {
            frmDoanhThu fm = new frmDoanhThu();
            fm.TopLevel = false;

            panel1.Controls.Add(fm);
            fm.Dock = DockStyle.Fill;
            fm.Show();
            
        }

        private void bntDoiMatKhau_Click(object sender, EventArgs e)
        {
           
            frmDoiMatKhau fm = new frmDoiMatKhau();
            fm.TopLevel = false;
           
            panel1.Controls.Add(fm);
            fm.Dock = DockStyle.Fill;
            fm.Show();
        }

        private void bntNhaCungCap_Click(object sender, EventArgs e)
        {
            frmNhaCungCap fm = new frmNhaCungCap();
            fm.TopLevel = false;

            panel1.Controls.Add(fm);
            fm.Dock = DockStyle.Fill;
            fm.Show();
        }

        private void buttonX4_Click(object sender, EventArgs e)
        {
            frmLogin dangnhap = new frmLogin();
            dangnhap.Show();
            this.Hide();
        }

        private void bntReport_Click(object sender, EventArgs e)
        {
            frmReportHoaDonNhapHang fm = new frmReportHoaDonNhapHang();
            fm.TopLevel = false;

            panel1.Controls.Add(fm);
            fm.Dock = DockStyle.Fill;
            fm.Show();
        }
    }
}
