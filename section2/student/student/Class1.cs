using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Student
    {
        private string name;
        private double score;
        private static int totalStudets = 0;

        public Student(string name, double score)
        {
            this.name = name;
            this.score = score;
            totalStudets++;
        }
        public string GetName()
        {
            return name;
        }
        public double GetScore()
        {
            return score;
        }
        public bool IsPassed()
        {
            if (score >= 5) return true;
            else return false;
        }
        public string GetClassification()
        {
            if (score >= 8) return "Excellent";
            else if (score >= 6.5) return "Good";
            else if (score >= 5.0) return "Average";
            else return "Weak";
        }
        public static int GetTotalStudents()
        {
            return totalStudets;
        }
        public static Student FindTopStudent(Student[] students)
        {
            int pos = 0;
            for (int i = 1; i < students.Length; i++)
            {
                if (students[i].score > students[pos].score) pos = i;
            }
            return students[pos];
        }

        public static double CalculateAverageScore(Student[] students)
        {
            int total = students.Length;
            double sum = 0;
            foreach (Student student in students)
            {
                sum += student.score;
            }
            return sum / total;
        }
    }
    

}
