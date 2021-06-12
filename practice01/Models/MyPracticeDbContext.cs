using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace practice01.Models
{
    public class MyPracticeDbContext : DbContext
    {
        public MyPracticeDbContext(DbContextOptions<MyPracticeDbContext> options) : base(options)
        {

        }
        public DbSet<Student> Student { get; set; }
        public DbSet<Address> Address { get; set; }
    }
}
