using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCafe.DAO
{
	public class BillDAO
	{
		public static int GetIdBillByIdTable(int idtable)
		{
			int idhd = -1;
			DTConnect connect = new DTConnect();
			connect.OpenConnect();
			
			SqlCommand cmd = new SqlCommand("Select * From HOADON Where idBan=@idban AND trangthai=0", connect.conn);
			cmd.Parameters.Add("@idban", SqlDbType.Int).Value = idtable;

			SqlDataReader reader = cmd.ExecuteReader();
			if (reader.Read())
			{
				idhd = reader.GetInt32(0);
			}
			connect.CloseConnect();

			return idhd;
		}

		public static bool AddBill(int idban)
		{
			TableDAO.UpdateTable(idban);
			DTConnect connect = new DTConnect();

			connect.OpenConnect();
			SqlCommand cmd = new SqlCommand("Insert into HOADON(idBan) Values(@idban)", connect.conn);
			cmd.Parameters.Add("@idban", SqlDbType.Int).Value = idban;

			int kq = cmd.ExecuteNonQuery();		
			
			connect.CloseConnect();

			return kq > 0;
		}

		public static int GetMaxBill()
		{
			DTConnect connect = new DTConnect();

			connect.OpenConnect();
			SqlCommand cmd = new SqlCommand("Select Max(idHD) From HOADON", connect.conn);

			int kq = (int) cmd.ExecuteScalar();

			connect.CloseConnect();

			return kq;
		}

		public static bool CheckoutBill(int idhd)
		{
			DTConnect connect = new DTConnect();

			connect.OpenConnect();
			SqlCommand cmd = new SqlCommand("update HOADON set ngayra=GETDATE() , trangThai = 1 where idHD=@idhd", connect.conn);
			cmd.Parameters.Add("@idhd", SqlDbType.Int).Value = idhd;

			int kq = cmd.ExecuteNonQuery();

			connect.CloseConnect();

			return kq > 0;
		}
	}
}
