using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeManagementSystem.Models
{
    public class Grade
    {

        public int Id { get; set; }
        public Student student { get; set; }
        public Course course { get; set; }
        public Subject subject { get; set; }
        public Teacher teacher { get; set; }
        public double grade { get; set; }

    }
}
