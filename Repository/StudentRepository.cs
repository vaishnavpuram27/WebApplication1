using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Data;
using WebApplication1.Data.Entities;


namespace WebApplication1.Repository
{
    public class StudentRepository
    {
        public CollegeDbContext _dbContext;
        public StudentRepository(CollegeDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IEnumerable<StudentEntity> GetStudents()
        {
            return _dbContext.StudentEntities;
        }
        public StudentEntity GetStudentsById(int studentId)
        {
            return _dbContext.StudentEntities.First(e => e.studentId == studentId);
        }
    }
}
