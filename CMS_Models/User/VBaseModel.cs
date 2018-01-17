using CMS_Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace CMS_VModels.User
{
    public class VBaseModel
    {
        public long Id { set; get; }
        /// <summary>
        /// 数据创建时间
        /// </summary>
        public DateTime? CreateTime { set; get; }
        /// <summary>
        /// 数据更新时间
        /// </summary>
        public DateTime? UpdateTime { set; get; }
        /// <summary>
        /// 数据状态
        /// </summary>
        public BaseDataState IsActive { set; get; }
    }
}
