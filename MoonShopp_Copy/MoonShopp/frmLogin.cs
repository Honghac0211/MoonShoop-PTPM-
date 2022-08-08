using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
namespace MoonShopp
{
    public partial class frmLogin : Form
    {
        databaseDataContext db = new databaseDataContext();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            String tdn = txtTenDangNhap.Text;
            String mk = txtMatKhau.Text;
            Employee acc = db.Employees.Where(t => t.empPhone == tdn && t.empPassword == mk).FirstOrDefault();
            if (acc != null)
            {
                if (acc.empRole == 1)
                {

                    MessageBox.Show("Đăng nhập thành công", "Thông báo?");
                    frmTrangChu trangchinh = new frmTrangChu(acc);
                    trangchinh.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Đăng nhập thành công", "Thông báo?");
                    frmMain trangchinh = new frmMain(acc);
                    trangchinh.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không chính xác", "Thông báo?");
            }    

        }   
    }
}
