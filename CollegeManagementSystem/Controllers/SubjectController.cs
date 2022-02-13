using CollegeManagementSystem.Models;
using CollegeManagementSystem.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeManagementSystem.Controllers
{
    public class SubjectController : Controller
    {
        private readonly ISubjectRepository _subjectRepository;

        public SubjectController(ISubjectRepository subjectRepository)
        {
            _subjectRepository = subjectRepository;
        }

        public IActionResult IndexSubject()
        {
            List<Subject> subjects = _subjectRepository.ListAllSubjects();
            return View(subjects);
        }

        public IActionResult CreateSubject()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateSubject(Subject subject)
        {
            _subjectRepository.AddSubject(subject);
            return RedirectToAction("IndexSubject");
        }

        public IActionResult EditSubject(int id)
        {
            Subject subject = _subjectRepository.ListById(id);
            return View(subject);
        }

        public IActionResult DeleteSubject()
        {
            return View();
        }
    }
}
