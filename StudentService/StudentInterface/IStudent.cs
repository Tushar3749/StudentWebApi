﻿using StudentWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentService.StudentInterface
{
    public interface IStudent
    {
        List<Student> GetStudentsList();
        //bool AddStudent(Student student);
        //bool EditStudent(Student student, int id);
        //bool DeleteStudent(int id);
    }
}
