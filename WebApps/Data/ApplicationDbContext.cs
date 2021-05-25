using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebApps.Models;

namespace WebApps.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        //App 03 : Student Grades
        public DbSet<Student> Students { get; set; }

        //App 04 : 
        public DbSet<Post> Posts { get; set; }
        public DbSet<MessagePost> Messages { get; set; }
        public DbSet<PhotoPost> Photos { get; set; }
        public DbSet<Comment> Comments { get; set; }
    }
}
