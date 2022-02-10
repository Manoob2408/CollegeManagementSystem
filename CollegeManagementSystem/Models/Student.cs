using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeManagementSystem.Models
{
    public class Student
    {
        public int Id { get; set;}
        public int registrationNumber { get; set; }
        public String name { get; set; }
        public DateTime birthday { get; set; }
    }
}
