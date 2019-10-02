using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCafe.DTO
{
	public class Drink
	{
		private int id;
		private string ten;
		private int idNhom;
		private double gia;
		public Drink()
		{

		}
		public Drink(int id, string ten, int idnhom, double gia)
		{
			this.id = id;
			this.ten = ten;
			this.idNhom = idnhom;
			this.gia = gia;
		}

		public int Id { get => id; set => id = value; }
		public string Ten { get => ten; set => ten = value; }
		public int IdNhom { get => idNhom; set => idNhom = value; }
		public double Gia { get => gia; set => gia = value; }
	}
}
