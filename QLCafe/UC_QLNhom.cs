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
	public partial class UC_QLNhom : UserControl
	{
		public UC_QLNhom()
		{
			InitializeComponent();
		}

		private void UC_QLNhom_Load(object sender, EventArgs e)
		{
			gvDS.DataSource = CatalogDAO.GetListCatalog();
			labelControl5.Text += " " + CatalogDAO.CountCatalog();
			gvDSNuoc.DataSource = DrinkDAO.GetDrinks();
		}

		#region QLNhom
		private void btnThem_Click(object sender, EventArgs e)
		{
			gvDS.Controls.Clear();
			if (txtTen.Text == "")
				dxErrorProvider1.SetError(txtTen, "Bạn phải nhập tên.");
			else
			{
				try
				{
					dxErrorProvider1.ClearErrors();
					bool kq = CatalogDAO.AddCatalog(txtTen.Text);
					if (kq)
					{
						MessageBox.Show("Thêm thành công");
						labelControl5.Text += " " + CatalogDAO.CountCatalog();
						gvDS.DataSource = CatalogDAO.GetListCatalog();
					}

					else
						MessageBox.Show("Thêm thất bại");
				}
				catch (Exception ex)
				{
					MessageBox.Show("Lỗi " + ex.Message);
				}
			}

		}

		private void btnSua_Click(object sender, EventArgs e)
		{
			if (txtTen.Text == "")
				dxErrorProvider1.SetError(txtTen, "Bạn phải nhập tên.");
			else
			{
				dxErrorProvider1.ClearErrors();
				bool kq = CatalogDAO.EditCatalog(Convert.ToInt32(txtId.Text), txtTen.Text);
				if (kq)
				{
					MessageBox.Show("Sửa thành công");
					labelControl5.Text += " " + CatalogDAO.CountCatalog();
					gvDS.DataSource = CatalogDAO.GetListCatalog();
				}

				else
					MessageBox.Show("Sửa thất bại");
			}

		}

		private void btnXoa_Click_1(object sender, EventArgs e)
		{
			if (txtId.Text == "")
				dxErrorProvider1.SetError(txtId, "Bạn phải nhập số thứ tự.");
			else
			{
				dxErrorProvider1.ClearErrors();
				bool kq = CatalogDAO.DeleteCatalog(Convert.ToInt32(txtId.Text));
				if (kq)
				{
					MessageBox.Show("Xóa thành công");
					labelControl5.Text += " " + CatalogDAO.CountCatalog();
					gvDS.DataSource = CatalogDAO.GetListCatalog();
				}

				else
					MessageBox.Show("Xóa thất bại");
			}

		}
		#endregion

		#region QLNuoc
		private void btnThemNuoc_Click(object sender, EventArgs e)
		{
			gvDSNuoc.Controls.Clear();
			if (txttennuoc.Text == "" || txtgia.Text == "" || txtidnhomnuoc.Text == "")
				MessageBox.Show("Bạn phải nhập đầy đủ thông tin");
			else
			{
				string ten = txttennuoc.Text;
				int idnhom = Convert.ToInt32(txtidnhomnuoc.Text);
				double gia = Convert.ToDouble(txtgia.Text);

				bool kq = DrinkDAO.AddDrinks(ten, idnhom, gia);

				if (kq)
				{
					MessageBox.Show("Thêm nước thành công");
					gvDSNuoc.DataSource = DrinkDAO.GetDrinks();
				}
				else
				{
					MessageBox.Show("Thêm nước thất bại");
				}
			}


		}
		private void btnSuaNuoc_Click(object sender, EventArgs e)
		{
			gvDSNuoc.Controls.Clear();
			if (txttennuoc.Text == "" || txtgia.Text == "" || txtidnhomnuoc.Text == "")
				MessageBox.Show("Bạn phải nhập đầy đủ thông tin");
			else
			{
				int id = Convert.ToInt32(txtidnuoc.Text);
				string ten = txttennuoc.Text;
				int idnhom = Convert.ToInt32(txtidnhomnuoc.Text);
				double gia = Convert.ToDouble(txtgia.Text);

				bool kq = DrinkDAO.EditDrinks(id, ten, idnhom, gia);

				if (kq)
				{
					MessageBox.Show("Sửa thành công");
					gvDSNuoc.DataSource = DrinkDAO.GetDrinks();
				}
				else
				{
					MessageBox.Show("Sửa thất bại");
				}
			}
		}
		private void btnXoaNuoc_Click(object sender, EventArgs e)
		{
			gvDSNuoc.Controls.Clear();
			if (txtidnuoc.Text == "")
				MessageBox.Show("Bạn phải nhập id của nước");
			else
			{
				int id = Convert.ToInt32(txtidnuoc.Text);

				bool kq = DrinkDAO.DeleteDrinks(id);

				if (kq)
				{
					MessageBox.Show("Xóa thành công");
					gvDSNuoc.DataSource = DrinkDAO.GetDrinks();
				}
				else
				{
					MessageBox.Show("Xóa thất bại");
				}
			}
		}
		#endregion

	}
	
}
