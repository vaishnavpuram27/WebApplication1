using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Data.Entities;

namespace WebApplication1.Data
{
    public class CollegeDbContext:DbContext
    {
        public CollegeDbContext(DbContextOptions<CollegeDbContext> options):  base(options)
        {
            this.Database.EnsureCreated();
        }
        public DbSet<StudentEntity> StudentEntities { get; set; }
    }
}
