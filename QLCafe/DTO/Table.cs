using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCafe.DTO
{
	public class Table
	{
		private int idban;
		private string tenban;
		private string trangthai;
		private double tien;

		public Table(int idban, string ten, string trangthai, double tien)
		{
			this.idban = idban;
			this.tenban = ten;
			this.trangthai = trangthai;
			this.tien = tien;
		}

		public Table()
		{

		}

		public int Idban { get => idban; set => idban = value; }
		public string Tenban { get => tenban; set => tenban = value; }
		public string Trangthai { get => trangthai; set => trangthai = value; }
		public double Tien { get => tien; set => tien = value; }
	}
}
