
namespace MoonShoop
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.navMain = new DevExpress.XtraNavBar.NavBarControl();
            this.navDanhMuc = new DevExpress.XtraNavBar.NavBarGroup();
            this.navQLSanPham = new DevExpress.XtraNavBar.NavBarItem();
            this.navQLThietBi = new DevExpress.XtraNavBar.NavBarItem();
            this.navQLKhachHang = new DevExpress.XtraNavBar.NavBarItem();
            this.navQLNhanVien = new DevExpress.XtraNavBar.NavBarItem();
            this.navQLHoaDon = new DevExpress.XtraNavBar.NavBarItem();
            this.navDMSanPham = new DevExpress.XtraNavBar.NavBarItem();
            this.navHeThong = new DevExpress.XtraNavBar.NavBarGroup();
            this.navDoiMatKhau = new DevExpress.XtraNavBar.NavBarItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).BeginInit();
            this.splitContainerControl1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).BeginInit();
            this.splitContainerControl1.Panel2.SuspendLayout();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navMain)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripSeparator3,
            this.toolStripButton2,
            this.toolStripSeparator4,
            this.toolStripButton3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1353, 58);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(94, 53);
            this.toolStripButton1.Text = "Hệ Thống";
            this.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 58);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(103, 53);
            this.toolStripButton2.Text = "Doanh Thu";
            this.toolStripButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 58);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(61, 53);
            this.toolStripButton3.Text = "Thoát";
            this.toolStripButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 58);
            this.splitContainerControl1.Name = "splitContainerControl1";
            // 
            // splitContainerControl1.Panel1
            // 
            this.splitContainerControl1.Panel1.Controls.Add(this.navMain);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            // 
            // splitContainerControl1.Panel2
            // 
            this.splitContainerControl1.Panel2.Controls.Add(this.panel1);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1353, 557);
            this.splitContainerControl1.SplitterPosition = 481;
            this.splitContainerControl1.TabIndex = 1;
            // 
            // navMain
            // 
            this.navMain.ActiveGroup = this.navDanhMuc;
            this.navMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navMain.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navDanhMuc,
            this.navHeThong});
            this.navMain.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.navQLSanPham,
            this.navQLThietBi,
            this.navQLKhachHang,
            this.navDoiMatKhau,
            this.navQLNhanVien,
            this.navQLHoaDon,
            this.navDMSanPham});
            this.navMain.Location = new System.Drawing.Point(0, 0);
            this.navMain.Name = "navMain";
            this.navMain.OptionsNavPane.ExpandedWidth = 481;
            this.navMain.Size = new System.Drawing.Size(481, 557);
            this.navMain.TabIndex = 0;
            this.navMain.Text = "navBarControl1";
            // 
            // navDanhMuc
            // 
            this.navDanhMuc.Caption = "Danh Mục";
            this.navDanhMuc.Expanded = true;
            this.navDanhMuc.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("navDanhMuc.ImageOptions.LargeImage")));
            this.navDanhMuc.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("navDanhMuc.ImageOptions.SmallImage")));
            this.navDanhMuc.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navQLSanPham),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navQLThietBi),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navQLKhachHang),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navQLNhanVien),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navQLHoaDon),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navDMSanPham)});
            this.navDanhMuc.Name = "navDanhMuc";
            // 
            // navQLSanPham
            // 
            this.navQLSanPham.Caption = "Quản Lý Sản Phẩm";
            this.navQLSanPham.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("navQLSanPham.ImageOptions.LargeImage")));
            this.navQLSanPham.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("navQLSanPham.ImageOptions.SmallImage")));
            this.navQLSanPham.Name = "navQLSanPham";
            // 
            // navQLThietBi
            // 
            this.navQLThietBi.Caption = "Quản Lý Thiết Bị";
            this.navQLThietBi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("navQLThietBi.ImageOptions.LargeImage")));
            this.navQLThietBi.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("navQLThietBi.ImageOptions.SmallImage")));
            this.navQLThietBi.Name = "navQLThietBi";
            // 
            // navQLKhachHang
            // 
            this.navQLKhachHang.Caption = "Quản Lý Khách Hàng";
            this.navQLKhachHang.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("navQLKhachHang.ImageOptions.LargeImage")));
            this.navQLKhachHang.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("navQLKhachHang.ImageOptions.SmallImage")));
            this.navQLKhachHang.Name = "navQLKhachHang";
            // 
            // navQLNhanVien
            // 
            this.navQLNhanVien.Caption = "Quản Lý Nhân Viên";
            this.navQLNhanVien.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("navQLNhanVien.ImageOptions.LargeImage")));
            this.navQLNhanVien.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("navQLNhanVien.ImageOptions.SmallImage")));
            this.navQLNhanVien.Name = "navQLNhanVien";
            // 
            // navQLHoaDon
            // 
            this.navQLHoaDon.Caption = "Quản Lý Hóa Đơn";
            this.navQLHoaDon.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("navQLHoaDon.ImageOptions.LargeImage")));
            this.navQLHoaDon.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("navQLHoaDon.ImageOptions.SmallImage")));
            this.navQLHoaDon.Name = "navQLHoaDon";
            // 
            // navDMSanPham
            // 
            this.navDMSanPham.Caption = "Danh Mục Sản Phẩm";
            this.navDMSanPham.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("navDMSanPham.ImageOptions.LargeImage")));
            this.navDMSanPham.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("navDMSanPham.ImageOptions.SmallImage")));
            this.navDMSanPham.Name = "navDMSanPham";
            // 
            // navHeThong
            // 
            this.navHeThong.Caption = "Hệ Thống";
            this.navHeThong.Expanded = true;
            this.navHeThong.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("navHeThong.ImageOptions.LargeImage")));
            this.navHeThong.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("navHeThong.ImageOptions.SmallImage")));
            this.navHeThong.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navDoiMatKhau)});
            this.navHeThong.Name = "navHeThong";
            // 
            // navDoiMatKhau
            // 
            this.navDoiMatKhau.Caption = "Đổi Mật Khẩu";
            this.navDoiMatKhau.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("navDoiMatKhau.ImageOptions.LargeImage")));
            this.navDoiMatKhau.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("navDoiMatKhau.ImageOptions.SmallImage")));
            this.navDoiMatKhau.Name = "navDoiMatKhau";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LavenderBlush;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(857, 557);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(149, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "PHẦN MỀM QUẢN LÝ BÁN HÀNG";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1353, 615);
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).EndInit();
            this.splitContainerControl1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).EndInit();
            this.splitContainerControl1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.navMain)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraNavBar.NavBarControl navMain;
        private DevExpress.XtraNavBar.NavBarGroup navDanhMuc;
        private DevExpress.XtraNavBar.NavBarItem navQLSanPham;
        private DevExpress.XtraNavBar.NavBarItem navQLThietBi;
        private DevExpress.XtraNavBar.NavBarItem navQLKhachHang;
        private DevExpress.XtraNavBar.NavBarItem navQLNhanVien;
        private DevExpress.XtraNavBar.NavBarItem navQLHoaDon;
        private DevExpress.XtraNavBar.NavBarItem navDMSanPham;
        private DevExpress.XtraNavBar.NavBarGroup navHeThong;
        private DevExpress.XtraNavBar.NavBarItem navDoiMatKhau;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}