using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCafe.DAO
{
	public class DTConnect
	{
		string constr = @"Data Source=.\SQLEXPRESS;Initial Catalog=QLCAFE;Integrated Security=True";
		public SqlConnection conn = null;
		public void OpenConnect()
		{
			try
			{
				if (conn == null)
					conn = new SqlConnection(constr);
				if (conn.State == System.Data.ConnectionState.Closed)
					conn.Open();
			}
			catch(Exception ex)
			{
				MessageBox.Show("Lỗi " + ex.Message);
			}


		}

		public void CloseConnect()
		{
			if (conn.State == System.Data.ConnectionState.Open)
				conn.Close();
		}
	}
}
