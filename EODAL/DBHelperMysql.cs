using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EODAL
{
    public class DBHelperMysql
    {
        //数据库的连接工作
        private static string connectionString = ConfigurationManager.ConnectionStrings["MySQLConnection"].ConnectionString;
        static MySqlConnection conn = new MySqlConnection(connectionString);

        //封装ExecuScal方法，返回值为int类型
        public static int excutScal(string sql , Hashtable ht)
        {
            conn.Open();

            MySqlCommand cmd = new MySqlCommand(sql,conn);

            //把ht传递过来之后，需要给参数赋值
            foreach (DictionaryEntry de in ht)
            {
                cmd.Parameters.AddWithValue(de.Key.ToString(), de.Value.ToString());
            }

            int result;
            try
            {
                result = Convert.ToInt32(cmd.ExecuteScalar());
            }
            finally { conn.Close(); }
            return result;
        }
    }
}
