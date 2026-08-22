using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework1.Dog
{
    public class Dog
    {
        private string Name;
        private string Breed;
        private int Age;
        private string Color;
        private string Owner;

        public Dog(string name, string breed, int age, string color, string owner)
        {
            this.Name = name;
            this.Breed = breed;
            this.Age = age;
            this.Color = color;
            this.Owner = owner;
        }
        public string GetName() { return this.Name; }
        public string GetBreed() { return this.Breed; }
        public string GetColor() { return this.Color; }
        public int GetAge() { return this.Age; }

        public override string ToString()
        {
            return $"Name: {this.Name}\nBreed: {this.Breed}\nAge: {this.Age}\nColor: {this.Color}\nOwner: {this.Owner}";
        }

        public string GetOwner()
        {
            return this.Owner;
        }
    }

    public class Program
    {
        public static void Main1(string[] args)
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

}


