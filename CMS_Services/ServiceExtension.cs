using CMS_DAL;
using CMS_Services.Services_Implement;
using CMS_Services.Services_Interface;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace CMS_Services
{
    /// <summary>
    /// ASP.Net Core 的IServiceCollection扩展
    /// </summary>
    public static class ServiceExtension
    {
        /// <summary>
        /// 注册数据库上下文
        /// </summary>
        /// <param name="services"></param>
        /// <param name="connection_string"></param>
        public static void RegisterDBContext(this IServiceCollection services, string connection_string)
        {
            services.AddDbContext<CMSDbContext>(options =>
            {
                options.UseSqlServer(connection_string);
            });
            services.BuildServiceProvider().GetRequiredService<CMSDbContext>().Database.EnsureCreatedAsync();
        }


        public static void RegisterService(this IServiceCollection services)
        {
            services.AddTransient<IUserService, UserService>();
        }

        

    }
}