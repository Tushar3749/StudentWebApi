using StudentWebApp.DataContext;
using StudentWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentService.StudentService
{
    public class StudentService: StudentInterface
    {
        private readonly StudentDbContext _studentDbContext;
        public StudentService(StudentDbContext studentDbContext)
        {
            _studentDbContext = studentDbContext;
        }

        public List<Student> GetStudentsList()
        {
            return _studentDbContext.Students.ToList();
        }























        //public bool AddStudent(Student student)
        //{
        //    return true;
        //}
        //public bool EditStudent(Student student, int id)
        //{
        //    return true;
        //}
        //public bool DeleteStudent(int id)
        //{
        //    return true;
        //}
    }
}
