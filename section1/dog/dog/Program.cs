using homework1.Dog;

public class Program
{
    public static void Main(string[] args)
    {
        Dog dog1 = new Dog("Buddy", "Golden Retriever", 3, "Golden", "Max");
        Dog dog2 = new Dog("Max", "German Shepherd", 5, "Black and Tan", "Simmy");
        Dog dog3 = new Dog("Bella", "Labrador Retriever", 2, "Chocolate", "John");
        Console.WriteLine("Dog 1: ");
        Console.WriteLine(dog1.ToString());
        Console.WriteLine();
        Console.WriteLine("Dog 2: ");
        Console.WriteLine("Name: " + dog2.GetName());
        Console.WriteLine("Breed: " + dog2.GetBreed());
        Console.WriteLine("Age: " + dog2.GetAge());
        Console.WriteLine();
        Console.WriteLine("Dog 3: ");
        Console.WriteLine("Color: " + dog3.GetColor());
        Console.WriteLine("Owner: " + dog3.GetOwner());
    }
}