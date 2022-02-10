using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeManagementSystem.Controllers
{
    public class CourseController : Controller
    {
        //Return Index view
        public IActionResult IndexCourse()
        {
            return View();
        }

        public IActionResult CreateCourse()
        {
            return View();
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
