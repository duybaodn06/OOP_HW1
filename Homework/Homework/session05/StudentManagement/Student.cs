using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.session05.StudentManagement
{
    internal class Student
    {
        public string StudentId { get; set; }
        public string? StudentName { get; set; }

        public string classId { get; set; }
        public float Gpa { get; }

        public Student(string studentId)
        {
            this.StudentId = studentId;
            this.StudentName = null;
            this.Gpa = 0;
        }
        public Student(string studentId, string studentName) 
        {
            StudentId = studentId;
            StudentName = studentName;
            Gpa = 0;
        }
        public Student(string studentId, string studentName, string classId)
        {
            StudentId = studentId;
            StudentName = studentName;
            this.classId = classId;
            Gpa = 0;
        }

        public void UpdateGpa(float gpa)
        {
            
        }   
        public override bool Equals(object? obj)
        {
            if (obj is not Student) return false;
            return this.StudentId == ((Student)obj).StudentId; //Distinct caps
        }

        public override int GetHashCode()
        {
            return this.StudentId.GetHashCode();
        }

        public override string ToString()
        {
            return $"StudentId: {StudentId}, StudentName: {StudentName}, ClassId: {classId}, Gpa: {Gpa}";
        }
    }
}
