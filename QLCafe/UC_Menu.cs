using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLCafe.DTO;
using QLCafe.DAO;

namespace QLCafe
{
	public partial class UC_Menu : UserControl
	{
		public UC_Menu()
		{
			InitializeComponent();
			LoadMenu();
		}

		private void LoadMenu()
		{
			List<Drink> drinks = DrinkDAO.GetDrinks();

			foreach(Drink items in drinks)
			{
				ListViewItem listViewItem = new ListViewItem(items.Id.ToString());

				listViewItem.SubItems.Add(items.Ten);
				listViewItem.SubItems.Add(items.IdNhom.ToString());
				listViewItem.SubItems.Add(items.Gia.ToString());

				lvMenu.Items.Add(listViewItem);
			}
		}
	}
}
