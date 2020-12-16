using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace EFCoreExample
{
   public class AppDbContext : DbContext
    {

        string DbPath = string.Empty;

        public AppDbContext(string nameDB)
        {
            string DbPath = DependencyService.Get<IConfigDataBase>().GetFullPath("nameDB");
            this.DbPath = DbPath;
        }


        /// <summary>
        /// Posts and People will be DB
        /// </summary>
        public DbSet<Post> Posts { get; set; }
        public DbSet<Person> People { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Filename={DbPath}");
        }


    }
}
