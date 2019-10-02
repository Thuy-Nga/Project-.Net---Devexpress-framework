using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLCafe.DAO;
using QLCafe.DTO;

namespace QLCafe
{
	public partial class UC_QLNV : UserControl
	{
		public UC_QLNV()
		{
			InitializeComponent();
		}

		bool finish = false;
		private void LoadListAccount()
		{
			Login l = new Login();
			List<Account> dsnv = l.GetAccount();
			foreach (Account item in dsnv)
			{
				ListViewItem lvi = new ListViewItem(item.Tendn);
				lvi.SubItems.Add(item.Tenht);
				if (item.Loai)
					lvi.SubItems.Add("Admin");
				else
					lvi.SubItems.Add("Nhân viên");
				lvDSNV.Items.Add(lvi);
			}
			finish = true;
		}

		private void UC_QLNV_Load(object sender, EventArgs e)
		{
			LoadListAccount();
		}


		private void lvDSNV_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (finish == false) return;
			if (lvDSNV.SelectedItems.Count == -1) return;
			ListView listView = sender as ListView;

			txtTenDN.Text = listView.Items[0].Text;
			txtTenHT.Text = listView.Items[0].SubItems[1].Text;
			txtLoaiTK.Text = listView.Items[0].SubItems[2].Text;

		}

		private void btnThem_Click_1(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(txtTenDN.Text) || string.IsNullOrEmpty(txtTenHT.Text) || string.IsNullOrEmpty(txtLoaiTK.Text))
			{
				dxErrorProvider1.SetError(txtTenDN, "Bạn phải nhập nội dung này");
			}
			else
			{
				dxErrorProvider1.ClearErrors();
				Login l = new Login();
				if (l.AddAccount(txtTenDN.Text, txtTenHT.Text, txtMK.Text, txtLoaiTK.Text))
				{
					MessageBox.Show("Thêm thành công");
					lvDSNV.Items.Clear();
					LoadListAccount();
				}
				else
					MessageBox.Show("Thêm thất bại");
			}

		}

		private void btnXoa_Click(object sender, EventArgs e)
		{
			Login l = new Login();
			if (l.DeleteAccount(txtTenDN.Text))
			{
				MessageBox.Show("Xóa thành công");
				lvDSNV.Items.Clear();
				LoadListAccount();
			}
			else
				MessageBox.Show("Xóa thất bại");
		}
	}
}
