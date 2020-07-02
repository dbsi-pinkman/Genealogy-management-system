using System;
namespace 电子族谱管理系统.Model
{
    /// <summary>
    /// [Genaration]表实体类
    /// 作者:许郭
    /// 创建时间:2020-06-28 14:02:19
    /// </summary>
    [Serializable]
    public partial class Genaration
    {
        public Genaration()
        { }
        private int _Gen_id ;
        /// <summary>
        /// 
        /// </summary>
        public int Gen_id
        {
            set { _Gen_id = value; }
            get { return _Gen_id; }
        }
        private string _Gen_name ;
        /// <summary>
        /// 
        /// </summary>
        public string Gen_name
        {
            set { _Gen_name = value; }
            get { return _Gen_name; }
        }
        private string _Gen_red ;
        /// <summary>
        /// 
        /// </summary>
        public string Gen_red
        {
            set { _Gen_red = value; }
            get { return _Gen_red; }
        }
        private string _Gen_tag ;
        /// <summary>
        /// 
        /// </summary>
        public string Gen_tag
        {
            set { _Gen_tag = value; }
            get { return _Gen_tag; }
        }
        private string _Gen_char ;
        /// <summary>
        /// 
        /// </summary>
        public string Gen_char
        {
            set { _Gen_char = value; }
            get { return _Gen_char; }
        }
        private string _Gen_big ;
        /// <summary>
        /// 
        /// </summary>
        public string Gen_big
        {
            set { _Gen_big = value; }
            get { return _Gen_big; }
        }
    }
}
