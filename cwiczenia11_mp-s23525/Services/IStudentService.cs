using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using cwiczenia11_mp_s23525.Models;

namespace cwiczenia11_mp_s23525.Services
{
    public interface IStudentService
    {
        IEnumerable<Student> GetStudents();
        void DeleteStudent(int IdStudent);
        Student GetStudent(int IdStudent);
    }
}