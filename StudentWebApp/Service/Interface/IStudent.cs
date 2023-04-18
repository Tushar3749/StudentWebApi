using StudentWebApp.Models;

namespace StudentWebApp.Service.Interface
{
    public interface IStudent
    {
        List<Student> getAllStudents();
        bool AddStudent(Student student);
        //bool UpdateStudent(int id, Student student);
        bool deleteStudent(int id);


    }
}
