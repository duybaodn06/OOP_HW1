using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.session05.StudentManagement
{
    internal class StudentManagement
    {
        static void Main(string[] args)
        {
            // Create some subjects
            Subject math = new Subject("MATH101", "Mathematics", 3);
            Subject physics = new Subject("PHYS101", "Physics", 4);
            Subject chemistry = new Subject("CHEM101", "Chemistry", 3);
            // Create some students
            Student student1 = new Student("S001", "Alice", "C001");
            Student student2 = new Student("S002", "Bob", "C002");
            Student student3 = new Student("S003", "Charlie", "C001");
            Student student4 = new Student("S004", "David", "C002");
            Student student5 = new Student("S005", "Eve", "C001");
            Student student6 = new Student("S006", "Frank", "C002");
            Student student7 = new Student("S007", "Grace", "C001");
            Student student8 = new Student("S008", "Hannah", "C002");
            Student student9 = new Student("S009", "Ivy", "C001");
            Student student10 = new Student("S010", "Jack", "C002");
            // Create some classes
            Classes class1 = new Classes("C001", "Class 1");
            Classes class2 = new Classes("C002", "Class 2");
            // Add subjects 
            StudentSubject record1 = new StudentSubject("S001", "MATH101", 9);
            StudentSubject record2 = new StudentSubject("S001", "PHYS101", 8);
            StudentSubject record3 = new StudentSubject("S001", "CHEM101", 7);
            StudentSubject record4 = new StudentSubject("S002", "MATH101", 5);
            StudentSubject record5 = new StudentSubject("S002", "PHYS101", 4);
            StudentSubject record6 = new StudentSubject("S002", "CHEM101", 1);
            // Student 3 (Charlie)
            StudentSubject record7 = new StudentSubject("S003", "MATH101", 8);
            StudentSubject record8 = new StudentSubject("S003", "PHYS101", 9);
            StudentSubject record9 = new StudentSubject("S003", "CHEM101", 8);

            // Student 4 (David)
            StudentSubject record10 = new StudentSubject("S004", "MATH101", 6);
            StudentSubject record11 = new StudentSubject("S004", "PHYS101", 7);
            StudentSubject record12 = new StudentSubject("S004", "CHEM101", 5);

            // Student 5 (Eve)
            StudentSubject record13 = new StudentSubject("S005", "MATH101", 10);
            StudentSubject record14 = new StudentSubject("S005", "PHYS101", 9);
            StudentSubject record15 = new StudentSubject("S005", "CHEM101", 10);

            // Student 6 (Frank)
            StudentSubject record16 = new StudentSubject("S006", "MATH101", 4);
            StudentSubject record17 = new StudentSubject("S006", "PHYS101", 5);
            StudentSubject record18 = new StudentSubject("S006", "CHEM101", 6);

            // Student 7 (Grace)
            StudentSubject record19 = new StudentSubject("S007", "MATH101", 7);
            StudentSubject record20 = new StudentSubject("S007", "PHYS101", 8);
            StudentSubject record21 = new StudentSubject("S007", "CHEM101", 9);

            // Student 8 (Hannah)
            StudentSubject record22 = new StudentSubject("S008", "MATH101", 9);
            StudentSubject record23 = new StudentSubject("S008", "PHYS101", 6);
            StudentSubject record24 = new StudentSubject("S008", "CHEM101", 7);

            // Student 9 (Ivy)
            StudentSubject record25 = new StudentSubject("S009", "MATH101", 8);
            StudentSubject record26 = new StudentSubject("S009", "PHYS101", 8);
            StudentSubject record27 = new StudentSubject("S009", "CHEM101", 8);

            // Student 10 (Jack)
            StudentSubject record28 = new StudentSubject("S010", "MATH101", 3);
            StudentSubject record29 = new StudentSubject("S010", "PHYS101", 5);
            StudentSubject record30 = new StudentSubject("S010", "CHEM101", 4);

            Console.WriteLine("Student Management System");
            Console.WriteLine("-------------------------");
            Console.WriteLine("Students:");
            Console.WriteLine(student1);
            Console.WriteLine(student2);
            Console.WriteLine(student3);
            Console.WriteLine(student4);
            Console.WriteLine(student5);
            Console.WriteLine(student6);
            Console.WriteLine(student7);
            Console.WriteLine(student8);
            Console.WriteLine(student9);
            Console.WriteLine(student10);



        }
    }
}
