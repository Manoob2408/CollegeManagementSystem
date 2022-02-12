using CollegeManagementSystem.Models;
using CollegeManagementSystem.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeManagementSystem.Controllers
{
    public class CourseController : Controller
    {
        private readonly ICourseRepository _courseRepository;
        public CourseController(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }

        //Return Index view
        public IActionResult IndexCourse()
        {
            List<Course> courses = _courseRepository.ListAllCourses();

            return View(courses);
        }

        public IActionResult CreateCourse()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateCourse(Course course)
        {
            _courseRepository.AddCourse(course);
            return RedirectToAction("IndexCourse");
        }

        public IActionResult EditCourse()
        {
            return View();
        }

        public IActionResult DeleteCourse()
        {
            return View();
        }
    }
}
