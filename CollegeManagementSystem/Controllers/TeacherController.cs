using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeManagementSystem.Controllers
{
    public class TeacherController : Controller
    {
        public IActionResult IndexTeacher()
        {
            return View();
        }

        public IActionResult CreateTeacher()
        {
            return View();
        }

        public IActionResult EditTeacher()
        {
            return View();
        }

        public IActionResult DeleteTeacher()
        {
            return View();
        }
    }
}
