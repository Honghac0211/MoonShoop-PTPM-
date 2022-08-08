
namespace MoonShopp
{
    partial class frmGioHang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGioHang));
            this.dgvGioHang = new System.Windows.Forms.DataGridView();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.txtTongTienHoaDon = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.btnDong = new DevComponents.DotNetBar.ButtonX();
            this.btnSua = new DevComponents.DotNetBar.ButtonX();
            this.btnXoa = new DevComponents.DotNetBar.ButtonX();
            this.btnThem = new DevComponents.DotNetBar.ButtonX();
            this.txtSoLuongGioHang = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtGiaTienSanPham = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtMaSanPham = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtMaGioHang = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnMuaHang = new DevComponents.DotNetBar.ButtonX();
            this.btnMuaTatCa = new DevComponents.DotNetBar.ButtonX();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGioHang)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvGioHang
            // 
            this.dgvGioHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGioHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGioHang.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvGioHang.Location = new System.Drawing.Point(0, 369);
            this.dgvGioHang.Name = "dgvGioHang";
            this.dgvGioHang.RowHeadersWidth = 62;
            this.dgvGioHang.RowTemplate.Height = 28;
            this.dgvGioHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGioHang.Size = new System.Drawing.Size(1145, 260);
            this.dgvGioHang.TabIndex = 41;
            this.dgvGioHang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGioHang_CellContentClick);
            this.dgvGioHang.SelectionChanged += new System.EventHandler(this.dgvGioHang_SelectionChanged);
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            this.labelX1.Location = new System.Drawing.Point(35, 25);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(139, 31);
            this.labelX1.TabIndex = 55;
            this.labelX1.Text = "Mã giỏ hàng :";
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            this.labelX2.Location = new System.Drawing.Point(35, 78);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(139, 31);
            this.labelX2.TabIndex = 56;
            this.labelX2.Text = "Mã sản phẩm :";
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            this.labelX3.Location = new System.Drawing.Point(35, 126);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(139, 34);
            this.labelX3.TabIndex = 57;
            this.labelX3.Text = "Giá tiền sản phẩm:";
            // 
            // labelX4
            // 
            this.labelX4.BackColor = System.Drawing.Color.Transparent;
            this.labelX4.Location = new System.Drawing.Point(35, 180);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(159, 31);
            this.labelX4.TabIndex = 58;
            this.labelX4.Text = "Số lượng :";
            // 
            // labelX5
            // 
            this.labelX5.BackColor = System.Drawing.Color.Transparent;
            this.labelX5.Location = new System.Drawing.Point(35, 233);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(164, 31);
            this.labelX5.TabIndex = 59;
            this.labelX5.Text = "Tổng tiền hóa đơn :";
            // 
            // txtTongTienHoaDon
            // 
            // 
            // 
            // 
            this.txtTongTienHoaDon.Border.Class = "TextBoxBorder";
            this.txtTongTienHoaDon.Location = new System.Drawing.Point(199, 233);
            this.txtTongTienHoaDon.Name = "txtTongTienHoaDon";
            this.txtTongTienHoaDon.Size = new System.Drawing.Size(224, 31);
            this.txtTongTienHoaDon.TabIndex = 64;
            // 
            // labelX6
            // 
            this.labelX6.BackColor = System.Drawing.Color.Transparent;
            this.labelX6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX6.Location = new System.Drawing.Point(462, 6);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(309, 45);
            this.labelX6.TabIndex = 65;
            this.labelX6.Text = "DANH SÁCH GIỎ HÀNG";
            this.labelX6.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // btnDong
            // 
            this.btnDong.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDong.ColorTable = DevComponents.DotNetBar.eButtonColor.MagentaWithBackground;
            this.btnDong.Image = ((System.Drawing.Image)(resources.GetObject("btnDong.Image")));
            this.btnDong.ImageFixedSize = new System.Drawing.Size(45, 45);
            this.btnDong.Location = new System.Drawing.Point(239, 119);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(147, 56);
            this.btnDong.TabIndex = 100;
            this.btnDong.Text = "Đóng";
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnSua
            // 
            this.btnSua.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSua.ColorTable = DevComponents.DotNetBar.eButtonColor.MagentaWithBackground;
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageFixedSize = new System.Drawing.Size(45, 45);
            this.btnSua.Location = new System.Drawing.Point(52, 119);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(140, 56);
            this.btnSua.TabIndex = 99;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnXoa.ColorTable = DevComponents.DotNetBar.eButtonColor.MagentaWithBackground;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageFixedSize = new System.Drawing.Size(45, 45);
            this.btnXoa.Location = new System.Drawing.Point(239, 42);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(147, 56);
            this.btnXoa.TabIndex = 98;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThem.ColorTable = DevComponents.DotNetBar.eButtonColor.MagentaWithBackground;
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageFixedSize = new System.Drawing.Size(45, 45);
            this.btnThem.Location = new System.Drawing.Point(52, 42);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(140, 56);
            this.btnThem.TabIndex = 97;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtSoLuongGioHang
            // 
            // 
            // 
            // 
            this.txtSoLuongGioHang.Border.Class = "TextBoxBorder";
            this.txtSoLuongGioHang.Location = new System.Drawing.Point(199, 180);
            this.txtSoLuongGioHang.Name = "txtSoLuongGioHang";
            this.txtSoLuongGioHang.Size = new System.Drawing.Size(224, 31);
            this.txtSoLuongGioHang.TabIndex = 101;
            // 
            // txtGiaTienSanPham
            // 
            // 
            // 
            // 
            this.txtGiaTienSanPham.Border.Class = "TextBoxBorder";
            this.txtGiaTienSanPham.Location = new System.Drawing.Point(199, 126);
            this.txtGiaTienSanPham.Name = "txtGiaTienSanPham";
            this.txtGiaTienSanPham.Size = new System.Drawing.Size(224, 34);
            this.txtGiaTienSanPham.TabIndex = 102;
            // 
            // txtMaSanPham
            // 
            // 
            // 
            // 
            this.txtMaSanPham.Border.Class = "TextBoxBorder";
            this.txtMaSanPham.Location = new System.Drawing.Point(199, 78);
            this.txtMaSanPham.Name = "txtMaSanPham";
            this.txtMaSanPham.Size = new System.Drawing.Size(224, 31);
            this.txtMaSanPham.TabIndex = 103;
            // 
            // txtMaGioHang
            // 
            // 
            // 
            // 
            this.txtMaGioHang.Border.Class = "TextBoxBorder";
            this.txtMaGioHang.Location = new System.Drawing.Point(199, 25);
            this.txtMaGioHang.Name = "txtMaGioHang";
            this.txtMaGioHang.Size = new System.Drawing.Size(224, 31);
            this.txtMaGioHang.TabIndex = 104;
            // 
            // btnMuaHang
            // 
            this.btnMuaHang.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnMuaHang.ColorTable = DevComponents.DotNetBar.eButtonColor.MagentaWithBackground;
            this.btnMuaHang.Image = ((System.Drawing.Image)(resources.GetObject("btnMuaHang.Image")));
            this.btnMuaHang.ImageFixedSize = new System.Drawing.Size(45, 45);
            this.btnMuaHang.Location = new System.Drawing.Point(865, 290);
            this.btnMuaHang.Name = "btnMuaHang";
            this.btnMuaHang.Size = new System.Drawing.Size(192, 56);
            this.btnMuaHang.TabIndex = 107;
            this.btnMuaHang.Text = "Mua hàng";
            // 
            // btnMuaTatCa
            // 
            this.btnMuaTatCa.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnMuaTatCa.ColorTable = DevComponents.DotNetBar.eButtonColor.MagentaWithBackground;
            this.btnMuaTatCa.Image = ((System.Drawing.Image)(resources.GetObject("btnMuaTatCa.Image")));
            this.btnMuaTatCa.ImageFixedSize = new System.Drawing.Size(45, 45);
            this.btnMuaTatCa.Location = new System.Drawing.Point(636, 290);
            this.btnMuaTatCa.Name = "btnMuaTatCa";
            this.btnMuaTatCa.Size = new System.Drawing.Size(196, 56);
            this.btnMuaTatCa.TabIndex = 106;
            this.btnMuaTatCa.Text = "Mua tất cả";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.labelX1);
            this.groupBox2.Controls.Add(this.labelX2);
            this.groupBox2.Controls.Add(this.labelX3);
            this.groupBox2.Controls.Add(this.labelX4);
            this.groupBox2.Controls.Add(this.txtMaGioHang);
            this.groupBox2.Controls.Add(this.labelX5);
            this.groupBox2.Controls.Add(this.txtMaSanPham);
            this.groupBox2.Controls.Add(this.txtTongTienHoaDon);
            this.groupBox2.Controls.Add(this.txtGiaTienSanPham);
            this.groupBox2.Controls.Add(this.txtSoLuongGioHang);
            this.groupBox2.Location = new System.Drawing.Point(99, 57);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(456, 293);
            this.groupBox2.TabIndex = 108;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin giỏ hàng:";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.btnThem);
            this.groupBox3.Controls.Add(this.btnXoa);
            this.groupBox3.Controls.Add(this.btnSua);
            this.groupBox3.Controls.Add(this.btnDong);
            this.groupBox3.Location = new System.Drawing.Point(625, 57);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(432, 200);
            this.groupBox3.TabIndex = 109;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Các nút chức năng";
            // 
            // frmGioHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1145, 629);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnMuaHang);
            this.Controls.Add(this.btnMuaTatCa);
            this.Controls.Add(this.dgvGioHang);
            this.Controls.Add(this.labelX6);
            this.Name = "frmGioHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giỏ Hàng";
            this.Load += new System.EventHandler(this.frmGioHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGioHang)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvGioHang;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTongTienHoaDon;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.ButtonX btnDong;
        private DevComponents.DotNetBar.ButtonX btnSua;
        private DevComponents.DotNetBar.ButtonX btnXoa;
        private DevComponents.DotNetBar.ButtonX btnThem;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSoLuongGioHang;
        private DevComponents.DotNetBar.Controls.TextBoxX txtGiaTienSanPham;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMaSanPham;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMaGioHang;
        private DevComponents.DotNetBar.ButtonX btnMuaHang;
        private DevComponents.DotNetBar.ButtonX btnMuaTatCa;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}