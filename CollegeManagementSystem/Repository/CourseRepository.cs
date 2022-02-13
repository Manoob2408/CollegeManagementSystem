using CollegeManagementSystem.Data;
using CollegeManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeManagementSystem.Repository
{
    public class CourseRepository : ICourseRepository
    {
        private readonly DataBaseContext _dataBaseContext;
        public CourseRepository(DataBaseContext dataBaseContext)
        {
            _dataBaseContext = dataBaseContext;
        }
        public Course AddCourse(Course course)
        {
            _dataBaseContext.Courses.Add(course);
            _dataBaseContext.SaveChanges();
            return course;
        }

        public List<Course> ListAllCourses()
        {
            return _dataBaseContext.Courses.ToList();
        }

        public Course ListById(int id)
        {
            return _dataBaseContext.Courses.FirstOrDefault(x => x.Id == id);
        }

        public Course ModifyCourse(Course course)
        {
            Course courseDB = ListById(course.Id);

            if (courseDB == null) throw new Exception("There was an error during course update!");

            courseDB.name = course.name;

            _dataBaseContext.Courses.Update(courseDB);
            _dataBaseContext.SaveChanges();

            return course;

        }

        public bool DeleteCourse(int id)
        {
            Course courseDB = ListById(id);

            if (courseDB == null) throw new Exception("There was an error during course exclusion!");

            _dataBaseContext.Courses.Remove(courseDB);
            _dataBaseContext.SaveChanges();

            return true;
        }
    }
}
