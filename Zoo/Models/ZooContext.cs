using System;
using Microsoft.EntityFrameworkCore;

namespace Zoo.Models
{
    public class ZooContext : DbContext
    {
        public ZooContext(DbContextOptions<ZooContext> options)
            : base(options)
        {
        }

        public DbSet<Dog> Dogs { get; set; }
    }
}
