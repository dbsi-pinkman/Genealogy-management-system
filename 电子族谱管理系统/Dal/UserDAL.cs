using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
namespace 电子族谱管理系统.DAL
{
    /// <summary>
    /// [User]表数据访问类
    /// 作者:许郭
    /// 创建时间:2020-07-01 19:41:19
    /// </summary>
    public class UserDAL
    {
        public UserDAL()
        { }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(电子族谱管理系统.Model.User model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into [User](");
            strSql.Append("[User_name], [User_pwd], [User_sex], [User_birth], [User_death], [User_wid], [User_fid], [User_no], [Gen_id] )");
            strSql.Append(" values (");
            strSql.Append("@User_name, @User_pwd, @User_sex, @User_birth, @User_death, @User_wid, @User_fid, @User_no, @Gen_id )");
            strSql.Append(";select @@IDENTITY");
            MSSQLHelper h = new MSSQLHelper();
            h.CreateCommand(strSql.ToString());
            if (model.User_name == null)
            {
                 h.AddParameter("@User_name", DBNull.Value);
            }
            else
            {
                 h.AddParameter("@User_name", model.User_name);
            }
            if (model.User_pwd == null)
            {
                 h.AddParameter("@User_pwd", DBNull.Value);
            }
            else
            {
                 h.AddParameter("@User_pwd", model.User_pwd);
            }
            if (model.User_sex == null)
            {
                 h.AddParameter("@User_sex", DBNull.Value);
            }
            else
            {
                 h.AddParameter("@User_sex", model.User_sex);
            }
            if (model.User_birth == null)
            {
                 h.AddParameter("@User_birth", DateTime.Now);
            }
            else
            {
                 h.AddParameter("@User_birth", model.User_birth);
            }
            if (model.User_death == null)
            {
                 h.AddParameter("@User_death", DateTime.Now);
            }
            else
            {
                 h.AddParameter("@User_death", model.User_death);
            }
            if (model.User_wid == null)
            {
                 h.AddParameter("@User_wid", DBNull.Value);
            }
            else
            {
                 h.AddParameter("@User_wid", model.User_wid);
            }
            if (model.User_fid == null)
            {
                 h.AddParameter("@User_fid", DBNull.Value);
            }
            else
            {
                 h.AddParameter("@User_fid", model.User_fid);
            }
            if (model.User_no == null)
            {
                 h.AddParameter("@User_no", DBNull.Value);
            }
            else
            {
                 h.AddParameter("@User_no", model.User_no);
            }
            if (model.Gen_id == null)
            {
                 h.AddParameter("@Gen_id", DBNull.Value);
            }
            else
            {
                 h.AddParameter("@Gen_id", model.Gen_id);
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
        public bool Update(电子族谱管理系统.Model.User model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update [User] set ");
            strSql.Append("[User_name]=@User_name, [User_pwd]=@User_pwd, [User_sex]=@User_sex, [User_birth]=@User_birth, [User_death]=@User_death, [User_wid]=@User_wid, [User_fid]=@User_fid, [User_no]=@User_no, [Gen_id]=@Gen_id   ");
            strSql.Append(" where User_id=@User_id ");
            MSSQLHelper h = new MSSQLHelper();
            h.CreateCommand(strSql.ToString());
            if (model.User_id == null)
            {
                 h.AddParameter("@User_id", DBNull.Value);
            }
            else
            {
                 h.AddParameter("@User_id", model.User_id);
            }
            if (model.User_name == null)
            {
                 h.AddParameter("@User_name", DBNull.Value);
            }
            else
            {
                 h.AddParameter("@User_name", model.User_name);
            }
            if (model.User_pwd == null)
            {
                 h.AddParameter("@User_pwd", DBNull.Value);
            }
            else
            {
                 h.AddParameter("@User_pwd", model.User_pwd);
            }
            if (model.User_sex == null)
            {
                 h.AddParameter("@User_sex", DBNull.Value);
            }
            else
            {
                 h.AddParameter("@User_sex", model.User_sex);
            }
            if (model.User_birth == null)
            {
                 h.AddParameter("@User_birth", DBNull.Value);
            }
            else
            {
                 h.AddParameter("@User_birth", model.User_birth);
            }
            if (model.User_death == null)
            {
                 h.AddParameter("@User_death", DBNull.Value);
            }
            else
            {
                 h.AddParameter("@User_death", model.User_death);
            }
            if (model.User_wid == null)
            {
                 h.AddParameter("@User_wid", DBNull.Value);
            }
            else
            {
                 h.AddParameter("@User_wid", model.User_wid);
            }
            if (model.User_fid == null)
            {
                 h.AddParameter("@User_fid", DBNull.Value);
            }
            else
            {
                 h.AddParameter("@User_fid", model.User_fid);
            }
            if (model.User_no == null)
            {
                 h.AddParameter("@User_no", DBNull.Value);
            }
            else
            {
                 h.AddParameter("@User_no", model.User_no);
            }
            if (model.Gen_id == null)
            {
                 h.AddParameter("@Gen_id", DBNull.Value);
            }
            else
            {
                 h.AddParameter("@Gen_id", model.Gen_id);
            }
            return h.ExecuteNonQuery();
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int keyId)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from [User] ");
            strSql.Append(" where User_id=@User_id ");
            MSSQLHelper h = new MSSQLHelper();
            h.CreateCommand(strSql.ToString());
            h.AddParameter("@User_id", keyId);
            return h.ExecuteNonQuery();
        }

        /// <summary>
        /// 根据条件删除数据
        /// </summary>
        public bool DeleteByCond(string cond)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from [User] ");
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
            string sql = "select " + filed + " from [User]";
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
        public 电子族谱管理系统.Model.User GetModel(int keyId)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * from [User] ");
            strSql.Append(" where User_id=@User_id ");
            MSSQLHelper h = new MSSQLHelper();
            h.CreateCommand(strSql.ToString());
            h.AddParameter("@User_id", keyId);
            电子族谱管理系统.Model.User model = null;
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
        public 电子族谱管理系统.Model.User GetModelByCond(string cond)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select top 1 * from [User] ");
            if (!string.IsNullOrEmpty(cond))
            {
                strSql.Append(" where " + cond);
            }
            MSSQLHelper h = new MSSQLHelper();
            h.CreateCommand(strSql.ToString());
            电子族谱管理系统.Model.User model = null;
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
            strSql.Append(" FROM [User] ");
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
            h.AddParameter("@tblName", "[User]");
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
        public List<电子族谱管理系统.Model.User> GetListArray(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * ");
            strSql.Append(" FROM [User] ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            List<电子族谱管理系统.Model.User> list = new List<电子族谱管理系统.Model.User>();
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
        public List<电子族谱管理系统.Model.User> GetListArray(string fileds, string order, string ordertype, int PageSize, int PageIndex, string strWhere)
        {
            MSSQLHelper h = new MSSQLHelper();
            h.CreateStoredCommand("[proc_SplitPage]");
            h.AddParameter("@tblName", "[User]");
            h.AddParameter("@strFields", fileds);
            h.AddParameter("@strOrder", order);
            h.AddParameter("@strOrderType", ordertype);
            h.AddParameter("@PageSize", PageSize);
            h.AddParameter("@PageIndex", PageIndex);
            h.AddParameter("@strWhere", strWhere);
            List<电子族谱管理系统.Model.User> list = new List<电子族谱管理系统.Model.User>();
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
        public 电子族谱管理系统.Model.User ReaderBind(IDataReader dataReader)
        {
            电子族谱管理系统.Model.User model = new 电子族谱管理系统.Model.User();
            object ojb;
            ojb = dataReader["User_id"];
            if (ojb != null && ojb != DBNull.Value)
            {
                model.User_id = int.Parse(ojb.ToString());
            }
                model.User_name = dataReader["User_name"].ToString();
                model.User_pwd = dataReader["User_pwd"].ToString();
                model.User_sex = dataReader["User_sex"].ToString();
            ojb = dataReader["User_birth"];
            if (ojb != null && ojb != DBNull.Value)
            {
                model.User_birth = DateTime.Parse(ojb.ToString());
            }
            ojb = dataReader["User_death"];
            if (ojb != null && ojb != DBNull.Value)
            {
                model.User_death = DateTime.Parse(ojb.ToString());
            }
            ojb = dataReader["User_wid"];
            if (ojb != null && ojb != DBNull.Value)
            {
                model.User_wid = int.Parse(ojb.ToString());
            }
            ojb = dataReader["User_fid"];
            if (ojb != null && ojb != DBNull.Value)
            {
                model.User_fid = int.Parse(ojb.ToString());
            }
            ojb = dataReader["User_no"];
            if (ojb != null && ojb != DBNull.Value)
            {
                model.User_no = int.Parse(ojb.ToString());
            }
            ojb = dataReader["Gen_id"];
            if (ojb != null && ojb != DBNull.Value)
            {
                model.Gen_id = int.Parse(ojb.ToString());
            }
            return model;
        }

        /// <summary>
        /// 计算记录数
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public int CalcCount(string cond)
        {
            string sql = "select count(1) from [User]";
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
