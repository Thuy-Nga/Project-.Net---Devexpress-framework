using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCafe.DAO
{
	public class BillInfoDAO
	{
		public static bool AddBillInfo(int idhd, int idnuoc, int sl)
		{
			DTConnect connect = new DTConnect();

			connect.OpenConnect();
			SqlCommand cmd = new SqlCommand("Insert into CHITIETHOADON(idHD, idNuoc, soluong) Values(@idhd, @idnuoc, @sl)", connect.conn);
			cmd.Parameters.Add("@idhd", SqlDbType.Int).Value = idhd;
			cmd.Parameters.Add("@idnuoc", SqlDbType.Int).Value = idnuoc;
			cmd.Parameters.Add("@sl", SqlDbType.Int).Value = sl;
			int kq = cmd.ExecuteNonQuery();

			connect.CloseConnect();

			return kq > 0;
		}
	}
}
