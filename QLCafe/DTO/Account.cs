using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCafe.DTO
{
	public class Account
	{
		private string tendn;
		private string tenht;
		private bool loai;

		public Account()
		{

		}

		public Account(string tendn, string tenht, bool loai)
		{
			this.Tendn = tendn;
			this.Tenht = tenht;
			this.Loai = loai;
		}

		public string Tendn { get => tendn; set => tendn = value; }
		public string Tenht { get => tenht; set => tenht = value; }
		public bool Loai { get => loai; set => loai = value; }
	}
}
