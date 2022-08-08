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
    public partial class frmDoanhThu : Form
    {
        databaseDataContext db = new databaseDataContext();
        public frmDoanhThu()
        {
            InitializeComponent();
        }
        BLL_Orders hd = new BLL_Orders();
        private void bntThongKe_Click(object sender, EventArgs e)
        {
            List<Order>lst = hd.LoadOrders();
            DateTime d = dateTimePicker1.Value;
            DateTime d2 = dateTimePicker2.Value;
            int sum = lst.Where(n => n.orderDate >= d && n.orderDate <= d2).Sum(n=>n.orderMoney);
            txtdoanhthu.Text = sum.ToString();
        }

        private void frmDoanhThu_Load(object sender, EventArgs e)
        {
            dgvDoanhThu.DataSource = hd.LoadOrders();
            dgvDoanhThu.Columns[0].HeaderText = "Mã hóa đơn";
            dgvDoanhThu.Columns[1].HeaderText = "Mã khách hàng";
            dgvDoanhThu.Columns[2].HeaderText = "Mã sản phẩm";
            dgvDoanhThu.Columns[3].HeaderText = "Ngày đặt";
            dgvDoanhThu.Columns[4].HeaderText = "Đơn giá";
            dgvDoanhThu.Columns[5].HeaderText = "Số lượng";
            dgvDoanhThu.Columns[6].HeaderText = "Tổng tiền";
            dgvDoanhThu.Columns[7].HeaderText = "Mã nhân viên";
           
        }

        private void bntXuatHoaDon_Click(object sender, EventArgs e)
        {
            var result = db.Orders.ToList();
            xuathoadon xh = new xuathoadon();
            var resut = db.Orders.Select(n => new {
                n.orderID,
                n.orderDate,
                n.proPrice,
                n.orderQuantity,
                n.orderMoney,
                n.proName
            }).ToList();
            xh.SetDataSource(result);
            frmReportHoaDonNhapHang f = new frmReportHoaDonNhapHang();
            f.crystalReportViewer1.ReportSource = xh;
            f.Show();
        }
    }
}
