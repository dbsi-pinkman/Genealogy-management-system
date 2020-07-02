using System;
namespace 电子族谱管理系统.Model
{
    /// <summary>
    /// [User]表实体类
    /// 作者:许郭
    /// 创建时间:2020-06-28 14:02:19
    /// </summary>
    [Serializable]
    public partial class User
    {
        public User()
        { }
        private int _User_id ;
        /// <summary>
        /// 
        /// </summary>
        public int User_id
        {
            set { _User_id = value; }
            get { return _User_id; }
        }
        private string _User_name ;
        /// <summary>
        /// 
        /// </summary>
        public string User_name
        {
            set { _User_name = value; }
            get { return _User_name; }
        }
        private string _User_pwd ;
        /// <summary>
        /// 
        /// </summary>
        public string User_pwd
        {
            set { _User_pwd = value; }
            get { return _User_pwd; }
        }
        private string _User_sex ;
        /// <summary>
        /// 
        /// </summary>
        public string User_sex
        {
            set { _User_sex = value; }
            get { return _User_sex; }
        }
        private DateTime _User_birth ;
        /// <summary>
        /// 
        /// </summary>
        public DateTime User_birth
        {
            set { _User_birth = value; }
            get { return _User_birth; }
        }
        private DateTime? _User_death ;
        /// <summary>
        /// 
        /// </summary>
        public DateTime? User_death
        {
            set { _User_death = value; }
            get { return _User_death; }
        }
        private int? _User_wid ;
        /// <summary>
        /// 
        /// </summary>
        public int? User_wid
        {
            set { _User_wid = value; }
            get { return _User_wid; }
        }
        private int? _User_fid ;
        /// <summary>
        /// 
        /// </summary>
        public int? User_fid
        {
            set { _User_fid = value; }
            get { return _User_fid; }
        }
        private int _User_no ;
        /// <summary>
        /// 
        /// </summary>
        public int User_no
        {
            set { _User_no = value; }
            get { return _User_no; }
        }
        private int _Gen_id ;
        /// <summary>
        /// 
        /// </summary>
        public int Gen_id
        {
            set { _Gen_id = value; }
            get { return _Gen_id; }
        }
    }
}
