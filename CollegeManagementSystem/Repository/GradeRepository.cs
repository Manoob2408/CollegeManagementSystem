using CollegeManagementSystem.Data;
using CollegeManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeManagementSystem.Repository
{
    public class GradeRepository : IGradeRepository
    {
        private readonly DataBaseContext _dataBaseContext;

        public GradeRepository(DataBaseContext dataBaseContext)
        {
            _dataBaseContext = dataBaseContext;
        }
        public Grade AddGrade(Grade grade)
        {
            _dataBaseContext.Grades.Add(grade);
            _dataBaseContext.SaveChanges();
            return grade;
        }

        public List<Grade> ListAllGrades()
        {
            return _dataBaseContext.Grades.ToList();
        }

        public Grade ListById(int id)
        {
            return _dataBaseContext.Grades.FirstOrDefault(x => x.Id == id);
        }

        public Grade ModifyGrade(Grade grade)
        {
            Grade gradeDB = ListById(grade.Id);

            if (grade == null) throw new Exception("There was an error during grade update!");

            gradeDB.student = grade.student;
            gradeDB.course = grade.course;
            gradeDB.subject = grade.subject;
            gradeDB.teacher = grade.teacher;
            gradeDB.record = grade.record;

            _dataBaseContext.Grades.Update(gradeDB);
            _dataBaseContext.SaveChanges();

            return grade;
        }
    }
}
