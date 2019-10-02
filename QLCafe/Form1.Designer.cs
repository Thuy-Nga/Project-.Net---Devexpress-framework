namespace QLCafe
{
	partial class Form1
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
			this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
			this.bbtnExit = new DevExpress.XtraBars.BarButtonItem();
			this.bbtnDangNhap = new DevExpress.XtraBars.BarButtonItem();
			this.bbtnThongTin = new DevExpress.XtraBars.BarButtonItem();
			this.bbtnQLNhanVien = new DevExpress.XtraBars.BarButtonItem();
			this.bbtnQLNhom = new DevExpress.XtraBars.BarButtonItem();
			this.bbtnThongKe = new DevExpress.XtraBars.BarButtonItem();
			this.bbtnMenu = new DevExpress.XtraBars.BarButtonItem();
			this.nntnOrder = new DevExpress.XtraBars.BarButtonItem();
			this.rbpTrangChu = new DevExpress.XtraBars.Ribbon.RibbonPage();
			this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.rbpQuanLi = new DevExpress.XtraBars.Ribbon.RibbonPage();
			this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.rbpChucNang = new DevExpress.XtraBars.Ribbon.RibbonPage();
			this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.ribbonPageGroup7 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.panel1 = new System.Windows.Forms.Panel();
			this.pnDTT = new System.Windows.Forms.Panel();
			this.label5 = new System.Windows.Forms.Label();
			this.btnHuy = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.btnLuu = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.txtMK = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtTenHienThi = new System.Windows.Forms.TextBox();
			this.txtTenDN = new System.Windows.Forms.TextBox();
			this.pnDangNhap = new System.Windows.Forms.Panel();
			this.btnLogin = new System.Windows.Forms.Button();
			this.txtPass = new System.Windows.Forms.TextBox();
			this.txtUserName = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
			((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
			this.panel1.SuspendLayout();
			this.pnDTT.SuspendLayout();
			this.pnDangNhap.SuspendLayout();
			this.SuspendLayout();
			// 
			// ribbonControl1
			// 
			this.ribbonControl1.ExpandCollapseItem.Id = 0;
			this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.bbtnExit,
            this.bbtnDangNhap,
            this.bbtnThongTin,
            this.bbtnQLNhanVien,
            this.bbtnQLNhom,
            this.bbtnThongKe,
            this.bbtnMenu,
            this.nntnOrder});
			this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
			this.ribbonControl1.MaxItemId = 14;
			this.ribbonControl1.Name = "ribbonControl1";
			this.ribbonControl1.PageHeaderItemLinks.Add(this.bbtnExit);
			this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rbpTrangChu,
            this.rbpQuanLi,
            this.rbpChucNang});
			this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010;
			this.ribbonControl1.Size = new System.Drawing.Size(1182, 178);
			// 
			// bbtnExit
			// 
			this.bbtnExit.Caption = "Đăng xuất";
			this.bbtnExit.Id = 3;
			this.bbtnExit.ImageOptions.Image = global::QLCafe.Properties.Resources.Exit;
			this.bbtnExit.Name = "bbtnExit";
			this.bbtnExit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtnExit_ItemClick);
			// 
			// bbtnDangNhap
			// 
			this.bbtnDangNhap.Id = 5;
			this.bbtnDangNhap.ImageOptions.Image = global::QLCafe.Properties.Resources.Login;
			this.bbtnDangNhap.ImageOptions.LargeImage = global::QLCafe.Properties.Resources.Login;
			this.bbtnDangNhap.LargeWidth = 100;
			this.bbtnDangNhap.Name = "bbtnDangNhap";
			this.bbtnDangNhap.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
			this.bbtnDangNhap.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtnDangNhap_ItemClick);
			// 
			// bbtnThongTin
			// 
			this.bbtnThongTin.Enabled = false;
			this.bbtnThongTin.Id = 7;
			this.bbtnThongTin.ImageOptions.LargeImage = global::QLCafe.Properties.Resources.edit_profile_48;
			this.bbtnThongTin.LargeWidth = 100;
			this.bbtnThongTin.Name = "bbtnThongTin";
			this.bbtnThongTin.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
			this.bbtnThongTin.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtnThongTin_ItemClick);
			// 
			// bbtnQLNhanVien
			// 
			this.bbtnQLNhanVien.Id = 8;
			this.bbtnQLNhanVien.ImageOptions.LargeImage = global::QLCafe.Properties.Resources.management_481;
			this.bbtnQLNhanVien.LargeWidth = 150;
			this.bbtnQLNhanVien.Name = "bbtnQLNhanVien";
			this.bbtnQLNhanVien.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
			this.bbtnQLNhanVien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtnQLNhanVien_ItemClick);
			// 
			// bbtnQLNhom
			// 
			this.bbtnQLNhom.Id = 9;
			this.bbtnQLNhom.ImageOptions.LargeImage = global::QLCafe.Properties.Resources.Drink_Managment;
			this.bbtnQLNhom.LargeWidth = 150;
			this.bbtnQLNhom.Name = "bbtnQLNhom";
			this.bbtnQLNhom.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
			this.bbtnQLNhom.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtnQLNhom_ItemClick);
			// 
			// bbtnThongKe
			// 
			this.bbtnThongKe.Id = 11;
			this.bbtnThongKe.ImageOptions.LargeImage = global::QLCafe.Properties.Resources.increase_48;
			this.bbtnThongKe.LargeWidth = 150;
			this.bbtnThongKe.Name = "bbtnThongKe";
			this.bbtnThongKe.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
			// 
			// bbtnMenu
			// 
			this.bbtnMenu.Id = 12;
			this.bbtnMenu.ImageOptions.LargeImage = global::QLCafe.Properties.Resources.menu;
			this.bbtnMenu.LargeWidth = 150;
			this.bbtnMenu.Name = "bbtnMenu";
			this.bbtnMenu.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
			this.bbtnMenu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtnMenu_ItemClick);
			// 
			// nntnOrder
			// 
			this.nntnOrder.Id = 13;
			this.nntnOrder.ImageOptions.LargeImage = global::QLCafe.Properties.Resources.bill_48;
			this.nntnOrder.LargeWidth = 150;
			this.nntnOrder.Name = "nntnOrder";
			this.nntnOrder.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
			this.nntnOrder.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.nntnOrder_ItemClick);
			// 
			// rbpTrangChu
			// 
			this.rbpTrangChu.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup5});
			this.rbpTrangChu.Image = global::QLCafe.Properties.Resources.home;
			this.rbpTrangChu.Name = "rbpTrangChu";
			this.rbpTrangChu.Text = "Trang chủ";
			// 
			// ribbonPageGroup1
			// 
			this.ribbonPageGroup1.AllowTextClipping = false;
			this.ribbonPageGroup1.ItemLinks.Add(this.bbtnDangNhap);
			this.ribbonPageGroup1.Name = "ribbonPageGroup1";
			this.ribbonPageGroup1.Text = "Đăng nhập";
			// 
			// ribbonPageGroup5
			// 
			this.ribbonPageGroup5.ItemLinks.Add(this.bbtnThongTin);
			this.ribbonPageGroup5.Name = "ribbonPageGroup5";
			this.ribbonPageGroup5.Text = "Đổi thông tin";
			// 
			// rbpQuanLi
			// 
			this.rbpQuanLi.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3,
            this.ribbonPageGroup2});
			this.rbpQuanLi.Image = global::QLCafe.Properties.Resources.management_48;
			this.rbpQuanLi.Name = "rbpQuanLi";
			this.rbpQuanLi.Text = "Quản lí";
			this.rbpQuanLi.Visible = false;
			// 
			// ribbonPageGroup3
			// 
			this.ribbonPageGroup3.ItemLinks.Add(this.bbtnQLNhanVien);
			this.ribbonPageGroup3.Name = "ribbonPageGroup3";
			this.ribbonPageGroup3.Text = "Quản lí nhân viên";
			// 
			// ribbonPageGroup2
			// 
			this.ribbonPageGroup2.ItemLinks.Add(this.bbtnQLNhom);
			this.ribbonPageGroup2.Name = "ribbonPageGroup2";
			this.ribbonPageGroup2.Text = "Quản lí chung";
			// 
			// rbpChucNang
			// 
			this.rbpChucNang.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup4,
            this.ribbonPageGroup7});
			this.rbpChucNang.Image = global::QLCafe.Properties.Resources.icons8_purchase_order_48;
			this.rbpChucNang.Name = "rbpChucNang";
			this.rbpChucNang.Text = "Chức năng";
			this.rbpChucNang.Visible = false;
			// 
			// ribbonPageGroup4
			// 
			this.ribbonPageGroup4.ItemLinks.Add(this.bbtnMenu);
			this.ribbonPageGroup4.Name = "ribbonPageGroup4";
			this.ribbonPageGroup4.Text = "Menu";
			// 
			// ribbonPageGroup7
			// 
			this.ribbonPageGroup7.ItemLinks.Add(this.nntnOrder);
			this.ribbonPageGroup7.Name = "ribbonPageGroup7";
			this.ribbonPageGroup7.Text = "Order Nước";
			// 
			// panel1
			// 
			this.panel1.BackgroundImage = global::QLCafe.Properties.Resources.background2;
			this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.panel1.Controls.Add(this.pnDTT);
			this.panel1.Controls.Add(this.pnDangNhap);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 178);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1182, 508);
			this.panel1.TabIndex = 1;
			// 
			// pnDTT
			// 
			this.pnDTT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pnDTT.Controls.Add(this.label5);
			this.pnDTT.Controls.Add(this.btnHuy);
			this.pnDTT.Controls.Add(this.label2);
			this.pnDTT.Controls.Add(this.btnLuu);
			this.pnDTT.Controls.Add(this.label3);
			this.pnDTT.Controls.Add(this.txtMK);
			this.pnDTT.Controls.Add(this.label4);
			this.pnDTT.Controls.Add(this.txtTenHienThi);
			this.pnDTT.Controls.Add(this.txtTenDN);
			this.pnDTT.Location = new System.Drawing.Point(698, 83);
			this.pnDTT.Name = "pnDTT";
			this.pnDTT.Size = new System.Drawing.Size(425, 272);
			this.pnDTT.TabIndex = 2;
			this.pnDTT.Visible = false;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label5.Location = new System.Drawing.Point(123, 23);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(204, 25);
			this.label5.TabIndex = 15;
			this.label5.Text = "Đổi thông tin tài khoản";
			// 
			// btnHuy
			// 
			this.btnHuy.Location = new System.Drawing.Point(287, 223);
			this.btnHuy.Name = "btnHuy";
			this.btnHuy.Size = new System.Drawing.Size(91, 33);
			this.btnHuy.TabIndex = 14;
			this.btnHuy.Text = "Hủy";
			this.btnHuy.UseVisualStyleBackColor = true;
			this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label2.Location = new System.Drawing.Point(17, 79);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(109, 18);
			this.label2.TabIndex = 7;
			this.label2.Text = "Tên đăng nhập:";
			// 
			// btnLuu
			// 
			this.btnLuu.Location = new System.Drawing.Point(150, 223);
			this.btnLuu.Name = "btnLuu";
			this.btnLuu.Size = new System.Drawing.Size(91, 33);
			this.btnLuu.TabIndex = 13;
			this.btnLuu.Text = "Lưu";
			this.btnLuu.UseVisualStyleBackColor = true;
			this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label3.Location = new System.Drawing.Point(17, 131);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(87, 18);
			this.label3.TabIndex = 8;
			this.label3.Text = "Tên hiển thị:";
			// 
			// txtMK
			// 
			this.txtMK.Location = new System.Drawing.Point(133, 187);
			this.txtMK.Name = "txtMK";
			this.txtMK.Size = new System.Drawing.Size(271, 21);
			this.txtMK.TabIndex = 10;
			this.txtMK.UseSystemPasswordChar = true;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label4.Location = new System.Drawing.Point(17, 187);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(73, 18);
			this.label4.TabIndex = 9;
			this.label4.Text = "Mật khẩu:";
			// 
			// txtTenHienThi
			// 
			this.txtTenHienThi.Location = new System.Drawing.Point(133, 131);
			this.txtTenHienThi.Name = "txtTenHienThi";
			this.txtTenHienThi.Size = new System.Drawing.Size(271, 21);
			this.txtTenHienThi.TabIndex = 11;
			// 
			// txtTenDN
			// 
			this.txtTenDN.Location = new System.Drawing.Point(133, 76);
			this.txtTenDN.Name = "txtTenDN";
			this.txtTenDN.Size = new System.Drawing.Size(271, 21);
			this.txtTenDN.TabIndex = 12;
			// 
			// pnDangNhap
			// 
			this.pnDangNhap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pnDangNhap.Controls.Add(this.btnLogin);
			this.pnDangNhap.Controls.Add(this.txtPass);
			this.pnDangNhap.Controls.Add(this.txtUserName);
			this.pnDangNhap.Controls.Add(this.label1);
			this.pnDangNhap.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.pnDangNhap.Location = new System.Drawing.Point(758, 113);
			this.pnDangNhap.Name = "pnDangNhap";
			this.pnDangNhap.Size = new System.Drawing.Size(343, 228);
			this.pnDangNhap.TabIndex = 0;
			this.pnDangNhap.Visible = false;
			// 
			// btnLogin
			// 
			this.btnLogin.BackColor = System.Drawing.Color.Peru;
			this.btnLogin.Location = new System.Drawing.Point(111, 165);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(136, 40);
			this.btnLogin.TabIndex = 3;
			this.btnLogin.Text = "Đăng nhập";
			this.btnLogin.UseVisualStyleBackColor = false;
			this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
			// 
			// txtPass
			// 
			this.txtPass.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPass.ForeColor = System.Drawing.Color.Gray;
			this.txtPass.Location = new System.Drawing.Point(30, 119);
			this.txtPass.Name = "txtPass";
			this.txtPass.Size = new System.Drawing.Size(292, 30);
			this.txtPass.TabIndex = 2;
			this.txtPass.Text = "Mật khẩu";
			this.txtPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtPass.Enter += new System.EventHandler(this.txtPass_Enter);
			this.txtPass.Leave += new System.EventHandler(this.txtPass_Leave);
			// 
			// txtUserName
			// 
			this.txtUserName.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtUserName.ForeColor = System.Drawing.Color.Gray;
			this.txtUserName.Location = new System.Drawing.Point(30, 72);
			this.txtUserName.Name = "txtUserName";
			this.txtUserName.Size = new System.Drawing.Size(292, 30);
			this.txtUserName.TabIndex = 1;
			this.txtUserName.Text = "Tên đăng nhập";
			this.txtUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtUserName.Enter += new System.EventHandler(this.txtUserName_Enter);
			this.txtUserName.Leave += new System.EventHandler(this.txtUserName_Leave);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(105, 18);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(142, 31);
			this.label1.TabIndex = 0;
			this.label1.Text = "Đăng nhập";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// ribbonPage2
			// 
			this.ribbonPage2.Name = "ribbonPage2";
			this.ribbonPage2.Text = "ribbonPage2";
			// 
			// Form1
			// 
			this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.False;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1182, 686);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.ribbonControl1);
			this.Name = "Form1";
			this.Ribbon = this.ribbonControl1;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Quản lí quán cafe";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
			this.panel1.ResumeLayout(false);
			this.pnDTT.ResumeLayout(false);
			this.pnDTT.PerformLayout();
			this.pnDangNhap.ResumeLayout(false);
			this.pnDangNhap.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
		private DevExpress.XtraBars.Ribbon.RibbonPage rbpTrangChu;
		private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
		private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
		private DevExpress.XtraBars.Ribbon.RibbonPage rbpQuanLi;
		private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
		private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
		private DevExpress.XtraBars.BarButtonItem bbtnExit;
		private DevExpress.XtraBars.BarButtonItem bbtnDangNhap;
		private DevExpress.XtraBars.BarButtonItem bbtnThongTin;
		private DevExpress.XtraBars.BarButtonItem bbtnQLNhanVien;
		private System.Windows.Forms.Panel panel1;
		private DevExpress.XtraBars.BarButtonItem bbtnQLNhom;
		private System.Windows.Forms.Panel pnDangNhap;
		private System.Windows.Forms.TextBox txtPass;
		private System.Windows.Forms.TextBox txtUserName;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnLogin;
		private System.Windows.Forms.Button btnHuy;
		private System.Windows.Forms.Button btnLuu;
		private System.Windows.Forms.TextBox txtMK;
		private System.Windows.Forms.TextBox txtTenHienThi;
		private System.Windows.Forms.TextBox txtTenDN;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Panel pnDTT;
		private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
		private DevExpress.XtraBars.Ribbon.RibbonPage rbpChucNang;
		private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
		private DevExpress.XtraBars.BarButtonItem bbtnThongKe;
		private DevExpress.XtraBars.BarButtonItem bbtnMenu;
		private DevExpress.XtraBars.BarButtonItem nntnOrder;
		private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup7;
	}
}

