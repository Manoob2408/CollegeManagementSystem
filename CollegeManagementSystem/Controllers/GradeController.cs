using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeManagementSystem.Controllers
{
    public class GradeController : Controller
    {
        public IActionResult IndexGrade()
        {
            return View();
        }

        public IActionResult CreateGrade()
        {
            return View();
        }

        public IActionResult EditGrade()
        {
            return View();
        }

        public IActionResult DeleteGrade()
        {
            return View();
        }
    }
}
