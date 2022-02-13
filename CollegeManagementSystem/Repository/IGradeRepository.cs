using CollegeManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeManagementSystem.Repository
{
    public interface IGradeRepository
    {
        Grade AddGrade(Grade grade);
        List<Grade> ListAllGrades();
        Grade ListById(int id);
    }
}
