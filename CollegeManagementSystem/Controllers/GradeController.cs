using CollegeManagementSystem.Models;
using CollegeManagementSystem.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeManagementSystem.Controllers
{
    public class GradeController : Controller
    {
        private readonly IGradeRepository _gradeRepository;

        public GradeController(IGradeRepository gradeRepository)
        {
            _gradeRepository = gradeRepository;
        }
        public IActionResult IndexGrade()
        {
            List<Grade> grades = _gradeRepository.ListAllGrades();
            return View(grades);
        }

        public IActionResult CreateGrade()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateGrade(Grade grade)
        {
            _gradeRepository.AddGrade(grade);
            return RedirectToAction("IndexGrade");
        }

        [HttpPost]
        public IActionResult ModifyGrade(Grade grade)
        {
            _gradeRepository.ModifyGrade(grade);
            return RedirectToAction("IndexGrade");
        }

        public IActionResult EditGrade(int id)
        {
            Grade grade = _gradeRepository.ListById(id);
            return View(grade);
        }

        public IActionResult DeleteGrade(int id)
        {
            Grade grade = _gradeRepository.ListById(id);
            return View(grade);
        }

        public IActionResult GradeExclusion(int id)
        {
            _gradeRepository.DeleteGrade(id);
            return RedirectToAction("IndexGrade");
        }
    }
}
