using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EynarHajiTask.Data
{
    public class UserDBContext:DbContext
    {
        public UserDBContext(DbContextOptions opt) : base(opt) { }
        public DbSet<User> Users { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Transaction>().Property(x => x.CreatedAt).HasDefaultValue(DateTime.Now);
            base.OnModelCreating(modelBuilder);
        }
    }
}
