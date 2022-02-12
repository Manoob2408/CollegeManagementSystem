using CollegeManagementSystem.Data;
using CollegeManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeManagementSystem.Repository
{
    public class StudentRepository : IStudentRepository
    {
        private readonly DataBaseContext _dataBaseContext;

        public StudentRepository(DataBaseContext dataBaseContext)
        {
            _dataBaseContext = dataBaseContext;
        }
        public Student AddStudent(Student student)
        {
            _dataBaseContext.Student.Add(student);
            _dataBaseContext.SaveChanges();
            return student;
        }

        public List<Student> ListAllStudents()
        {
            return _dataBaseContext.Student.ToList();
        }
    }
}
