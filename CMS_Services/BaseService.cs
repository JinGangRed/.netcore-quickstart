using CMS_DAL;
using System;
using System.Collections.Generic;
using System.Text;

namespace CMS_Services
{
    public class BaseService
    {
        protected readonly CMSDbContext _context;

        public BaseService(CMSDbContext context)
        {
            _context = context;
        }

    }
}
