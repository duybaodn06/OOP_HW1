using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31251027590_NguyenDuyBao.bai05
{
    internal abstract class Employee
    {
        protected string firstName;
        protected string lastName;
        protected string SSN;

        public Employee(string firstName, string lastName, string SSN)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.SSN = SSN;
        }

        public abstract decimal earnings();

        public override string ToString()
        {
            return $"{this.firstName} {this.lastName}\nsocial security number: {SSN}\n";
        }
        
    }
}
