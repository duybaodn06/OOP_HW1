using ConsoleApp1;

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
        Student[] listStudent = { s1, s2, s3, s4, s5 };
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