using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.session05
{
    internal class Die
    {
        public byte Face { get; private set; }

        public void roll()
        {
            Random rd = new Random();
            Face = (byte)rd.Next(1, 7); 
        }

        public Die() { roll();}

        public override bool Equals(Object? obj)
        {
            if (obj == null) return false;
            return this.Face == ((Die)obj).Face;
        }

        public override int GetHashCode()
        {
            return this.Face.GetHashCode();
        }

        public override string ToString()
        {
            switch (Face)
            {
                case 1: return "1"; break;
                case 2: return "2"; break;
                case 3: return "3"; break;
                case 4: return "4"; break;
                case 5: return "5"; break;
                case 6: return "6"; break;
                default: return "?"; break;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Die die1 = new Die();
            Die die2 = new Die();
            Console.WriteLine(die1);
            Console.WriteLine(die2);
            if (die1.Equals(die2))
            {
                Console.WriteLine("Both dice show the same face.");
            }
            else
            {
                Console.WriteLine("The dice show different faces.");
            }
        }
    }
}
