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
	public class DrinkDAO
	{
		public static List<Drink> GetDrinksByIDCatalog(int idloai)
		{
			List<Drink> drinks = new List<Drink>();
			DTConnect connect = new DTConnect();
			connect.OpenConnect();

			SqlCommand cmd = new SqlCommand("Select * From NUOC Where idLoai=@idloai", connect.conn);
			cmd.Parameters.Add("@idloai", SqlDbType.Int).Value = idloai;
			SqlDataReader reader = cmd.ExecuteReader();
			while (reader.Read())
			{
				int id = reader.GetInt32(0);
				string ten = reader.GetString(1);
				int idnhom = reader.GetInt32(2);
				double gia = reader.GetDouble(3);
				Drink drink = new Drink(id, ten, idnhom, gia);

				drinks.Add(drink);
			}

			connect.CloseConnect();
			return drinks;
		}
		public static List<Drink> GetDrinks()
		{
			List<Drink> drinks = new List<Drink>();
			DTConnect connect = new DTConnect();
			connect.OpenConnect();

			SqlCommand cmd = new SqlCommand("Select * From NUOC", connect.conn);
			SqlDataReader reader = cmd.ExecuteReader();
			while (reader.Read())
			{
				int id = reader.GetInt32(0);
				string ten = reader.GetString(1);
				int idnhom = reader.GetInt32(2);
				double gia = reader.GetDouble(3);
				Drink drink = new Drink(id, ten, idnhom, gia);

				drinks.Add(drink);
			}

			connect.CloseConnect();
			return drinks;
		}

		public static bool AddDrinks(string ten, int idnhom, double gia)
		{
			DTConnect connect = new DTConnect();

			connect.OpenConnect();
			SqlCommand cmd = new SqlCommand("Insert into NUOC(tenNuoc, idLoai, gia) VALUES(@ten, @idnhom, @gia)", connect.conn);
			cmd.Parameters.Add("@ten", SqlDbType.NVarChar).Value = ten;
			cmd.Parameters.Add("@idnhom", SqlDbType.Int).Value = idnhom;
			cmd.Parameters.Add("@gia", SqlDbType.Int).Value = gia;

			int kq = cmd.ExecuteNonQuery();
			connect.CloseConnect();

			return kq > 0;
		}

		public static bool EditDrinks(int id, string ten, int idnhom, double gia)
		{
			DTConnect connect = new DTConnect();

			connect.OpenConnect();
			SqlCommand cmd = new SqlCommand("Update NUOC SET tenNuoc=@ten, idLoai=@idnhom, gia=@gia Where idNuoc=@id", connect.conn);
			cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
			cmd.Parameters.Add("@ten", SqlDbType.NVarChar).Value = ten;
			cmd.Parameters.Add("@idnhom", SqlDbType.Int).Value = idnhom;
			cmd.Parameters.Add("@gia", SqlDbType.Int).Value = gia;

			int kq = cmd.ExecuteNonQuery();
			connect.CloseConnect();

			return kq > 0;
		}

		public static bool DeleteDrinks(int id)
		{
			DTConnect connect = new DTConnect();

			connect.OpenConnect();
			SqlCommand cmd = new SqlCommand("Delete NUOC Where idNuoc=@id", connect.conn);
			cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;

			int kq = cmd.ExecuteNonQuery();
			connect.CloseConnect();

			return kq > 0;
		}
	}
}
