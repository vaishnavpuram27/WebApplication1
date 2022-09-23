using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Data.Entities;

namespace WebApplication1.Data
{
    public static class InitialData
    {
        public static void Seed(this CollegeDbContext dbContext)
        {
            if (!dbContext.StudentEntities.Any())
            {
                dbContext.StudentEntities.Add(new StudentEntity
                {
                    
                    studentName = "Jack"
                });
                dbContext.StudentEntities.Add(new StudentEntity
                {
                    studentName = "John"
                });
                dbContext.StudentEntities.Add(new StudentEntity
                {
                    studentName = "Josh"
                });
                dbContext.SaveChanges();
            }
        }
    }
}
