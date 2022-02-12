using CollegeManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeManagementSystem.Repository
{
    public interface ITeacherRepository
    {
        Teacher AddTeacher(Teacher teacher);
        List<Teacher> ListAllTeachers();
    }
}
