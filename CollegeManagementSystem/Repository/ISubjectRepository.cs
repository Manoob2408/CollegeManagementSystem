using CollegeManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeManagementSystem.Repository
{
    public interface ISubjectRepository
    {
        Subject AddSubject(Subject subject);
        List<Subject> ListAllSubjects();
        Subject ListById(int id);
        Subject ModifySubject(Subject subject);
    }
}
