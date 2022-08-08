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
    public partial class frmHangSanXuat : Form
    {
        databaseDataContext db = new databaseDataContext();
        BLL_ProducerTypes hangsanxuat = new BLL_ProducerTypes();
        public frmHangSanXuat()
        {
            InitializeComponent();
        }

        private void frmHangSanXuat_Load(object sender, EventArgs e)
        {
            dgvHangSanXuat.DataSource = hangsanxuat.LoadOProducerType();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            //Buoc 1
            ProducerType hsx = new ProducerType();
            //Buoc 2
            hsx.proProducer = int.Parse(txtMaHangSanXuat.Text);
            hsx.proProducerName = txtTenHangSanXuat.Text;
            //Buoc 3
            db.ProducerTypes.InsertOnSubmit(hsx);
            //Buoc 4
            db.SubmitChanges();
            //Buoc 5 Refresh data
            var producers = from hsx1 in db.ProducerTypes select hsx1;
            dgvHangSanXuat.DataSource = producers;
            //show kết quả
            MessageBox.Show("Successful Add", "Thông báo");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            //Buoc 1
            String mahsx = dgvHangSanXuat.CurrentRow.Cells[0].Value.ToString();
            ProducerType hsx = db.ProducerTypes.Where(t =>t.proProducer == int.Parse(mahsx)).FirstOrDefault();
            //Buoc 2

            //Buoc 3
            db.ProducerTypes.DeleteOnSubmit(hsx);
            //Buoc 4
            db.SubmitChanges();
            //Buoc 5 Refresh data
            var monhocs = from hsx1 in db.ProducerTypes select hsx1;
            dgvHangSanXuat.DataSource = monhocs;
            //show kết quả
            MessageBox.Show("Successful Delete", "Thông báo");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            //Buoc 1
            String mahsx = dgvHangSanXuat.CurrentRow.Cells[0].Value.ToString();
            ProducerType hsx = db.ProducerTypes.Where(t => t.proProducer == int.Parse(mahsx)).FirstOrDefault();
            //Buoc 2
            hsx.proProducerName = txtTenHangSanXuat.Text;
            //Buoc 3
            //Buoc 4
            db.SubmitChanges();
            //Buoc 5 Refresh data
            var monhocs = from hsx1 in db.ProducerTypes select hsx1;
            dgvHangSanXuat.DataSource = monhocs;
            //show kết quả
            MessageBox.Show("Successful Repair", "Thông báo");
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
             MessageBox.Show("Bạn có muốn đóng from Hãng Sản Xuất không?", "Thông báo",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);   
            this.Close();
        }

        private void dgvHangSanXuat_SelectionChanged(object sender, EventArgs e)
        {
            txtMaHangSanXuat.Text = dgvHangSanXuat.CurrentRow.Cells[0].Value.ToString();
            txtTenHangSanXuat.Text = dgvHangSanXuat.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
