using QLCafe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCafe.DAO
{
	public class TableDAO
	{
		public static int CountTable()
		{
			DTConnect connect = new DTConnect();

			connect.OpenConnect();
			SqlCommand cmd = new SqlCommand("Select Count(*) From BAN", connect.conn);
			int kq = (int) cmd.ExecuteScalar();
			connect.CloseConnect();

			return kq;
		}


		public static List<Table> GetListTable()
		{
			DTConnect con = new DTConnect();
			List<Table> listtable = new List<Table>();
			con.OpenConnect();
			SqlCommand cmd = new SqlCommand("select * from BAN", con.conn);
			SqlDataReader reader = cmd.ExecuteReader();
			while (reader.Read())
			{
				Table table = new Table(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetDouble(3));

				listtable.Add(table);
			}
			con.CloseConnect();
			return listtable;
		}

		public static bool UpdateTable(int idban)
		{
			DTConnect con = new DTConnect();
			con.OpenConnect();
			SqlCommand cmd = new SqlCommand("update BAN set trangThai =N'Có người' where idBan=@idban", con.conn);
			cmd.Parameters.Add("@idban", SqlDbType.Int).Value = idban;
			int kq = cmd.ExecuteNonQuery();
			con.CloseConnect();

			return kq > 0;
		}

		public static bool CheckOutTable(int idban)
		{
			DTConnect con = new DTConnect();
			con.OpenConnect();
			SqlCommand cmd = new SqlCommand("update BAN set trangThai =N'Trống' where idBan=@idban", con.conn);
			cmd.Parameters.Add("@idban", SqlDbType.Int).Value = idban;
			int kq = cmd.ExecuteNonQuery();
			con.CloseConnect();

			return kq > 0;
		}
	}
}
