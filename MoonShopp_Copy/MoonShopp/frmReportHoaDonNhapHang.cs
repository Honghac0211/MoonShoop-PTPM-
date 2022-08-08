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
    public partial class frmReportHoaDonNhapHang : Form
    {
        databaseDataContext db = new databaseDataContext();

       

        public frmReportHoaDonNhapHang()
        {
            InitializeComponent();
        }
       
            private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            
        }

        private void frmReportHoaDonNhapHang_Load(object sender, EventArgs e)
        {
            //frmReportHoaDonNhapHang rpt = new frmReportHoaDonNhapHang();
            //crystalReportViewer1.ReportSource = rpt;
            //rpt.SetDatabaseLogon("sa", "123", "DESKTOP-4CEB7H9", "SHOPMOON_NET");
            //crystalReportViewer1.DisplayStatusBar = false;
            //crystalReportViewer1.DisplayToolbar = true;
            //crystalReportViewer1.Refresh();
        }

        private void SetDatabaseLogon(string v1, string v2, string v3, string v4)
        {
            throw new NotImplementedException();
        }
    }
}
