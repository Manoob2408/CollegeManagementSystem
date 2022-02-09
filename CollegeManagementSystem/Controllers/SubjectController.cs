using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeManagementSystem.Controllers
{
    public class SubjectController : Controller
    {
        public IActionResult IndexSubject()
        {
            return View();
        }

        public IActionResult CreateSubject()
        {
            return View();
        }

        public IActionResult EditSubject()
        {
            return View();
        }

        public IActionResult DeleteSubject()
        {
            return View();
        }
    }
}
