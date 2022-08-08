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
    public partial class frmNhaCungCap : Form
    {
        BLL_Producer nhacungcap = new BLL_Producer();
        databaseDataContext db = new databaseDataContext();
        public frmNhaCungCap()
        {
            InitializeComponent();
            cboTenNCC.DataSource = db.ProducerTypes.ToList();
            cboTenNCC.DisplayMember = "proProducerName";
            cboTenNCC.ValueMember = "proProducerName";
        }

        private void frmNhaCungCap_Load(object sender, EventArgs e)
        {
            dgvNhaCungCap.DataSource = nhacungcap.LoadProducer();
            dgvNhaCungCap.Columns[0].HeaderText = "Mã nhà cung cấp";
            dgvNhaCungCap.Columns[1].HeaderText = "Tên nhà cung cấp";
            dgvNhaCungCap.Columns[2].HeaderText = "Số điện thoại";
            dgvNhaCungCap.Columns[3].HeaderText = "Email";
            dgvNhaCungCap.Columns[4].HeaderText = "Địa chỉ";
           
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            //Buoc 1
            Producer ncc = new Producer();
            //Buoc 2
            ncc.proProducer = int.Parse(txtMaNCC.Text);
            ncc.proProducerName = cboTenNCC.SelectedValue.ToString();
            ncc.proPhone = txtSoDienThoai.Text;
            ncc.proEmail = txtEmail.Text;
            ncc.proAddress = txtDiaChi.Text;
           
            //Buoc 3
            db.Producers.InsertOnSubmit(ncc);
            //Buoc 4
            db.SubmitChanges();
            //Buoc 5 Refresh data
            var nhacungcaps = from ncc1 in db.Producers select ncc1;
            dgvNhaCungCap.DataSource = nhacungcaps;
            //show kết quả
            MessageBox.Show("Successful Add", "Thông báo");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            //Buoc 1
            String mancc = dgvNhaCungCap.CurrentRow.Cells[0].Value.ToString();
            Producer ncc = db.Producers.Where(t => t.proProducer == int.Parse(mancc)).FirstOrDefault();
            //Buoc 2
            //Buoc 3
            db.Producers.DeleteOnSubmit(ncc);
            //Buoc 4
            db.SubmitChanges();
            //Buoc 5 Refresh data
            var nhacungcaps = from ncc1 in db.Producers select ncc1;
            dgvNhaCungCap.DataSource = nhacungcaps;
            //show kết quả
            MessageBox.Show("Successful Delete", "Thông báo");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            //Buoc 1
            String mancc = dgvNhaCungCap.CurrentRow.Cells[0].Value.ToString();
            Producer ncc = db.Producers.Where(t => t.proProducer == int.Parse(mancc)).FirstOrDefault();
            //Buoc 2
            ncc.proProducerName = cboTenNCC.SelectedValue.ToString();
            ncc.proPhone = txtSoDienThoai.Text;
            ncc.proAddress = txtDiaChi.Text;
            ncc.proEmail = txtEmail.Text;
            //Buoc 3
            //Buoc 4
            db.SubmitChanges();
            //Buoc 5 Refresh data
            var nhacungcaps = from ncc1 in db.Producers select ncc1;
            dgvNhaCungCap.DataSource = nhacungcaps;
            //show kết quả
            MessageBox.Show("Successful Repair", "Thông báo");
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn có muốn đóng from Nhà cung cấp không?", "Thông báo",
              MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            this.Close();
        }

        private void dgvNhaCungCap_SelectionChanged(object sender, EventArgs e)
        {
            //txtMaNCC.Text = dgvNhaCungCap.CurrentRow.Cells[0].Value.ToString();
            //cboTenNCC.Text = dgvNhaCungCap.CurrentRow.Cells[1].Value.ToString();
            //txtSoDienThoai.Text = dgvNhaCungCap.CurrentRow.Cells[2].Value.ToString();
            //txtEmail.Text = dgvNhaCungCap.CurrentRow.Cells[3].Value.ToString();
            //txtDiaChi.Text = dgvNhaCungCap.CurrentRow.Cells[4].Value.ToString();
        }
    }
}
