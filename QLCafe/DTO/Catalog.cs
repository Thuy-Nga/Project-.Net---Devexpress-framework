using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCafe.DTO
{
	public class Catalog
	{
		private int loai;
		private string ten;

		public Catalog(int loai, string ten)
		{
			this.loai = loai;
			this.ten = ten;
		}
		public int Loai { get => loai; set => loai = value; }
		public string Ten { get => ten; set => ten = value; }
	}
}
