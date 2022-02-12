using CollegeManagementSystem.Models;
using System.Collections.Generic;

namespace CollegeManagementSystem.Repository
{
    public interface ICourseRepository
    {
        
        Course AddCourse(Course course);
        List<Course> ListAllCourses();
    }
}
