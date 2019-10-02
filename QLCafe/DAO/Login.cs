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
	public class Login : DTConnect
	{
		public Account LoginSystem(string username, string pass)
		{
			Account account = null;
			OpenConnect();
			SqlCommand cmd = new SqlCommand("Select * From TAIKHOAN Where tenTK=@username and matKhau=@pass",conn);
			cmd.Parameters.Add("@username", SqlDbType.NVarChar).Value = username;
			cmd.Parameters.Add("@pass", SqlDbType.NVarChar).Value = pass;

			SqlDataReader reader = cmd.ExecuteReader();
			if (reader.Read())
			{
				account = new Account(reader.GetString(0), reader.GetString(1), reader.GetBoolean(3));
			}
			
			CloseConnect();
			return account;
		}

		/// <summary>
		/// Cập nhật tài khoản
		/// </summary>
		/// <param name="tendn"></param>
		/// <param name="tenht"></param>
		/// <param name="mk"></param>
		/// <returns></returns>
		public bool UpdateAccount(string tendn, string tenht, string mk, string tendadn)
		{
			OpenConnect();
			string query = "Update TAIKHOAN set tenTK=@tendn, tenHienThi=@tenht, matKhau=@mt Where tenTK=@tendadn";
			SqlCommand cmd = new SqlCommand(query, conn);
			cmd.Parameters.Add("@tendn", SqlDbType.NVarChar).Value = tendn;
			cmd.Parameters.Add("@tenht", SqlDbType.NVarChar).Value = tenht;
			cmd.Parameters.Add("@mt", SqlDbType.NVarChar).Value = mk;
			cmd.Parameters.Add("@tendadn", SqlDbType.NVarChar).Value = tendadn;
			int kq = cmd.ExecuteNonQuery();
			CloseConnect();

			return kq > 0;
		}
		/// <summary>
		/// Thêm tài khoản
		/// </summary>
		/// <param name="tendn"></param>
		/// <param name="tenht"></param>
		/// <param name="mk"></param>
		/// <param name="loai"></param>
		/// <returns></returns>
		public bool AddAccount(string tendn, string tenht, string mk, string loai)
		{
			bool loaitk = false;
			if (loai.Equals("Admin"))
				loaitk = true;

			OpenConnect();
			string query = "Insert into TAIKHOAN Values(@tendn, @tenht, @mk, @loai)";
			SqlCommand cmd = new SqlCommand(query, conn);
			cmd.Parameters.Add("@tendn", SqlDbType.NVarChar).Value = tendn;
			cmd.Parameters.Add("@tenht", SqlDbType.NVarChar).Value = tenht;
			cmd.Parameters.Add("@mk", SqlDbType.NVarChar).Value = mk;
			cmd.Parameters.Add("@loai", SqlDbType.Bit).Value = loaitk;

			int kq = cmd.ExecuteNonQuery();
			CloseConnect();

			return kq > 0;
		}

		public bool DeleteAccount(string tendn)
		{
			OpenConnect();
			string query = "Delete TAIKHOAN Where tenTK = @tendn";
			SqlCommand cmd = new SqlCommand(query, conn);
			cmd.Parameters.Add("@tendn", SqlDbType.NVarChar).Value = tendn;

			int kq = cmd.ExecuteNonQuery();
			CloseConnect();

			return kq > 0;
		}

		public List<Account> GetAccount()
		{
			List<Account> accounts = new List<Account>();
			OpenConnect();
			SqlCommand cmd = new SqlCommand("Select * from TAIKHOAN", conn);
		    SqlDataReader reader =  cmd.ExecuteReader();
			while (reader.Read())
			{
				Account ac = new Account(reader.GetString(0), reader.GetString(1),reader.GetBoolean(3));
				accounts.Add(ac);
			}
			CloseConnect();

			return accounts;
		}
	}
}
