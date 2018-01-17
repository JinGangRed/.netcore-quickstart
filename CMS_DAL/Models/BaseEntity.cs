using CMS_Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CMS_DAL.Models
{
    public class BaseEntity
    {
        /// <summary>
        /// 数据主键
        /// </summary>
        [Key]
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
        [DefaultValue(BaseDataState.Normal)]
        public BaseDataState IsActive { set; get; }

    }



}
