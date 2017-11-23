using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using StudentForum.Models;

namespace StudentForum.DAL
{
    public class ForumContext : DbContext
    {
        public ForumContext() : base("ForumContext")
        {
        }

        public DbSet<Thread> Threads { get; set; }
        public DbSet<ApplicationUser> Users { get; set; }
        public DbSet<Comment> Comments { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}