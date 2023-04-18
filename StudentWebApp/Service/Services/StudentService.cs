using StudentWebApp.DataContext;
using StudentWebApp.Models;
using StudentWebApp.Service.Interface;

namespace StudentWebApp.Service.Services
{
    public class StudentService : IStudent
    {
        public readonly StudentDbContext studentDbContext;
        public StudentService(StudentDbContext studentDbContext)
        {
            this.studentDbContext = studentDbContext;
        }
        public bool AddStudent(Student student)
        {
            try
            {
                this.studentDbContext.Students.Add(student);
                this.studentDbContext.SaveChanges();
                return true;
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public bool deleteStudent(int id)
        {
            Student student = GetStudentById(id);

            if (student != null)
            {
                this.studentDbContext.Students.Remove(student);
                return true;
            }
            else
            {
                return false;
            }
        }


        public List<Student> getAllStudents()
        {
            try
            {
                return this.studentDbContext.Students.ToList();
            }
            catch (Exception e)
            {

                throw e;
            }
            
        }




        //public bool UpdateStudent(int id, Student student)
        //{
        //    Student studentData = GetStudentById(id);

        //    studentData.FirstName = student.FirstName;
        //    studentData.LastName = student.LastName;
        //    studentData.Age = student.Age;

            
        //}


        public Student GetStudentById(int id)
        {
            return this.studentDbContext.Students.FirstOrDefault(x => x.Id == id);
        }
    }
}
