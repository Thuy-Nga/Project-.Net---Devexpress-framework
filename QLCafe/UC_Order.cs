using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using QLCafe.DAO;
using QLCafe.DTO;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;

namespace QLCafe
{
	public partial class UC_Order : UserControl
	{
		public UC_Order()
		{
			InitializeComponent();
			LoadDSBan();
			LoadDSNhom();
		}

		#region Load
		public void LoadDSBan()
		{
			fpnA.Controls.Clear();
			//int soban = TableDAO.CountTable();
			List<Table> tables = TableDAO.GetListTable();
			foreach (Table items in tables)
			{
				SimpleButton btn = new SimpleButton();
				btn.Height = btn.Width = 85;
				btn.ForeColor = Color.Red;
				btn.Text = items.Tenban.ToString();
				btn.Tag = items;
				btn.Click += btn_Click;
				btn.ImageOptions.ImageToTextAlignment = ImageAlignToText.TopCenter;
				if (items.Trangthai == "Trống")
				{
					btn.Image = Image.FromFile(@"C:\Users\porko\Desktop\QLCafe\img\cafe-off.png");
				}
				else
				{
					btn.Image = Image.FromFile(@"C:\Users\porko\Desktop\QLCafe\img\cafe-onl.png");
				}

				fpnA.Controls.Add(btn);
			}

		}

		public void LoadDSNhom()
		{
			cboNhom.DataSource = CatalogDAO.GetListCatalog();
			cboNhom.DisplayMember = "ten";
			cboNhom.ValueMember = "loai";
		}

		private void LoadDrink(int id)
		{
			cboNuoc.DataSource = DrinkDAO.GetDrinksByIDCatalog(id);
			cboNuoc.DisplayMember = "ten";
			cboNuoc.ValueMember = "id";
		}

		public void ShowBill(int idban)
		{
			double totalPrices = 0;
			lvHoaDon.Items.Clear();
			List<DetailBill> detailBills = DetailBillDAO.ShowDetailBill(idban);
			foreach (DetailBill item in detailBills)
			{
				if (!item.Trangthai)
				{
					int count = 1;
					ListViewItem listView = new ListViewItem(count.ToString());
					listView.SubItems.Add(item.Tennuoc);
					listView.SubItems.Add(item.Sl.ToString());
					listView.SubItems.Add(item.Gia.ToString());
					double tonggia = item.Gia * item.Sl;
					totalPrices += tonggia;
					listView.SubItems.Add(tonggia.ToString());

					lvHoaDon.Items.Add(listView);
				}
				
			}

			txtTongTien.Text = totalPrices + "";
			txtThanhTien.Text = totalPrices + "";
		}
		#endregion

		#region even
		private void btn_Click(object sender, EventArgs e)
		{
			Table table = (sender as SimpleButton).Tag as Table;
			int idban = table.Idban;
			lvHoaDon.Tag = (sender as SimpleButton).Tag;
			ShowBill(idban);
		}

		private void cboNhom_SelectedIndexChanged(object sender, EventArgs e)
		{
			System.Windows.Forms.ComboBox cb = sender as System.Windows.Forms.ComboBox;

			if (cb.SelectedItem == null) return;
			Catalog catalog = cb.SelectedItem as Catalog;
			LoadDrink(catalog.Loai); 
		}

		private void btnThem_Click(object sender, EventArgs e)
		{
			Table table = lvHoaDon.Tag as Table;
			int idban = table.Idban;
			int idhd = BillDAO.GetIdBillByIdTable(idban);
			int idnuoc = (cboNuoc.SelectedItem as Drink).Id;
			int sl = (int)nmSL.Value;
			if (idhd == -1)
			{
				BillDAO.AddBill(idban);
				idhd = BillDAO.GetMaxBill();
				BillInfoDAO.AddBillInfo(idhd, idnuoc, sl);
			}
			else
			{
				BillInfoDAO.AddBillInfo(idhd, idnuoc, sl);
			}
			LoadDSBan();
			ShowBill(idban);
		}

		private void btnThanhToan_Click(object sender, EventArgs e)
		{
			DialogResult di = MessageBox.Show("Bạn có muốn thanh toán.", "Thông báo", MessageBoxButtons.OK);
			if(di == DialogResult.OK)
			{
				Table table = lvHoaDon.Tag as Table;
				int idban = table.Idban;
				int idhd = BillDAO.GetIdBillByIdTable(idban);

				TableDAO.CheckOutTable(idban);
				BillDAO.CheckoutBill(idhd);

				LoadDSBan();
				ShowBill(idban);

			}
		}

		private void cboGG_SelectedIndexChanged(object sender, EventArgs e)
		{
			txtThanhTien.Text = "";
			int index = cboGG.SelectedIndex;
			double ttien = Convert.ToDouble(txtTongTien.Text);
			double thanhtien = 0;
			if (index == 0)
			{
				thanhtien = ttien - ( ttien * 10 / 100);
			}
			if (index == 1)
			{
				thanhtien = ttien - ( ttien * 20 / 100);
			}
			if(index == 2)
			{
				thanhtien = ttien - ( ttien * 50 / 100);
			}

			txtThanhTien.Text = thanhtien + "";
		}
		#endregion

	}

}
