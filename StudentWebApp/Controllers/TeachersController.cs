using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentWebApp.DataContext;
using StudentWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentWebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeachersController : ControllerBase
    {

        private readonly StudentDbContext studentDbContext;

        public TeachersController(StudentDbContext studentDbContext)
        {

            this.studentDbContext = studentDbContext;

        }

        [HttpGet]
        public List<Teacher> GetAllTeacher()
        {

            return studentDbContext.Teachers.ToList();

        }
        [Route("[action]")]
        [HttpGet]
        public Teacher GetTeacherByID(int id)
        {
             // Student st = 
                return studentDbContext.Teachers.FirstOrDefault(x => x.Id == id);            
        }


        [HttpPost]
        public void CreateTeacher(Teacher teacher) { 
          
            studentDbContext.Teachers.Add(teacher);
            studentDbContext.SaveChanges();
        }


        [HttpPut]
        public bool UpdateTeacher(int id,Teacher teacher) {

            Teacher GetTeacher = studentDbContext.Teachers.FirstOrDefault(x => x.Id == id);
            GetTeacher.Name = teacher.Name;
            GetTeacher.Subject = teacher.Subject;


            studentDbContext.Entry(GetTeacher).State = EntityState.Modified;
            studentDbContext.SaveChanges();

            return true;
         }


        [HttpDelete]
        public bool DeleteTeacherByID(int id) {

            Teacher GetTeacher = studentDbContext.Teachers.FirstOrDefault(x => x.Id == id);
            studentDbContext.Teachers.Remove(GetTeacher);
            studentDbContext.SaveChanges();

            return true;

        }


    }
}
