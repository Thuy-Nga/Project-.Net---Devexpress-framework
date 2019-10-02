using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCafe.DTO
{
	public class BillInfo
	{
		private int idcthd;
		private int idhd;
		private int idnuoc;
		private int sl;

		public BillInfo(int idcthd, int idhd, int idnuoc, int sl)
		{
			this.idcthd = idcthd;
			this.idhd = idhd;
			this.idnuoc = idnuoc;
			this.sl = sl;
		}

		public int Idcthd { get => idcthd; set => idcthd = value; }
		public int Idhd { get => idhd; set => idhd = value; }
		public int Idnuoc { get => idnuoc; set => idnuoc = value; }
		public int Sl { get => sl; set => sl = value; }
	}
}
