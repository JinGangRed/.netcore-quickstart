using CMS_VModels.User;
using System;
using System.Collections.Generic;
using System.Text;

namespace CMS_Services.Services_Interface
{
    /// <summary>
    /// 用户的相关操作
    /// </summary>
    public interface IUserService
    {
        /// <summary>
        /// 根据用户ID查询用户
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        VUserMember GetUserById(long id);
    }
}
