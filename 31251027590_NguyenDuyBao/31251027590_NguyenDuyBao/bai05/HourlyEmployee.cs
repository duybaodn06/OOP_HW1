using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31251027590_NguyenDuyBao.bai05
{
    internal class HourlyEmployee : Employee
    {
        protected decimal wage;
        protected int hours;

        public HourlyEmployee(string firstName, string lastName, string SSN, decimal wage, int hours) : base (firstName,  lastName, SSN)
        {
            this.wage = wage;
            this.hours = hours;
        }
        public override decimal earnings()
        {
            if (this.hours <= 40) return wage * hours;
            else if (this.hours > 40) return (wage * 40 +  (hours - 40) * wage * 1.5m);
            return 0m;
        }
        public override string ToString()
        {
            return "hourly employee:" + base.ToString() + $"hourly wage: {this.wage}; hours worked: {this.hours}";
        }
    }
}
