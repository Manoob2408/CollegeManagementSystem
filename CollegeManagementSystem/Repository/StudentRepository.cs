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

        public Student ListById(int id)
        {
            return _dataBaseContext.Student.FirstOrDefault(x => x.Id == id);
        }

        public Student ModifyStudent(Student student)
        {
            Student studentDB = ListById(student.Id);

            if (studentDB == null) throw new Exception("There was an error during student update!");

            studentDB.name = student.name;
            studentDB.registrationNumber = student.registrationNumber;
            studentDB.birthday = student.birthday;

            _dataBaseContext.Student.Update(studentDB);
            _dataBaseContext.SaveChanges();

            return student;
        }

        public bool DeleteStudent(int id)
        {
            Student studentDB = ListById(id);

            if (studentDB == null) throw new Exception("There was an error during student exclusion!");

            _dataBaseContext.Student.Remove(studentDB);
            _dataBaseContext.SaveChanges();

            return true;

        }

    }
}
