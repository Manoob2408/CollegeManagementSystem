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

        public Subject ListById(int id)
        {
            return _dataBaseContext.Subjects.FirstOrDefault(x => x.Id == id);
        }

        public Subject ModifySubject(Subject subject)
        {
            Subject subjectDB = ListById(subject.Id);

            if (subjectDB == null) throw new Exception("There was an error during subject update!");

            subjectDB.name = subject.name;

            _dataBaseContext.Subjects.Update(subjectDB);
            _dataBaseContext.SaveChanges();

            return subject;
        }

        public bool DeleteSubject(int id)
        {
            Subject subjectDB = ListById(id);

            if (subjectDB == null) throw new Exception("There was an error during subject exclusion!");

            _dataBaseContext.Subjects.Remove(subjectDB);
            _dataBaseContext.SaveChanges();

            return true;
        }

    }
}
