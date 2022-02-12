using CollegeManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeManagementSystem.Repository
{
    public interface IStudentRepository
    {
        Student AddStudent(Student student);

        List<Student> ListAllStudents();
    }
}
