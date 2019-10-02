using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCafe.DTO
{
	public class Bill
	{
		private int idHD;
		private int idBan;
		private DateTime? ngayvao;
		private DateTime? ngayra;
		private string trangthai;

		public Bill(int idhd, int idban, DateTime? ngayvao, DateTime? ngayra, string tt)
		{
			this.idHD = idhd;
			this.idBan = idban;
			this.ngayvao = ngayvao;
			this.ngayra = ngayra; 
		}

		public int IdHD { get => idHD; set => idHD = value; }
		public int IdBan { get => idBan; set => idBan = value; }
		public DateTime? Ngayvao { get => ngayvao; set => ngayvao = value; }
		public DateTime? Ngayra { get => ngayra; set => ngayra = value; }
		public string Trangthai { get => trangthai; set => trangthai = value; }
	}
}
