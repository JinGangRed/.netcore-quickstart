using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CMS_DAL.Models
{
    public class Article : BaseEntity
    {
        /// <summary>
        /// 文章标题
        /// </summary>
        [Required]
        public string title;
        /// <summary>
        /// 文章内容
        /// </summary>
        public string content;
    }
}
