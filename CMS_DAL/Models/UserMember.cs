using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Text;

namespace CMS_DAL.Models
{
    public class UserMember : BaseEntity
    {
        [Required]
        public string Name { set; get; }
        public string NickName { set; get; }

    }





}