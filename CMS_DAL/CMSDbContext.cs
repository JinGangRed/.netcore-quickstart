using CMS_DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CMS_DAL
{
    public class CMSDbContext : DbContext
    {
        public CMSDbContext(DbContextOptions<CMSDbContext> options)
            : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserMember>()
                .HasAlternateKey(user => user.NickName)
                .HasName("Unique key NickName");

            base.OnModelCreating(modelBuilder);
        }


        public virtual DbSet<UserMember> UserMember { set; get; }
        public DbSet<Article> Article { set; get; }
    }
}
