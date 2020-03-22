using System;
using Microsoft.EntityFrameworkCore;

namespace QuickStart.Models
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Book> Book { get; set; }
    }
}