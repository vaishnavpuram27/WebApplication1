using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Data.Entities;

namespace WebApplication1.Data.GraphQL.Types
{
    public class StudentType:ObjectGraphType<StudentEntity>
    {
        public StudentType()
        {
            Field(t => t.studentId);
            Field(t => t.studentName);

        }
    }
}
