using CollegeManagementSystem.Data;
using CollegeManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeManagementSystem.Repository
{
    public class SubjectRepository : ISubjectRepository
    {
        private readonly DataBaseContext _dataBaseContext;

        public SubjectRepository(DataBaseContext dataBaseContext)
        {
            _dataBaseContext = dataBaseContext;
        }

        public Subject AddSubject(Subject subject)
        {
            _dataBaseContext.Subjects.Add(subject);
            _dataBaseContext.SaveChanges();
            return subject;
        }

        public List<Subject> ListAllSubjects()
        {
            return _dataBaseContext.Subjects.ToList();
        }
    }
}
