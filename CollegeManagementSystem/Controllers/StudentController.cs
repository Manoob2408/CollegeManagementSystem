using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeManagementSystem.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult IndexStudent()
        {
            return View();
        }

        public IActionResult CreateStudent()
        {
            return View();
        }

        public IActionResult EditStudent()
        {
            return View();
        }

        public IActionResult DeleteStudent()
        {
            return View();
        }
    }
}
