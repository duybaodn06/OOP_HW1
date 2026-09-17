using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31251027590_NguyenDuyBao.bai05
{
    internal class CommissionEmployee : Employee
    {
        protected float commissionRate;
        protected decimal grossSales;
        public CommissionEmployee(string firstName, string lastName, string SSN, float commissionRate, decimal grossSales) : base (firstName, lastName, SSN)
        {
            this.commissionRate = commissionRate;
            this.grossSales = grossSales;
        }
        public override decimal earnings()
        {
            return (decimal)commissionRate * grossSales;
        }
        public override string ToString()
        {
            return $"commission employee: " + base.ToString() + $"gross sales: {this.grossSales}; commission rate: {this.commissionRate}";
        }
    }
}
