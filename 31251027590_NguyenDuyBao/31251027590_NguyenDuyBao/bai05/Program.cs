using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31251027590_NguyenDuyBao.bai05
{
    internal class Program
    {
        static void Main5(string[] args)
        {
            // Tạo mảng Employee đủ cả 4 loại
            Employee[] employees = new Employee[]
            {
                new SalariedEmployee("John", "Smith", "111-11-1111", 800.00m),
                new HourlyEmployee("Karen", "Price", "222-22-2222", 16.75m, 42),
                new CommissionEmployee("Sue", "Jones", "333-33-3333", 0.06f, 10000.00m),
                new BasePlusCommission("Bob", "Lewis", "444-44-4444", 0.04f, 5000.00m, 300.00m)
            };

            Console.WriteLine("=== BANG LUONG NHAN VIEN ===\n");

            // Xuất bảng lương
            foreach (Employee currentEmployee in employees)
            {
                Console.WriteLine(currentEmployee);
                Console.WriteLine($"earned: {currentEmployee.earnings():C}\n");
            }
        }
    }
}
