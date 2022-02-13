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

        public Teacher ListById(int id)
        {
            return _dataBaseContext.Teacher.FirstOrDefault(x => x.Id == id);
        }

        public Teacher ModifyTeacher(Teacher teacher)
        {
            Teacher teacherDB = ListById(teacher.Id);

            if (teacherDB == null) throw new Exception("There was an error during teacher update!");

            teacherDB.name = teacher.name;
            teacherDB.birthday = teacher.birthday;
            teacherDB.salary = teacher.salary;

            _dataBaseContext.Teacher.Update(teacherDB);
            _dataBaseContext.SaveChanges();

            return teacher;

        }

        public bool DeleteTeacher(int id)
        {
            Teacher teacherDB = ListById(id);

            if (teacherDB == null) throw new Exception("There was an error during teacher exclusion!");

            _dataBaseContext.Teacher.Remove(teacherDB);
            _dataBaseContext.SaveChanges();

            return true;

        }
    }
}
