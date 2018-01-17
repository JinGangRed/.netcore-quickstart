using System;
using System.Collections.Generic;
using System.Text;

namespace CMS_VModels.User
{
    /// <summary>
    /// 用户视图模型
    /// </summary>
    public class VUserMember: VBaseModel
    {
        public string Name { set; get; }
        public string NickName { set; get; }
    }
}
