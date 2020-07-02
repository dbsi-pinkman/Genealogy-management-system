using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
namespace 电子族谱管理系统.DAL
{
    /// <summary>
    /// [Genaration]表数据访问类
    /// 作者:许郭
    /// 创建时间:2020-07-01 19:43:39
    /// </summary>
    public class GenarationDAL
    {
        public GenarationDAL()
        { }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(电子族谱管理系统.Model.Genaration model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into [Genaration](");
            strSql.Append("[Gen_id], [Gen_name], [Gen_red], [Gen_tag], [Gen_char], [Gen_big] )");
            strSql.Append(" values (");
            strSql.Append("@Gen_id, @Gen_name, @Gen_red, @Gen_tag, @Gen_char, @Gen_big )");
            strSql.Append(";select @@IDENTITY");
            MSSQLHelper h = new MSSQLHelper();
            h.CreateCommand(strSql.ToString());
            if (model.Gen_id == null)
            {
                h.AddParameter("@Gen_id", DBNull.Value);
            }
            else
            {
                h.AddParameter("@Gen_id", model.Gen_id);
            }
            if (model.Gen_name == null)
            {
                h.AddParameter("@Gen_name", DBNull.Value);
            }
            else
            {
                h.AddParameter("@Gen_name", model.Gen_name);
            }
            if (model.Gen_red == null)
            {
                h.AddParameter("@Gen_red", DBNull.Value);
            }
            else
            {
                h.AddParameter("@Gen_red", model.Gen_red);
            }
            if (model.Gen_tag == null)
            {
                h.AddParameter("@Gen_tag", DBNull.Value);
            }
            else
            {
                h.AddParameter("@Gen_tag", model.Gen_tag);
            }
            if (model.Gen_char == null)
            {
                h.AddParameter("@Gen_char", DBNull.Value);
            }
            else
            {
                h.AddParameter("@Gen_char", model.Gen_char);
            }
            if (model.Gen_big == null)
            {
                h.AddParameter("@Gen_big", DBNull.Value);
            }
            else
            {
                h.AddParameter("@Gen_big", model.Gen_big);
            }
            int result;
            string obj = h.ExecuteScalar();
            if (!int.TryParse(obj, out result))
            {
                return 0;
            }
            return result;
        }


        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(电子族谱管理系统.Model.Genaration model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update [Genaration] set ");
            strSql.Append("[Gen_name]=@Gen_name, [Gen_red]=@Gen_red, [Gen_tag]=@Gen_tag, [Gen_char]=@Gen_char, [Gen_big]=@Gen_big   ");
            strSql.Append(" where Gen_id=@Gen_id ");
            MSSQLHelper h = new MSSQLHelper();
            h.CreateCommand(strSql.ToString());
            if (model.Gen_id == null)
            {
                 h.AddParameter("@Gen_id", DBNull.Value);
            }
            else
            {
                 h.AddParameter("@Gen_id", model.Gen_id);
            }
            if (model.Gen_name == null)
            {
                 h.AddParameter("@Gen_name", DBNull.Value);
            }
            else
            {
                 h.AddParameter("@Gen_name", model.Gen_name);
            }
            if (model.Gen_red == null)
            {
                 h.AddParameter("@Gen_red", DBNull.Value);
            }
            else
            {
                 h.AddParameter("@Gen_red", model.Gen_red);
            }
            if (model.Gen_tag == null)
            {
                 h.AddParameter("@Gen_tag", DBNull.Value);
            }
            else
            {
                 h.AddParameter("@Gen_tag", model.Gen_tag);
            }
            if (model.Gen_char == null)
            {
                 h.AddParameter("@Gen_char", DBNull.Value);
            }
            else
            {
                 h.AddParameter("@Gen_char", model.Gen_char);
            }
            if (model.Gen_big == null)
            {
                 h.AddParameter("@Gen_big", DBNull.Value);
            }
            else
            {
                 h.AddParameter("@Gen_big", model.Gen_big);
            }
            return h.ExecuteNonQuery();
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int keyId)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from [Genaration] ");
            strSql.Append(" where Gen_id=@Gen_id ");
            MSSQLHelper h = new MSSQLHelper();
            h.CreateCommand(strSql.ToString());
            h.AddParameter("@Gen_id", keyId);
            return h.ExecuteNonQuery();
        }

        /// <summary>
        /// 根据条件删除数据
        /// </summary>
        public bool DeleteByCond(string cond)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from [Genaration] ");
            if (!string.IsNullOrEmpty(cond))
            {
                strSql.Append(" where " + cond);
            }
            MSSQLHelper h = new MSSQLHelper();
            h.CreateCommand(strSql.ToString());
            return h.ExecuteNonQuery();
        }
		
        /// <summary>
        /// 取一个字段的值
        /// </summary>
        /// <param name="filed">字段，如sum(je)</param>
        /// <param name="cond">条件，如userid=2</param>
        /// <returns></returns>
        public string GetOneFiled(string filed, string cond)
        {
            string sql = "select " + filed + " from [Genaration]";
            if (!string.IsNullOrEmpty(cond))
            {
                sql += " where " + cond;
            }
            MSSQLHelper h = new MSSQLHelper();
            h.CreateCommand(sql);
            return h.ExecuteScalar();
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public 电子族谱管理系统.Model.Genaration GetModel(int keyId)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * from [Genaration] ");
            strSql.Append(" where Gen_id=@Gen_id ");
            MSSQLHelper h = new MSSQLHelper();
            h.CreateCommand(strSql.ToString());
            h.AddParameter("@Gen_id", keyId);
            电子族谱管理系统.Model.Genaration model = null;
            using (IDataReader dataReader = h.ExecuteReader())
            {
                if (dataReader.Read())
                {
                    model = ReaderBind(dataReader);
                }
                h.CloseConn();
            }
            return model;
        }

        /// <summary>
        /// 根据条件得到一个对象实体
        /// </summary>
        public 电子族谱管理系统.Model.Genaration GetModelByCond(string cond)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select top 1 * from [Genaration] ");
            if (!string.IsNullOrEmpty(cond))
            {
                strSql.Append(" where " + cond);
            }
            MSSQLHelper h = new MSSQLHelper();
            h.CreateCommand(strSql.ToString());
            电子族谱管理系统.Model.Genaration model = null;
            using (IDataReader dataReader = h.ExecuteReader())
            {
                if (dataReader.Read())
                {
                    model = ReaderBind(dataReader);
                }
                h.CloseConn();
            }
            return model;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * ");
            strSql.Append(" FROM [Genaration] ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            MSSQLHelper h = new MSSQLHelper();
            h.CreateCommand(strSql.ToString());
            DataTable dt = h.ExecuteQuery();
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }

        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetList(string fileds, string order, string ordertype, int PageSize, int PageIndex, string strWhere)
        {
            MSSQLHelper h = new MSSQLHelper();
            h.CreateStoredCommand("[proc_SplitPage]");
            h.AddParameter("@tblName", "[Genaration]");
            h.AddParameter("@strFields", fileds);
            h.AddParameter("@strOrder", order);
            h.AddParameter("@strOrderType", ordertype);
            h.AddParameter("@PageSize", PageSize);
            h.AddParameter("@PageIndex", PageIndex);
            h.AddParameter("@strWhere", strWhere);
            DataTable dt = h.ExecuteQuery();
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }

        /// <summary>
        /// 获得数据列表（比DataSet效率高，推荐使用）
        /// </summary>
        public List<电子族谱管理系统.Model.Genaration> GetListArray(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * ");
            strSql.Append(" FROM [Genaration] ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            List<电子族谱管理系统.Model.Genaration> list = new List<电子族谱管理系统.Model.Genaration>();
            MSSQLHelper h = new MSSQLHelper();
            h.CreateCommand(strSql.ToString());
            using (IDataReader dataReader = h.ExecuteReader())
            {
                while (dataReader.Read())
                {
                    list.Add(ReaderBind(dataReader));
                }
                h.CloseConn();
            }
            return list;
        }

        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public List<电子族谱管理系统.Model.Genaration> GetListArray(string fileds, string order, string ordertype, int PageSize, int PageIndex, string strWhere)
        {
            MSSQLHelper h = new MSSQLHelper();
            h.CreateStoredCommand("[proc_SplitPage]");
            h.AddParameter("@tblName", "[Genaration]");
            h.AddParameter("@strFields", fileds);
            h.AddParameter("@strOrder", order);
            h.AddParameter("@strOrderType", ordertype);
            h.AddParameter("@PageSize", PageSize);
            h.AddParameter("@PageIndex", PageIndex);
            h.AddParameter("@strWhere", strWhere);
            List<电子族谱管理系统.Model.Genaration> list = new List<电子族谱管理系统.Model.Genaration>();
            using (IDataReader dataReader = h.ExecuteReader())
            {
                while (dataReader.Read())
                {
                    list.Add(ReaderBind(dataReader));
                }
                h.CloseConn();
            }
            return list;
        }

        /// <summary>
        /// 对象实体绑定数据
        /// </summary>
        public 电子族谱管理系统.Model.Genaration ReaderBind(IDataReader dataReader)
        {
            电子族谱管理系统.Model.Genaration model = new 电子族谱管理系统.Model.Genaration();
            object ojb;
            ojb = dataReader["Gen_id"];
            if (ojb != null && ojb != DBNull.Value)
            {
                model.Gen_id = int.Parse(ojb.ToString());
            }
                model.Gen_name = dataReader["Gen_name"].ToString();
                model.Gen_red = dataReader["Gen_red"].ToString();
                model.Gen_tag = dataReader["Gen_tag"].ToString();
                model.Gen_char = dataReader["Gen_char"].ToString();
                model.Gen_big = dataReader["Gen_big"].ToString();
            return model;
        }

        /// <summary>
        /// 计算记录数
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public int CalcCount(string cond)
        {
            string sql = "select count(1) from [Genaration]";
            if (!string.IsNullOrEmpty(cond))
            {
                sql += " where " + cond;
            }
            MSSQLHelper h = new MSSQLHelper();
            h.CreateCommand(sql);
            return int.Parse(h.ExecuteScalar());
        }
    }
}
