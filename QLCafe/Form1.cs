using QLCafe.DAO;
using QLCafe.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLCafe
{
	public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm
	{
		public object Logiin { get; private set; }

		public Form1()
		{
			InitializeComponent();
		}

		#region evenLogin

		private void bbtnDangNhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			pnDangNhap.Visible = true;			
		}

		private void bbtnExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			this.Close();
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			try
			{
				Login l = new Login();
				Account account = l.LoginSystem(txtUserName.Text, txtPass.Text);
				if (account != null )
				{
					pnDangNhap.Hide();
					bbtnDangNhap.Enabled = false;
					bbtnThongTin.Enabled = true;

					if (account.Loai)
					{
						rbpQuanLi.Visible = true;
						rbpChucNang.Visible = true;
					}

					else
					{
						rbpChucNang.Visible = true;
					}
					
				}
				else
					MessageBox.Show("Lỗi khi đăng nhập");
			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi" + ex.Message + " khi đăng nhập");
			}


		}

		private void bbtnThongTin_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			pnDangNhap.Hide();
			pnDTT.Show();
		}

		// su kien luu thong tin tai khoan
		private void btnLuu_Click(object sender, EventArgs e)
		{
			Login l = new Login();
			bool kq = l.UpdateAccount(txtTenDN.Text, txtTenHienThi.Text, txtMK.Text, txtUserName.Text);

			if (kq)
			{
				MessageBox.Show("Thay đổi thông tin thành công");
			}
			else
			{
				MessageBox.Show("Thay đổi thông tin thất bại");
			}


		}

		private void btnHuy_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Hủy thay đổi thành công.");
			pnDTT.Visible = false;
		}
		#endregion

		#region eventxtlogin       
		private void txtUserName_Enter(object sender, EventArgs e)
		{
			if (txtUserName.Text == "Tên đăng nhập")
			{
				txtUserName.Text = "";
				txtUserName.ForeColor = Color.Black;
			}
		}

		private void txtUserName_Leave(object sender, EventArgs e)
		{
			if (txtUserName.Text == "")
			{
				txtUserName.Text = "Tên đăng nhập";
				txtUserName.ForeColor = Color.Gray;
			}
		}

		private void txtPass_Enter(object sender, EventArgs e)
		{
			if (txtPass.Text == "Mật khẩu")
			{
				txtPass.Text = "";
				txtPass.ForeColor = Color.Black;
				txtPass.UseSystemPasswordChar = true;
			}
		}

		private void txtPass_Leave(object sender, EventArgs e)
		{
			if (txtPass.Text == "")
			{
				txtPass.Text = "Mật khẩu";
				txtPass.ForeColor = Color.Gray;
				txtPass.UseSystemPasswordChar = false;
			}
		}



		#endregion

		#region TabQLNV
		private void bbtnQLNhanVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			panel1.Controls.Clear();
			UC_QLNV uc_qlnv = new UC_QLNV();
			panel1.Controls.Add(uc_qlnv);
			uc_qlnv.Dock = DockStyle.Fill;
		}

		#endregion

		#region TabQLChung
		private void bbtnQLNhom_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			panel1.Controls.Clear();
			UC_QLNhom uc_qlnhom = new UC_QLNhom();
			panel1.Controls.Add(uc_qlnhom);
			uc_qlnhom.Dock = DockStyle.Fill;
		}


		#endregion

		#region ChucNang
		private void bbtnMenu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			panel1.Controls.Clear();
			UC_Menu uc_menu = new UC_Menu();
			panel1.Controls.Add(uc_menu);
			uc_menu.Dock = DockStyle.Fill;
		}

		private void nntnOrder_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			panel1.Controls.Clear();
			UC_Order uc_order = new UC_Order();
			panel1.Controls.Add(uc_order);
			uc_order.Dock = DockStyle.Fill;
		}
		#endregion

	}
}
