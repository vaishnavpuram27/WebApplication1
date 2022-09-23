using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Data;
using WebApplication1.Data.Entities;
using WebApplication1.Repository;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
       /* List<StudentClass> students = new List<StudentClass>
            {
                new StudentClass{studentName="Jake", studentId=1},
                new StudentClass{studentName="Josh", studentId=2},
                new StudentClass{studentName="Jack", studentId=3},


            };*/

        //private readonly CollegeDbContext students;
        public StudentRepository _repo;
        /*public StudentController(CollegeDbContext context)
        {
            this._students = context;
        }*/
        public StudentController(StudentRepository repo)
        {
            this._repo = repo;
        }
        //------------------------------------------------USING REPOSITORY----------------
        [HttpGet]
        public IEnumerable<StudentEntity> Get()
        {
            return this._repo.GetStudents();
        }
        // GET: api/<ValuesController>
        /*[HttpGet]
        public IEnumerable<StudentClass> Get()
        {
            return students;
        }*/
        //---------------------------------------------------USING ENTITIES-------------------------------------
        /*[HttpGet]
        public IEnumerable<StudentEntity> Get()
        {
            return _students.StudentEntities;
        }*/
        // GET api/<ValuesController>/5
        /* [HttpGet("{id}")]
         public StudentEntity Get(int id)
         {
             return _students.StudentEntities.First(e=> e.studentId == id);
         }
         *//*public int Get(int id)
         {
             //return students.Where(s=>s.studentAge>age);
             return students.IndexOf(students.First(s => s.studentId == id));
         }*//*

         // POST api/<ValuesController>
         [HttpPost]
         public string Post(StudentEntity s)
         {
             this._students.StudentEntities.Add(s);
             this._students.SaveChanges();
             return "Student Added into the database";
         }
         *//*public IEnumerable<StudentClass> Post(StudentClass s)
         {
              this.students.Add(s);
             return this.students;
         }*//*

         // PUT api/<ValuesController>/5
         [HttpPut("{id}")]
         public string Put(int id, StudentEntity value)
         {
             var index = _students.StudentEntities.First(s => s.studentId == id);
             index.studentName = value.studentName;
             this._students.SaveChanges();
             return "Just done the put request";
         }

         [HttpPatch("{id}")]
         public string Patch(int id, StudentEntity value)
         {
             var index = _students.StudentEntities.First(s => s.studentId == id);
             index.studentName = value.studentName;
             this._students.SaveChanges();
             return "Just done the patch request";
         }
         *//*public IEnumerable<StudentClass> Patch(int id, StudentClass s)
         {
             var index = students.IndexOf(students.First(s => s.studentId == id));
             students[index].studentName = s.studentName;
             return this.students;
         }*//*

         // DELETE api/<ValuesController>/5
         [HttpDelete("{id}")]
         public string Delete(int id)
         {
             var index = _students.StudentEntities.First(s => s.studentId == id);
             string delName = index.studentName;
             _students.StudentEntities.Remove(index);
             this._students.SaveChanges();
             return $"{delName} deleted successfully";

         }
         *//*public string Delete(int id)
         {    
             var index = students.IndexOf(students.First(s => s.studentId == id));
             students.RemoveAt(index);
             return "deleted successfully";

         }*/
    }
}
