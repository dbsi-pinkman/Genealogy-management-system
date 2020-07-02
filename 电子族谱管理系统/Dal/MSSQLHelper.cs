using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
namespace 电子族谱管理系统.DAL
{
    /// <summary>
    /// MSSQL数据库操作类
    /// </summary>
    public class MSSQLHelper
    {
        private SqlConnection conn = null;
        private SqlCommand cmd = null;
        private SqlDataReader sdr = null;
        public MSSQLHelper()
        {
            //string connStr = System.Configuration.ConfigurationManager.ConnectionStrings["connStr"].ToString();
            //使用上面方法时请在Web.config的<configuration>中加上以下注释节点
            //<connectionStrings>
            //    <add name="connStr" connectionString="server=(local)\XUGUO;uid=sa;pwd=200505;database=电子族谱管理系统;Connect Timeout=10;" />	
            //</connectionStrings>
            string connStr = @"server=(local);uid=sa;pwd=123456;database=电子族谱管理系统;Connect Timeout=10;";
            conn = new SqlConnection(connStr);
        }
        /// <summary>
        /// 创建Command对象，默认是SQL语句
        /// </summary>
        /// <param name="sql">SQL语句</param>
        public void CreateCommand(string sql)
        {
            conn.Open();
            cmd = new SqlCommand(sql, conn);
        }
        /// <summary>
        /// 创建存储过程的Command对象
        /// </summary>
        /// <param name="procName">存储过程名称</param>
        public void CreateStoredCommand(string procName)
        {
            conn.Open();
            cmd = new SqlCommand(procName, conn);
            cmd.CommandType = CommandType.StoredProcedure;
        }
        /// <summary>
        /// 添加参数，默认是输入参数
        /// </summary>
        /// <param name="paramName">参数名称</param>
        /// <param name="value">值</param>
        public void AddParameter(string paramName, object value)
        {
            SqlParameter p = new SqlParameter(paramName, value);
            cmd.Parameters.Add(p);
        }
        /// <summary>
        /// 添加输出参数，用于存储过程
        /// </summary>
        /// <param name="paramName">参数名称</param>
        /// <param name="value">值</param>
        public void AddOutputParameter(string paramName)
        {
            SqlParameter p = new SqlParameter();
            p.ParameterName = paramName;
            p.Direction = ParameterDirection.Output;
            p.Size = 20;
            cmd.Parameters.Add(p);
        }
        /// <summary>
        /// 获取输出参数的值
        /// </summary>
        /// <param name="paramName">输出参数名称</param>
        /// <returns></returns>
        public string GetOutputParameter(string paramName)
        {
            return cmd.Parameters[paramName].Value.ToString();
        }
        /// <summary>
        ///  执行增删改SQL语句或存储过程
        /// </summary>
        /// <returns></returns>
        public bool ExecuteNonQuery()
        {
            int res;
            try
            {
                res = cmd.ExecuteNonQuery();
                if (res > 0)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
					conn.Dispose();
                }
            }
            return false;
        }
        /// <summary>
        ///  执行查询SQL语句或存储过程
        /// </summary>
        /// <returns></returns>
        public DataTable ExecuteQuery()
        {
            DataTable dt = new DataTable();
            using (sdr = cmd.ExecuteReader(CommandBehavior.CloseConnection))
            {
                dt.Load(sdr);
            }
            return dt;
        }
        /// <summary>
        /// 返回查询SQL语句或存储过程查询出的结果的第一行第一列的值
        /// </summary>
        /// <returns></returns>
        public string ExecuteScalar()
        {
            string res = "";
            try
            {
                object obj = cmd.ExecuteScalar();
                if (obj != null)
                {
                    res = obj.ToString();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
					conn.Dispose();
                }
            }
            return res;
        }
        /// <summary>
        /// 返回IDataReader只读数据流
        /// </summary>
        /// <returns></returns>
        public IDataReader ExecuteReader()
        {
            try
            {
                sdr = cmd.ExecuteReader();
                return sdr;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// 关闭数据库连接
        /// </summary>
        public void CloseConn()
        {
            try
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
					conn.Dispose();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
					conn.Dispose();
                }
            }
        }
    }
}
