using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student.program
{
    public class student
    {
        public string name;
        public int age;
        public string studentID;
        public string gender;
        public student(string name, int age, string studentID, string gender)
        {
            this.name = name;
            this.age = age;
            this.studentID = studentID;
            this.gender = gender;
        }

        public override string ToString()
        {
            return $"Name: {name}, Age: {age}, Student ID: {studentID}, Gender: {gender}";
        }
        public string GetName()
        {
            return name;
        }
        public int GetAge()
        {
            return age;
        }
        public string GetStudentID()
        {
            return studentID;
        }
        public string GetGender()
        {
            return gender;
        }
    }

    
}
