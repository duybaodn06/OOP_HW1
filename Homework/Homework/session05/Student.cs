using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.session05
{
    internal class Student
    {
        public string StudentId { get; set; }
        public string StudentName { get; set; }
        public string Email { get; set; }

        public float? Gpa { get; }

        public Student(string studentId, string studentName, string email) 
        {
            this.StudentId = studentId;
            this.StudentName = studentName;
            this.Email = email;
            this.Gpa = null;
        }
    }
}
