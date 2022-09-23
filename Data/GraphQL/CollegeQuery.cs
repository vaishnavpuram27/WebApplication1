using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQL;
using GraphQL.Types;
using WebApplication1.Data.GraphQL.Types;
using WebApplication1.Repository;

namespace WebApplication1.Data.GraphQL
{
    public class CollegeQuery:ObjectGraphType
    {
        public CollegeQuery(StudentRepository studentRepository)
        {
            Field<ListGraphType<StudentType>>(
                "students",
                resolve: context => studentRepository.GetStudents()
                );
            Field<StudentType>(
                "studentByID",
                arguments: new QueryArguments(new QueryArgument<NonNullGraphType<IntGraphType>> { Name = "studentId" }),
                resolve: context =>
                {
                    var studentId = context.GetArgument<int>("studentId");
                    return studentRepository.GetStudentsById(studentId);
                }
                );
        }
    }
}
