using CollegeManagementSystem.Data;
using CollegeManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeManagementSystem.Repository
{
    public class TeacherRepository : ITeacherRepository
    {
        private readonly DataBaseContext _dataBaseContext;

        public TeacherRepository(DataBaseContext dataBaseContext)
        {
            _dataBaseContext = dataBaseContext;
        }
        public Teacher AddTeacher(Teacher teacher)
        {
            _dataBaseContext.Teacher.Add(teacher);
            _dataBaseContext.SaveChanges();
            return teacher;
        }

        public List<Teacher> ListAllTeachers()
        {
            return _dataBaseContext.Teacher.ToList();
        }
    }
}
