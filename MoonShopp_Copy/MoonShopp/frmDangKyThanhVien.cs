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
    public partial class frmDangKyThanhVien : Form
    {
        BLL_Customers kh = new BLL_Customers();
        databaseDataContext db = new databaseDataContext();
        public frmDangKyThanhVien()
        {
            InitializeComponent();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            Customer k = new Customer();
            k.cusName = txtHoTen.Text;
            k.cusEmail = "a";
            k.cusPhone= txtSoDienThoai.Text;
            k.cusType = 1;
            k.cusStatus = 1;
            db.Customers.InsertOnSubmit(k);
            db.SubmitChanges();
            MessageBox.Show("Đăng kí thành công");
            this.Close();
        }

        private void cboGioiTinh_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
