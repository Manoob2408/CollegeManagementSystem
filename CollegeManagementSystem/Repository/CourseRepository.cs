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
    }
}
