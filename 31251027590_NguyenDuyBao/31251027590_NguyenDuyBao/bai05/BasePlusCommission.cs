using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31251027590_NguyenDuyBao.bai05
{
    internal class BasePlusCommission : CommissionEmployee
    {
        protected decimal baseSalary;

        public BasePlusCommission(string firstName, string lastName, string SSN, float commissionRate, decimal grossSales, decimal baseSalary) : base(firstName, lastName, SSN, commissionRate, grossSales)
        {
            this.baseSalary = baseSalary;
        }
        public override decimal earnings()
        {
            return this.baseSalary + base.earnings();
        }
        public override string ToString()
        {
            return $"base salaried commission employee: " + base.ToString() + $"\nbase salary: {this.baseSalary}";
        }
    }
}
