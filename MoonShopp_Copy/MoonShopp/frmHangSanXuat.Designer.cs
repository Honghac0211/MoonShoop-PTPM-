
namespace MoonShopp
{
    partial class frmHangSanXuat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHangSanXuat));
            this.dgvHangSanXuat = new System.Windows.Forms.DataGridView();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.txtTenHangSanXuat = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtMaHangSanXuat = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.btnDong = new DevComponents.DotNetBar.ButtonX();
            this.btnSua = new DevComponents.DotNetBar.ButtonX();
            this.btnXoa = new DevComponents.DotNetBar.ButtonX();
            this.btnThem = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHangSanXuat)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHangSanXuat
            // 
            this.dgvHangSanXuat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHangSanXuat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHangSanXuat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvHangSanXuat.Location = new System.Drawing.Point(0, 237);
            this.dgvHangSanXuat.Name = "dgvHangSanXuat";
            this.dgvHangSanXuat.RowHeadersWidth = 62;
            this.dgvHangSanXuat.RowTemplate.Height = 28;
            this.dgvHangSanXuat.Size = new System.Drawing.Size(803, 246);
            this.dgvHangSanXuat.TabIndex = 4;
            this.dgvHangSanXuat.SelectionChanged += new System.EventHandler(this.dgvHangSanXuat_SelectionChanged);
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            this.labelX3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX3.Location = new System.Drawing.Point(231, 3);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(378, 45);
            this.labelX3.TabIndex = 23;
            this.labelX3.Text = "DANH SÁCH HÃNG SẢN XUẤT";
            this.labelX3.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // txtTenHangSanXuat
            // 
            // 
            // 
            // 
            this.txtTenHangSanXuat.Border.Class = "TextBoxBorder";
            this.txtTenHangSanXuat.Location = new System.Drawing.Point(335, 106);
            this.txtTenHangSanXuat.Name = "txtTenHangSanXuat";
            this.txtTenHangSanXuat.Size = new System.Drawing.Size(297, 41);
            this.txtTenHangSanXuat.TabIndex = 22;
            // 
            // txtMaHangSanXuat
            // 
            // 
            // 
            // 
            this.txtMaHangSanXuat.Border.Class = "TextBoxBorder";
            this.txtMaHangSanXuat.Location = new System.Drawing.Point(335, 62);
            this.txtMaHangSanXuat.Name = "txtMaHangSanXuat";
            this.txtMaHangSanXuat.Size = new System.Drawing.Size(297, 38);
            this.txtMaHangSanXuat.TabIndex = 21;
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            this.labelX2.Location = new System.Drawing.Point(154, 106);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(151, 41);
            this.labelX2.TabIndex = 20;
            this.labelX2.Text = "Tên hãng sản xuất :";
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            this.labelX1.Location = new System.Drawing.Point(154, 62);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(151, 38);
            this.labelX1.TabIndex = 19;
            this.labelX1.Text = "Mã hãng sản xuất :";
            // 
            // btnDong
            // 
            this.btnDong.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDong.ColorTable = DevComponents.DotNetBar.eButtonColor.MagentaWithBackground;
            this.btnDong.Image = ((System.Drawing.Image)(resources.GetObject("btnDong.Image")));
            this.btnDong.ImageFixedSize = new System.Drawing.Size(45, 45);
            this.btnDong.Location = new System.Drawing.Point(534, 165);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(128, 56);
            this.btnDong.TabIndex = 105;
            this.btnDong.Text = "Đóng";
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnSua
            // 
            this.btnSua.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSua.ColorTable = DevComponents.DotNetBar.eButtonColor.MagentaWithBackground;
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageFixedSize = new System.Drawing.Size(45, 45);
            this.btnSua.Location = new System.Drawing.Point(408, 165);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(110, 56);
            this.btnSua.TabIndex = 104;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnXoa.ColorTable = DevComponents.DotNetBar.eButtonColor.MagentaWithBackground;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageFixedSize = new System.Drawing.Size(45, 45);
            this.btnXoa.Location = new System.Drawing.Point(282, 165);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(110, 56);
            this.btnXoa.TabIndex = 103;
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
            this.btnThem.Location = new System.Drawing.Point(136, 165);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(128, 56);
            this.btnThem.TabIndex = 102;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // frmHangSanXuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(803, 483);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.txtTenHangSanXuat);
            this.Controls.Add(this.txtMaHangSanXuat);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.dgvHangSanXuat);
            this.Name = "frmHangSanXuat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hãng Sản Xuất";
            this.Load += new System.EventHandler(this.frmHangSanXuat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHangSanXuat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvHangSanXuat;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTenHangSanXuat;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMaHangSanXuat;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.ButtonX btnDong;
        private DevComponents.DotNetBar.ButtonX btnSua;
        private DevComponents.DotNetBar.ButtonX btnXoa;
        private DevComponents.DotNetBar.ButtonX btnThem;
    }
}