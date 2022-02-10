using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeManagementSystem.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        public String name { get; set; }
        public DateTime birthday { get; set; }
        public double salary { get; set; }
    }
}
