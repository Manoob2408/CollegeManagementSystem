using CollegeManagementSystem.Models;
using System.Collections.Generic;

namespace CollegeManagementSystem.Repository
{
    public interface ICourseRepository
    {
        List<Course> ListAllCourses();
        Course AddCourse(Course course);
    }
}
