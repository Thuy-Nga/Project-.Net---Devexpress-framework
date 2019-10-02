using QLCafe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCafe.DAO
{
	public class DetailBillDAO
	{
		public static List<DetailBill> ShowDetailBill(int idban)
		{
			List<DetailBill> detailBills = new List<DetailBill>();
			string query = "select hd.idHD, cthd.idCTHD, hd.idBan, cthd.idNuoc, nc.tenNuoc, nc.gia, cthd.soluong, hd.ngayvao, hd.ngayra, hd.trangThai from HOADON hd, CHITIETHOADON cthd, NUOC nc Where hd.idHD = cthd.idHD and nc.idNuoc = cthd.idNuoc and idBan = @idban";
			DTConnect connect = new DTConnect();

			connect.OpenConnect();
			SqlCommand cmd = new SqlCommand(query, connect.conn);
			cmd.Parameters.Add("@idban", SqlDbType.Int).Value = idban;

			SqlDataReader reader = cmd.ExecuteReader();
			while (reader.Read())
			{
				int idhd = reader.GetInt32(0);
				int idcthd = reader.GetInt32(1);
				int id_ban = reader.GetInt32(2);
				int idnuoc = reader.GetInt32(3);
				string tennuoc = reader.GetString(4);
				double gia = reader.GetDouble(5);
				int sl = reader.GetInt32(6);
				DateTime? ngayvao = reader.GetDateTime(7);
				DateTime? ngayra;
				SqlDateTime d = reader.GetSqlDateTime(8);
				if (!d.IsNull)
				{
					ngayra = d.Value;
				}
				else
				{
					ngayra = null;
				}
				bool trangthai = reader.GetBoolean(9);
				DetailBill detailBill = new DetailBill(idhd, idcthd, id_ban, idnuoc, tennuoc, gia, sl, ngayvao, ngayra, trangthai);

				detailBills.Add(detailBill);
			}
			connect.CloseConnect();

			return detailBills;
		}
	}
}
