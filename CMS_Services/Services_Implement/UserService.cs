using CMS_Services.Services_Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using CMS_VModels.User;
using CMS_DAL;

namespace CMS_Services.Services_Implement
{
    /// <summary>
    /// 用户操作实现
    /// </summary>
    public class UserService : BaseService,IUserService
    {
        public UserService(CMSDbContext context) : base(context)
        {

        }
        public VUserMember GetUserById(long id)
        {
            var user = from userMember in _context.UserMember
                       where userMember.Id == id
                       select new VUserMember
                       {
                           Id = userMember.Id,
                           Name = userMember.Name,
                           CreateTime = userMember.CreateTime,
                           UpdateTime = userMember.UpdateTime,
                           NickName = userMember.NickName,
                           IsActive = userMember.IsActive,
                       };
            return user.FirstOrDefault();
        }
    }
}