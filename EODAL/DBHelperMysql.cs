using EOModel;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Ocsp;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
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
        EOModel.tb_Teacher tb_teacher = new EOModel.tb_Teacher();

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
                Console.WriteLine(result);
            }
            finally { conn.Close(); }
            return result;
        }

        public static int ExcutSql(string SQLString)
        {
            using (MySqlCommand cmd = new MySqlCommand(SQLString,conn))
            {
                try
                {
                    conn.Open();
                    int rows = cmd.ExecuteNonQuery();
                    return rows;
                }
                catch (Exception E)
                {
                    conn.Close();
                    return 0;
                    //throw new Exception(E.Message);
                }
                finally { conn.Close(); }
            }
        }

        public static int ExcutSqlrint(string SQLString)
        {
            using (MySqlCommand cmd = new MySqlCommand(SQLString, conn))
            {
                try
                {
                    conn.Open();
                    int rows = (int)Convert.ToInt32(cmd.ExecuteScalar());
                    return rows;
                }
                catch (Exception E)
                {
                    conn.Close();
                    return 0;
                    //throw new Exception(E.Message);
                }
                finally { conn.Close(); }
            }
        }

        public static object ExcutSqlrobj(string SQLString)
        {
            using (MySqlCommand cmd = new MySqlCommand(SQLString, conn))
            {
                try
                {
                    conn.Open();
                    object rows = cmd.ExecuteScalar();
                    return rows;
                }
                catch (Exception E)
                {
                    conn.Close();
                    //return null;
                    throw new Exception(E.Message);
                }
                finally { conn.Close(); }
            }
        }

        public static List<tb_Teacher> seledb(string SQLString)
        {
            using (MySqlCommand cmd = new MySqlCommand(SQLString, conn))
            {
                try
                {
                    conn.Open();
                    MySqlDataReader dr = cmd.ExecuteReader();
                    List<tb_Teacher> t1 = new List<tb_Teacher>();
                    while(dr.Read())
                    {
                        tb_Teacher t0 = new tb_Teacher();
                        t0.TeacherID = (int)dr["tId"];
                        t0.TeacherName = dr["tName"].ToString();
                        t0.Subject = dr["Subject"].ToString() ;
                        t0.TeacherPhone = dr["tPhone"].ToString();
                        t1.Add(t0);
                    }
                    return t1;
                }
                catch (Exception E)
                {
                    conn.Close();
                    throw new Exception(E.Message);
                }
                finally { conn.Close(); }
            }
        }
    }
}
