using CollegeManagementSystem.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeManagementSystem.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using(var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<DataBaseContext>();
                context.Database.EnsureCreated();

                //Courses
                if (!context.Courses.Any())
                {
                    context.Courses.AddRange(new List<Course>()
                    {
                        new Course()
                        {
                            name = "Software Engineering"
                        },

                        new Course()
                        {
                            name = "Civil Engineering"
                        },

                        new Course()
                        {
                            name = "Human Resources Management"
                        }
                    });
                    context.SaveChanges();
                }     
                //Subjects
                if(!context.Subjects.Any())
                {
                    context.Subjects.AddRange(new List<Subject>()
                    {
                        new Subject()
                        {
                            name = "Web Development"
                        },
                        new Subject()
                        {
                            name = "Calculus III"
                        },
                        new Subject()
                        {
                            name = "Human Psyche"
                        }
                    });
                    context.SaveChanges();
                }
                //Students
                if(!context.Student.Any())
                {
                    context.Student.AddRange(new List<Student>()
                    {
                        new Student
                        {
                            registrationNumber = 22001,
                            name = "João D'Avila",
                            birthday = DateTime.Parse("12/03/2001")
                        },

                        new Student
                        {
                            registrationNumber = 22002,
                            name = "Maria Dolores",
                            birthday = DateTime.Parse("14/05/2000")
                        },

                        new Student
                        {
                            registrationNumber = 22003,
                            name = "Matthew Smith",
                            birthday = DateTime.Parse("15/08/1999")
                        }
                    });
                    context.SaveChanges();
                }
                //Teachers
                if(!context.Teacher.Any())
                {
                    context.Teacher.AddRange(new List<Teacher>()
                    {
                        new Teacher
                        {
                            name = "Elizabeth First",
                            birthday = DateTime.Parse("18/09/1960"),
                            salary = 3000
                        },

                        new Teacher
                        {
                            name = "Mark Smith",
                            birthday = DateTime.Parse("04/07/1973"),
                            salary = 2000
                        },

                        new Teacher
                        {
                            name = "Michael Jackson",
                            birthday = DateTime.Parse("05/04/1986"),
                            salary = 1550
                        }
                    });
                    context.SaveChanges();
                }
            }
        }
    }
}
