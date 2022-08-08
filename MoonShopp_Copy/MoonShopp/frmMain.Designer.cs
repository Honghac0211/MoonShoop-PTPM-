
namespace MoonShopp
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
            this.ribbonControl1 = new DevComponents.DotNetBar.RibbonControl();
            this.ribbonPanel1 = new DevComponents.DotNetBar.RibbonPanel();
            this.buttonX4 = new DevComponents.DotNetBar.ButtonX();
            this.bntDoiMatKhau = new DevComponents.DotNetBar.ButtonX();
            this.ribbonPanel2 = new DevComponents.DotNetBar.RibbonPanel();
            this.bntNhaCungCap = new DevComponents.DotNetBar.ButtonX();
            this.bntDoanhThu = new DevComponents.DotNetBar.ButtonX();
            this.btnHoaDon = new DevComponents.DotNetBar.ButtonX();
            this.btnsanpham = new DevComponents.DotNetBar.ButtonX();
            this.btnkhachhang = new DevComponents.DotNetBar.ButtonX();
            this.btnnhanvien = new DevComponents.DotNetBar.ButtonX();
            this.ribbonTabItem1 = new DevComponents.DotNetBar.RibbonTabItem();
            this.ribbonTabItem2 = new DevComponents.DotNetBar.RibbonTabItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ribbonControl1.SuspendLayout();
            this.ribbonPanel1.SuspendLayout();
            this.ribbonPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.BackColor = System.Drawing.SystemColors.Control;
            // 
            // 
            // 
            this.ribbonControl1.BackgroundStyle.BackColor = System.Drawing.Color.LightPink;
            this.ribbonControl1.BackgroundStyle.BackColor2 = System.Drawing.Color.HotPink;
            this.ribbonControl1.CaptionVisible = true;
            this.ribbonControl1.Controls.Add(this.ribbonPanel2);
            this.ribbonControl1.Controls.Add(this.ribbonPanel1);
            this.ribbonControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ribbonControl1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.ribbonTabItem1,
            this.ribbonTabItem2});
            this.ribbonControl1.KeyTipsFont = new System.Drawing.Font("Tahoma", 7F);
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.ribbonControl1.Size = new System.Drawing.Size(1527, 240);
            this.ribbonControl1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonControl1.TabGroupHeight = 14;
            this.ribbonControl1.TabIndex = 0;
            this.ribbonControl1.Text = "ribbonControl1";
            // 
            // ribbonPanel1
            // 
            this.ribbonPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonPanel1.Controls.Add(this.buttonX4);
            this.ribbonPanel1.Controls.Add(this.bntDoiMatKhau);
            this.ribbonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonPanel1.Location = new System.Drawing.Point(0, 58);
            this.ribbonPanel1.Name = "ribbonPanel1";
            this.ribbonPanel1.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ribbonPanel1.Size = new System.Drawing.Size(1527, 180);
            this.ribbonPanel1.TabIndex = 1;
            this.ribbonPanel1.Visible = false;
            // 
            // buttonX4
            // 
            this.buttonX4.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX4.ColorTable = DevComponents.DotNetBar.eButtonColor.MagentaWithBackground;
            this.buttonX4.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonX4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonX4.Image = ((System.Drawing.Image)(resources.GetObject("buttonX4.Image")));
            this.buttonX4.ImageFixedSize = new System.Drawing.Size(45, 45);
            this.buttonX4.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonX4.Location = new System.Drawing.Point(230, 0);
            this.buttonX4.Name = "buttonX4";
            this.buttonX4.Size = new System.Drawing.Size(226, 177);
            this.buttonX4.TabIndex = 3;
            this.buttonX4.Text = "Đăng Xuất";
            this.buttonX4.Click += new System.EventHandler(this.buttonX4_Click);
            // 
            // bntDoiMatKhau
            // 
            this.bntDoiMatKhau.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.bntDoiMatKhau.ColorTable = DevComponents.DotNetBar.eButtonColor.MagentaWithBackground;
            this.bntDoiMatKhau.Dock = System.Windows.Forms.DockStyle.Left;
            this.bntDoiMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntDoiMatKhau.Image = ((System.Drawing.Image)(resources.GetObject("bntDoiMatKhau.Image")));
            this.bntDoiMatKhau.ImageFixedSize = new System.Drawing.Size(45, 45);
            this.bntDoiMatKhau.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.bntDoiMatKhau.Location = new System.Drawing.Point(3, 0);
            this.bntDoiMatKhau.Name = "bntDoiMatKhau";
            this.bntDoiMatKhau.Size = new System.Drawing.Size(227, 177);
            this.bntDoiMatKhau.TabIndex = 1;
            this.bntDoiMatKhau.Text = "Đổi Mật Khẩu";
            this.bntDoiMatKhau.Click += new System.EventHandler(this.bntDoiMatKhau_Click);
            // 
            // ribbonPanel2
            // 
            this.ribbonPanel2.CanvasColor = System.Drawing.Color.Orange;
            this.ribbonPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonPanel2.Controls.Add(this.bntNhaCungCap);
            this.ribbonPanel2.Controls.Add(this.bntDoanhThu);
            this.ribbonPanel2.Controls.Add(this.btnHoaDon);
            this.ribbonPanel2.Controls.Add(this.btnsanpham);
            this.ribbonPanel2.Controls.Add(this.btnkhachhang);
            this.ribbonPanel2.Controls.Add(this.btnnhanvien);
            this.ribbonPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonPanel2.Location = new System.Drawing.Point(0, 58);
            this.ribbonPanel2.Name = "ribbonPanel2";
            this.ribbonPanel2.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ribbonPanel2.Size = new System.Drawing.Size(1527, 180);
            this.ribbonPanel2.TabIndex = 2;
            // 
            // bntNhaCungCap
            // 
            this.bntNhaCungCap.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.bntNhaCungCap.ColorTable = DevComponents.DotNetBar.eButtonColor.MagentaWithBackground;
            this.bntNhaCungCap.Dock = System.Windows.Forms.DockStyle.Left;
            this.bntNhaCungCap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntNhaCungCap.Image = ((System.Drawing.Image)(resources.GetObject("bntNhaCungCap.Image")));
            this.bntNhaCungCap.ImageFixedSize = new System.Drawing.Size(45, 45);
            this.bntNhaCungCap.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.bntNhaCungCap.Location = new System.Drawing.Point(1138, 0);
            this.bntNhaCungCap.Name = "bntNhaCungCap";
            this.bntNhaCungCap.Size = new System.Drawing.Size(227, 177);
            this.bntNhaCungCap.TabIndex = 9;
            this.bntNhaCungCap.Text = "Nhà Cung Cấp";
            this.bntNhaCungCap.Click += new System.EventHandler(this.bntNhaCungCap_Click);
            // 
            // bntDoanhThu
            // 
            this.bntDoanhThu.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.bntDoanhThu.ColorTable = DevComponents.DotNetBar.eButtonColor.MagentaWithBackground;
            this.bntDoanhThu.Dock = System.Windows.Forms.DockStyle.Left;
            this.bntDoanhThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntDoanhThu.Image = ((System.Drawing.Image)(resources.GetObject("bntDoanhThu.Image")));
            this.bntDoanhThu.ImageFixedSize = new System.Drawing.Size(45, 45);
            this.bntDoanhThu.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.bntDoanhThu.Location = new System.Drawing.Point(911, 0);
            this.bntDoanhThu.Name = "bntDoanhThu";
            this.bntDoanhThu.Size = new System.Drawing.Size(227, 177);
            this.bntDoanhThu.TabIndex = 8;
            this.bntDoanhThu.Text = "Doanh Thu";
            this.bntDoanhThu.Click += new System.EventHandler(this.bntDoanhThu_Click);
            // 
            // btnHoaDon
            // 
            this.btnHoaDon.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnHoaDon.ColorTable = DevComponents.DotNetBar.eButtonColor.MagentaWithBackground;
            this.btnHoaDon.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoaDon.Image = ((System.Drawing.Image)(resources.GetObject("btnHoaDon.Image")));
            this.btnHoaDon.ImageFixedSize = new System.Drawing.Size(45, 45);
            this.btnHoaDon.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnHoaDon.Location = new System.Drawing.Point(684, 0);
            this.btnHoaDon.Name = "btnHoaDon";
            this.btnHoaDon.Size = new System.Drawing.Size(227, 177);
            this.btnHoaDon.TabIndex = 7;
            this.btnHoaDon.Text = "Nhập hàng";
            this.btnHoaDon.Click += new System.EventHandler(this.btnHoaDon_Click);
            // 
            // btnsanpham
            // 
            this.btnsanpham.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnsanpham.ColorTable = DevComponents.DotNetBar.eButtonColor.MagentaWithBackground;
            this.btnsanpham.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnsanpham.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsanpham.Image = ((System.Drawing.Image)(resources.GetObject("btnsanpham.Image")));
            this.btnsanpham.ImageFixedSize = new System.Drawing.Size(45, 45);
            this.btnsanpham.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnsanpham.Location = new System.Drawing.Point(457, 0);
            this.btnsanpham.Name = "btnsanpham";
            this.btnsanpham.Size = new System.Drawing.Size(227, 177);
            this.btnsanpham.TabIndex = 4;
            this.btnsanpham.Text = "Sản Phẩm";
            this.btnsanpham.Click += new System.EventHandler(this.btnsanpham_Click);
            // 
            // btnkhachhang
            // 
            this.btnkhachhang.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnkhachhang.ColorTable = DevComponents.DotNetBar.eButtonColor.MagentaWithBackground;
            this.btnkhachhang.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnkhachhang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnkhachhang.Image = ((System.Drawing.Image)(resources.GetObject("btnkhachhang.Image")));
            this.btnkhachhang.ImageFixedSize = new System.Drawing.Size(45, 45);
            this.btnkhachhang.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnkhachhang.Location = new System.Drawing.Point(230, 0);
            this.btnkhachhang.Name = "btnkhachhang";
            this.btnkhachhang.Size = new System.Drawing.Size(227, 177);
            this.btnkhachhang.TabIndex = 3;
            this.btnkhachhang.Text = "Khách Hàng";
            this.btnkhachhang.Click += new System.EventHandler(this.btnkhachhang_Click);
            // 
            // btnnhanvien
            // 
            this.btnnhanvien.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnnhanvien.ColorTable = DevComponents.DotNetBar.eButtonColor.MagentaWithBackground;
            this.btnnhanvien.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnnhanvien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnhanvien.Image = ((System.Drawing.Image)(resources.GetObject("btnnhanvien.Image")));
            this.btnnhanvien.ImageFixedSize = new System.Drawing.Size(45, 45);
            this.btnnhanvien.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnnhanvien.Location = new System.Drawing.Point(3, 0);
            this.btnnhanvien.Name = "btnnhanvien";
            this.btnnhanvien.Size = new System.Drawing.Size(227, 177);
            this.btnnhanvien.TabIndex = 2;
            this.btnnhanvien.Text = "Nhân Viên";
            this.btnnhanvien.Click += new System.EventHandler(this.btnnhanvien_Click);
            // 
            // ribbonTabItem1
            // 
            this.ribbonTabItem1.ColorTable = DevComponents.DotNetBar.eRibbonTabColor.Magenta;
            this.ribbonTabItem1.ImagePaddingHorizontal = 8;
            this.ribbonTabItem1.Name = "ribbonTabItem1";
            this.ribbonTabItem1.Panel = this.ribbonPanel1;
            this.ribbonTabItem1.Text = "Hệ Thống ";
            // 
            // ribbonTabItem2
            // 
            this.ribbonTabItem2.Checked = true;
            this.ribbonTabItem2.ColorTable = DevComponents.DotNetBar.eRibbonTabColor.Magenta;
            this.ribbonTabItem2.ImagePaddingHorizontal = 8;
            this.ribbonTabItem2.Name = "ribbonTabItem2";
            this.ribbonTabItem2.Panel = this.ribbonPanel2;
            this.ribbonTabItem2.Text = "Quản Lý";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 240);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1527, 471);
            this.panel1.TabIndex = 1;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1527, 711);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ribbonControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(35, 35);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trang Chính";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ribbonControl1.ResumeLayout(false);
            this.ribbonControl1.PerformLayout();
            this.ribbonPanel1.ResumeLayout(false);
            this.ribbonPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.RibbonControl ribbonControl1;
        private DevComponents.DotNetBar.RibbonPanel ribbonPanel1;
        private DevComponents.DotNetBar.RibbonPanel ribbonPanel2;
        private DevComponents.DotNetBar.RibbonTabItem ribbonTabItem1;
        private DevComponents.DotNetBar.RibbonTabItem ribbonTabItem2;
        private DevComponents.DotNetBar.ButtonX buttonX4;
        private DevComponents.DotNetBar.ButtonX bntDoiMatKhau;
        private DevComponents.DotNetBar.ButtonX btnsanpham;
        private DevComponents.DotNetBar.ButtonX btnkhachhang;
        private DevComponents.DotNetBar.ButtonX btnnhanvien;
        private DevComponents.DotNetBar.ButtonX btnHoaDon;
        private System.Windows.Forms.Panel panel1;
        private DevComponents.DotNetBar.ButtonX bntDoanhThu;
        private DevComponents.DotNetBar.ButtonX bntNhaCungCap;
    }
}