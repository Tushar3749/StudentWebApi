using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentWebApp.DataContext;
using StudentWebApp.Models;
using StudentWebApp.Service.Interface;

namespace StudentWebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        protected readonly IStudent student;
        public StudentsController(IStudent student)
        {
            this.student = student;
        }

        [HttpGet]
        public List<Student> GetAllStudent()
        {
            return this.student.getAllStudents();
             
        }
      
        [HttpPost]
        public void  Create(Student student)
        {
            this.student.AddStudent(student);
        }

        [HttpPut]
        public bool Update(int id, Student student)
        {

            //var getStudent = _studentDbContext.Students.FirstOrDefault(x => x.Id == id);

            //Student getStudent = _studentDbContext.Students.FirstOrDefault(x => x.Id == id);

            //getStudent.FirstName = student.FirstName;
            //getStudent.LastName = student.LastName;
            //getStudent.Age = student.Age;


            //_studentDbContext.Entry(getStudent).State = EntityState.Modified;
            //_studentDbContext.SaveChanges();

            return true;
        }

        //public Student GetStudentById(int id)
        //{
        //    Student student = _studentDbContext.Students.FirstOrDefault(x => x.Id == id);

        //    return student;
        //}

        /////////////

        [HttpDelete]
        public bool DeleteStudentByID(int id)
        {
            this.student.deleteStudent(id);
            return true;

        }







    }
}
