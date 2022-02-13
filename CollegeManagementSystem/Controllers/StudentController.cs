using CollegeManagementSystem.Models;
using CollegeManagementSystem.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeManagementSystem.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudentRepository _studentRepository;

        public StudentController(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }
        public IActionResult IndexStudent()
        {
            List<Student> students = _studentRepository.ListAllStudents();

            return View(students);
        }

        public IActionResult CreateStudent()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateStudent(Student student)
        {
            _studentRepository.AddStudent(student);
            return RedirectToAction("IndexStudent");
        }

        [HttpPost]
        public IActionResult ModifyStudent(Student student)
        {
            _studentRepository.ModifyStudent(student);
            return RedirectToAction("IndexStudent");
        }

        public IActionResult EditStudent(int id)
        {
            Student student = _studentRepository.ListById(id);
            return View(student);
        }

        public IActionResult DeleteStudent(int id)
        {
            Student student = _studentRepository.ListById(id);
            return View(student);
        }

        public IActionResult StudentExclusion(int id)
        {
            _studentRepository.DeleteStudent(id);
            return RedirectToAction("IndexStudent");
        }
    }
}
