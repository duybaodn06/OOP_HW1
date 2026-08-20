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
    class Program
    {
        static void Main(string[] args)
        {
            //1.Create an array of at least 5 Student objects with different names and scores.
            Student s1 = new Student("Nguyen Van A", 9.5);
            Student s2 = new Student("Tran Thi B", 4.0);
            Student s3 = new Student("Tran Van C", 5.0);
            Student s4 = new Student("Tang Thi D", 10.0);
            Student s5 = new Student("Le Van E", 3.5);

            //2.Print the total number of students created (using the static method).
            Console.WriteLine(Student.GetTotalStudents());

            //3.Print the list of students along with their classification and pass/ fail status(using instance methods).
            Student[] listStudent = {s1, s2, s3, s4, s5};
            Console.WriteLine("List classified students");
            foreach (Student student in listStudent)
            {
                Console.WriteLine($"Name: {student.GetName()}, Classification: {student.GetClassification()}, Status: {student.IsPassed()}");
            }

            //4.Print the top-scoring student (using the static method).
            Student topStudent = Student.FindTopStudent(listStudent);
            Console.WriteLine($"Top student: Name: {topStudent.GetName()}, Score: {topStudent.GetScore()}");

            //5.Print the class average score (using the static method).
            Console.WriteLine($"Average score: {Student.CalculateAverageScore(listStudent)}");
        }
    }

}
