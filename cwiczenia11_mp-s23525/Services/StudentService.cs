using System;
using System.Collections.Generic;
using System.Linq;
using cwiczenia11_mp_s23525.Services;
using cwiczenia11_mp_s23525.Models;

namespace cwiczenia11_mp_s23525.Services
{
    public class StudentService : IStudentService
    {
        public List<Student> Students {get; set;}
        
        public StudentService()
        {
            Students = new List<Student>()
            {
                new Student
                {
                    IdStudent = 1,
                    FirstName = "Jan",
                    LastName = "Kowalski",
                    Avatar = "https://gravatar.com/avatar/d1fbfefa907126a91cbac24fba73657c?s=400&d=robohash&r=x",
                    Birthdate = DateTime.Parse("2000-01-01"),
                    Studies = "Informatyka"
                },
                new Student
                {
                    IdStudent = 2,
                    FirstName = "Adam",
                    LastName = "Nowak",
                    Avatar = "https://cdn-icons-png.flaticon.com/512/606/606587.png",
                    Birthdate = DateTime.Parse("2001-01-01"),
                    Studies = "Informatyka"
                },
                new Student
                {
                    IdStudent = 3,
                    FirstName = "Anna",
                    LastName = "Kowalska",
                    Avatar = "https://cdn-icons-png.flaticon.com/512/606/606587.png",
                    Birthdate = DateTime.Parse("2002-01-01"),
                    Studies = "SNM"
                }
            };
        }
        public void DeleteStudent(int IdStudent)
        {
            Students.Remove(GetStudent(IdStudent));
        }

        public Student GetStudent(int IdStudent)
        {
           return Students.FirstOrDefault(e => e.IdStudent == IdStudent);
        }

        public IEnumerable<Student> GetStudents()
        {
            return Students;
        }
    }
}