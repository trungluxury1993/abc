using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace TestOnline
{
    public class DataProcess
    {
        public SqlConnection GetConnection()
        {
            SqlConnection conn = null;
            conn = new SqlConnection("SERVER=DESKTOP-5SF3J80\\SQLEXPRESS;database=TestOnlineDemo;uid=sa;pwd=123456");
            return conn;
        }
        public bool AddQuestion(string id,string content,string a,string b,string c,string d,string type,string correct)
        {
            string sql = "INSERT INTO tblQuestion VALUES(@i,@content,@a,@b,@c,@d,@t,@corr)";
            SqlCommand cmd = new SqlCommand(sql,GetConnection());
            cmd.Connection.Open();
            cmd.Parameters.AddWithValue("@i", id);
            cmd.Parameters.AddWithValue("@content", content);
            cmd.Parameters.AddWithValue("@a", a);
            cmd.Parameters.AddWithValue("@b", b);
            cmd.Parameters.AddWithValue("@c", c);
            cmd.Parameters.AddWithValue("@d", d);
            cmd.Parameters.AddWithValue("@t", type);
            cmd.Parameters.AddWithValue("@corr", correct);
            int result = cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            return result > 0;
        }
    }
}
