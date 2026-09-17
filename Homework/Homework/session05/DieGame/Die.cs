using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.session05.DieGame
{
    internal class Die
    {
        public byte Face { get; private set; }

        public void roll()
        {
            Random rd = new Random();
            Face = (byte)rd.Next(1, 7); 
        }

        public Die() { 
            roll();
        }

        public override bool Equals(object? obj)
        {
            if (obj is not Die) return false;
            return Face == ((Die)obj).Face;
        }

        public override int GetHashCode()
        {
            return Face.GetHashCode();
        }

        public override string ToString()
        {
            string x;
            switch (Face)
            {
                case 1: x = "1"; break;
                case 2: x = "2"; break;
                case 3: x = "3"; break;
                case 4: x = "4"; break;
                case 5: x = "5"; break;
                case 6: x = "6"; break;
                default: x = "?"; break;
            }
            return x;
        }
    }
}
