using CollegeManagementSystem.Models;
using CollegeManagementSystem.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeManagementSystem.Controllers
{
    public class TeacherController : Controller
    {
        private readonly ITeacherRepository _teacherRepository;

        public TeacherController(ITeacherRepository teacherRepository)
        {
            _teacherRepository = teacherRepository;
        }
        public IActionResult IndexTeacher()
        {
            List<Teacher> teachers = _teacherRepository.ListAllTeachers();
            return View(teachers);
        }

        public IActionResult CreateTeacher()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateTeacher(Teacher teacher)
        {
            _teacherRepository.AddTeacher(teacher);
            return RedirectToAction("IndexTeacher");
        }

        [HttpPost]
        public IActionResult ModifyTeacher(Teacher teacher)
        {
            _teacherRepository.ModifyTeacher(teacher);
            return RedirectToAction("IndexTeacher");
        }

        public IActionResult EditTeacher(int id)
        {
            Teacher teacher = _teacherRepository.ListById(id);
            return View(teacher);
        }

        public IActionResult DeleteTeacher(int id)
        {
            Teacher teacher = _teacherRepository.ListById(id);
            return View(teacher);
        }
    }
}
