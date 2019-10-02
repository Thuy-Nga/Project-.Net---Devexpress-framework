using QLCafe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCafe.DAO
{
	public class CatalogDAO
	{

		public static List<Catalog> GetListCatalog()
		{
			DTConnect con = new DTConnect();
			List<Catalog> catalogs = new List<Catalog>();
			con.OpenConnect();
			SqlCommand cmd = new SqlCommand("Select * From LOAI", con.conn);
			SqlDataReader reader = cmd.ExecuteReader();
			while (reader.Read())
			{
				Catalog catalog = new Catalog(reader.GetInt32(0), reader.GetString(1));

				catalogs.Add(catalog);
			}
			con.CloseConnect();
			return catalogs;
		}

		public static bool AddCatalog(string ten)
		{
			DTConnect con = new DTConnect();
			con.OpenConnect();
			SqlCommand cmd = new SqlCommand("Insert into LOAI(tenLoai) Values(@ten )", con.conn);

			cmd.Parameters.Add("ten", SqlDbType.NVarChar).Value = ten;
			int kq = cmd.ExecuteNonQuery();
			con.CloseConnect();

			return kq > 0;

		}

		public static bool EditCatalog(int id, string ten)
		{
			DTConnect con = new DTConnect();
			con.OpenConnect();
			SqlCommand cmd = new SqlCommand("Update LOAI Set tenLoai=@ten Where idLoai=@id", con.conn);
			cmd.Parameters.Add("id", SqlDbType.Int).Value = id;
			cmd.Parameters.Add("ten", SqlDbType.NVarChar).Value = ten;
			int kq = cmd.ExecuteNonQuery();
			con.CloseConnect();

			return kq > 0;
		}

		public static bool DeleteCatalog(int id)
		{
			DTConnect con = new DTConnect();
			con.OpenConnect();
			SqlCommand cmd = new SqlCommand("Delete LOAI Where idLoai=@id", con.conn);
			cmd.Parameters.Add("id", SqlDbType.Int).Value = id;
			int kq = cmd.ExecuteNonQuery();
			con.CloseConnect();

			return kq > 0;
		}

		public static int CountCatalog()
		{
			DTConnect con = new DTConnect();
			con.OpenConnect();
			SqlCommand cmd = new SqlCommand("Select Count(*) From LOAI", con.conn);
			int kq = (int) cmd.ExecuteScalar();
			con.CloseConnect();

			return kq;
		} 
	}
}
