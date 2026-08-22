using Student.program;

public class Program
{
    static void Main(string[] args)
    {
        student student1 = new student("John Doe", 20, "S12345", "Male");
        Console.WriteLine(student1.ToString());
        Console.WriteLine($"Name: {student1.GetName()}, Age: {student1.GetAge()}, Student ID: {student1.GetStudentID()}, Gender: {student1.GetGender()}");
    }
}