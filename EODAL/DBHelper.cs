using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace EODAL
{
    internal class DBHelper
    {
        //创建数据库连接
        public static readonly string connString = ConfigurationManager.ConnectionStrings["/*对应App.Config或Web.Config配置文件中的数据库连接名称*/"].ConnectionString;

        /// <summary>
        /// 等待执行MySql语句的MySqlCommand对象
        /// </summary>
        /// <param name="conn">MySqlConnection对象，不允许为空</param>
        /// <param name="comm">MySqlCommand对象，不允许为空</param>
        /// <param name="commType">MySqlCommand类型，不允许为空</param>
        /// <param name="commText">MySqlCommand文本或MySql语句，不允许为空</param>
        /// <param name="commParam">MySqlParameter对象，允许为空</param>
        private static void PrepareCommand(MySqlConnection conn, MySqlCommand comm, CommandType commType, string commText, MySqlParameter[] commParam)
        {
            //判断数据库连接是否打开
            if (conn.State != ConnectionState.Open)
            {
                //打开数据库连接
                conn.Open();
            }
            //设置MySqlCommand的连接
            comm.Connection = conn;
            //设置MySqlCommand的文本
            comm.CommandText = commText;
            //设置MySqlCommand的类型
            comm.CommandType = commType;
            //判断MySqlParameter是否为空
            if (commParam != null)
            {
                //循环填充数据
                foreach (MySqlParameter param in commParam)
                {
                    comm.Parameters.Add(param);
                }
            }
        }

        /// <summary>
        /// 等待执行存储过程的MySqlCommand对象
        /// </summary>
        /// <param name="conn">MySqlConnection对象，不允许为空</param>
        /// <param name="comm">MySqlCommand对象，不允许为空</param>
        /// <param name="commName">存储过程名称</param>
        /// <param name="commParam">MySqlParameter对象，允许为空</param>
        private static void PrepareCommand(MySqlConnection conn, MySqlCommand comm, string commName, params object[] commParam)
        {
            //判断数据库连接是否打开
            if (conn.State != ConnectionState.Open)
            {
                //打开数据库连接
                conn.Open();
            }
            //设置MySqlCommand的连接
            comm.Connection = conn;
            //设置MySqlCommand的存储过程名称
            comm.CommandText = commName;
            //设置MySqlCommand的类型
            comm.CommandType = CommandType.StoredProcedure;
            //获取存储过程的参数
            MySqlCommandBuilder.DeriveParameters(comm);
            //移除Return_Value 参数
            comm.Parameters.RemoveAt(0);
            //判断MySqlParameter是否为空
            if (commParam != null)
            {
                //循环赋值
                for (int i = 0; i < comm.Parameters.Count; i++)
                {
                    comm.Parameters[i].Value = commParam[i];
                }
            }
        }

        /// <summary>
        /// 执行MySql语句命令
        /// </summary>
        /// <param name="connString">数据库连接字符串</param>
        /// <param name="commType">命令类型</param>
        /// <param name="commText">MySql语句 / 参数化MySql语句</param>
        /// <param name="commParam">对象参数</param>
        /// <returns>受影响的行数</returns>
        public static int ExecuteNonQuery(string connString, CommandType commType, string commText, params MySqlParameter[] commParam)
        {
            //创建MySqlCommand命令
            MySqlCommand comm = new MySqlCommand();
            //使用Using提前释放MySqlConnection资源
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                //执行方法并传递参数
                PrepareCommand(conn, comm, commType, commText, commParam);
                //执行操作并接收结果
                int val = comm.ExecuteNonQuery();
                //返回结果
                return val;
            }
        }

        /// <summary>
        /// 执行MySql存储过程
        /// 注意：不能执行有输出（OUT）参数的存储过程
        /// </summary>
        /// <param name="connString">数据库连接字符串</param>
        /// <param name="commName">存储过程名称</param>
        /// <param name="commParam">对象参数</param>
        /// <returns>受影响的行数</returns>
        public static int ExecuteNonQuery(string connString, string commName, params object[] commParam)
        {
            //使用Using释放MySqlConnection资源
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                //创建MySqlCommand命令
                MySqlCommand comm = new MySqlCommand();
                //执行方法并传递参数
                PrepareCommand(conn, comm, commName, commParam);
                //执行操作并接收结果
                int val = comm.ExecuteNonQuery();
                //返回结果
                return val;
            }
        }

        /// <summary>
        /// 执行MySql语句命令
        /// </summary>
        /// <param name="connString">数据库连接字符串</param>
        /// <param name="commType">命令类型</param>
        /// <param name="commText">MySql语句 / 参数化MySql语句</param>
        /// <param name="commParam">对象参数</param>
        /// <returns>MySqlDataReader对象</returns>
        public static MySqlDataReader ExecuteReader(string connString, CommandType commType, string commText, params MySqlParameter[] commParam)
        {
            //创建数据库连接
            MySqlConnection conn = new MySqlConnection(connString);
            try
            {
                //创建MySqlCommand命令
                MySqlCommand comm = new MySqlCommand();
                //执行方法并传递参数
                PrepareCommand(conn, comm, commType, commText, commParam);
                //创建MySqlDataReader接收数据
                MySqlDataReader reader = comm.ExecuteReader(CommandBehavior.CloseConnection);
                //返回MySqlDataReader对象
                return reader;
            }
            catch
            {
                //关闭数据库连接
                conn.Close();
                //抛出异常
                throw;
            }
        }

        /// <summary>
        /// 执行MySql存储过程
        /// 注意：不能执行有输出（OUT）参数的存储过程
        /// </summary>
        /// <param name="connString">数据库连接字符串</param>
        /// <param name="commName">存储过程名称</param>
        /// <param name="commParam">对象参数</param>
        /// <returns>MySqlDataReader对象</returns>
        public static MySqlDataReader ExecuteReader(string connString, string commName, params object[] commParam)
        {
            //创建数据库连接
            MySqlConnection conn = new MySqlConnection(connString);
            try
            {
                //创建MySqlCommand命令
                MySqlCommand comm = new MySqlCommand();
                //执行方法并传递参数
                PrepareCommand(conn, comm, commName, commParam);
                //创建MySqlDataReader接收数据
                MySqlDataReader reader = comm.ExecuteReader(CommandBehavior.CloseConnection);
                //返回MySqlDataReader对象
                return reader;
            }
            catch
            {
                //关闭数据库连接
                conn.Close();
                //抛出异常
                throw;
            }
        }

        /// <summary>
        /// 执行MySql语句命令
        /// </summary>
        /// <param name="connString">数据库连接字符串</param>
        /// <param name="commType">命令类型</param>
        /// <param name="commText">MySql语句 / 参数化MySql语句</param>
        /// <param name="commParam">对象参数</param>
        /// <returns>DataSet对象</returns>
        public static DataSet ExecuteDataSet(string connString, CommandType commType, string commText, params MySqlParameter[] commParam)
        {
            //使用Using释放MySqlConnection资源
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                //创建MySqlCommand命令
                MySqlCommand comm = new MySqlCommand();
                //执行方法并传递参数
                PrepareCommand(conn, comm, commType, commText, commParam);
                //使用Using释放MySqlDataAdapter资源
                using (MySqlDataAdapter da = new MySqlDataAdapter(comm))
                {
                    //初始化DataSet
                    DataSet ds = new DataSet();
                    //执行方法并传递参数
                    da.Fill(ds);
                    //返回DataSet对象
                    return ds;
                }
            }
        }

        /// <summary>
        /// 执行MySql存储过程
        /// 注意：不能执行有输出（OUT）参数的存储过程
        /// </summary>
        /// <param name="connString">数据库连接字符串</param>
        /// <param name="commName">存储过程名称</param>
        /// <param name="commParam">对象参数</param>
        /// <returns>DataSet对象</returns>
        public static DataSet ExecuteDataSet(string connString, string commName, params object[] commParam)
        {
            //使用Using释放MySqlConnection资源
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                //创建MySqlCommand命令
                MySqlCommand comm = new MySqlCommand();
                //执行方法并传递参数
                PrepareCommand(conn, comm, commName, commParam);
                //使用Using释放MySqlDataAdapter资源
                using (MySqlDataAdapter da = new MySqlDataAdapter(comm))
                {
                    //初始化DataSet
                    DataSet ds = new DataSet();
                    //执行方法并传递参数
                    da.Fill(ds);
                    //返回DataSet对象
                    return ds;
                }
            }
        }

        /// <summary>
        /// 执行MySql语句命令
        /// </summary>
        /// <param name="connString">数据库连接字符串</param>
        /// <param name="commType">命令类型</param>
        /// <param name="commText">MySql语句 / 参数化MySql语句</param>
        /// <param name="commParam">对象参数</param>
        /// <returns>执行结果对象</returns>
        public static object ExecuteScalar(string connString, CommandType commType, string commText, params MySqlParameter[] commParam)
        {
            //创建MySqlCommand命令
            MySqlCommand comm = new MySqlCommand();
            //使用Using释放MySqlConnection资源
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                //执行方法并传递参数
                PrepareCommand(conn, comm, commType, commText, commParam);
                //执行操作并接收结果
                object val = comm.ExecuteScalar();
                //返回结果
                return val;
            }
        }

        /// <summary>
        /// 执行MySql存储过程
        /// 注意：不能执行有输出（OUT）参数的存储过程
        /// </summary>
        /// <param name="connString">数据库连接</param>
        /// <param name="commName">存储过程名称</param>
        /// <param name="commParam">对象参数</param>
        /// <returns>执行结果对象</returns>
        public static object ExecuteScalar(string connString, string commName, params object[] commParam)
        {
            //创建MySqlCommand命令
            MySqlCommand comm = new MySqlCommand();
            //使用Using释放MySqlConnection资源
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                //执行方法并传递参数
                PrepareCommand(conn, comm, commName, commParam);
                //执行操作并接收结果
                object val = comm.ExecuteScalar();
                //返回结果
                return val;
            }
        }

        /// <summary>
        /// 执行事务MySql语句
        /// 这个执行事务的好不好用忘记了
        /// </summary>
        /// <param name="connString">数据库连接</param>
        /// <param name="commParam">事务参数</param>
        public static void ExecuteTransaction(string connString, params string[] commParam)
        {
            //使用Using释放MySqlConnection资源
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                //打开数据库连接
                conn.Open();
                //开始事务
                MySqlTransaction tran = conn.BeginTransaction();
                //创建MySqlCommand命令
                MySqlCommand comm = new MySqlCommand();
                //设置MySqlCommand的连接
                comm.Connection = conn;
                //设置MySqlCommand的事务
                comm.Transaction = tran;
                try
                {
                    //循环执行事务
                    foreach (string param in commParam)
                    {
                        //设置MySqlCommand的文本
                        comm.CommandText = param;
                        //执行事务
                        comm.ExecuteNonQuery();
                    }
                    //提交事务
                    tran.Commit();
                }
                catch
                {
                    //终止事务
                    tran.Rollback();
                    //抛出异常
                    throw;
                }
                finally
                {
                    //关闭数据库连接
                    conn.Close();
                }
            }
        }

    }
}
