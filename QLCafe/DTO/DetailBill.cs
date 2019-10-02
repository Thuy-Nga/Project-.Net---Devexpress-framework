using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCafe.DTO
{
	public class DetailBill
	{
		private int idhd;
		private int idcthd;
		private int idban;
		private int idnuoc;
		private string tennuoc;
		private double gia;
		private int sl;
		private DateTime? ngayvao;
		private DateTime? ngayra;
		private bool trangthai;

		public DetailBill(int idhd, int idcthd, int idban, int idnuoc, string tennuoc, double gia, int sl, DateTime? ngayvao, DateTime? ngayra, bool tt)
		{
			this.idhd = idhd;
			this.idcthd = idcthd;
			this.idban = idban;
			this.idnuoc = idnuoc;
			this.tennuoc = tennuoc;
			this.gia = gia;
			this.sl = sl;
			this.ngayvao = ngayvao;
			this.ngayra = ngayra;
			this.trangthai = tt;
		}

		public int Idhd { get => idhd; set => idhd = value; }
		public int Idcthd { get => idcthd; set => idcthd = value; }
		public int Idban { get => idban; set => idban = value; }
		public int Idnuoc { get => idnuoc; set => idnuoc = value; }
		public int Sl { get => sl; set => sl = value; }
		public DateTime? Ngayvao { get => ngayvao; set => ngayvao = value; }
		public DateTime? Ngayra { get => ngayra; set => ngayra = value; }
		public bool Trangthai { get => trangthai; set => trangthai = value; }
		public string Tennuoc { get => tennuoc; set => tennuoc = value; }
		public double Gia { get => gia; set => gia = value; }
	}
}
