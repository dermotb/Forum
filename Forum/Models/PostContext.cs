using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Forum.Models
{
    public class PostContext : DbContext
    {
        private const string connectionString = "Server=(localdb)\\mssqllocaldb;Database=Forum1; AttachDbFileName=c:\\temp\\Forum1.mdf;Trusted_Connection=False;";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }

        public DbSet<userPost> Posts { get; set; }
    }
}
