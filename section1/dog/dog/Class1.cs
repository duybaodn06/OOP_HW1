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

}


