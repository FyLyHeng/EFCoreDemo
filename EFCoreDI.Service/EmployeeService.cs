using EFCoreDI.Domain.Entity;
using EFCoreDI.Service.Base;
using Microsoft.EntityFrameworkCore;

namespace EFCoreDI.Service
{
    public class EmployeeService : BaseService<Employee>, IEmployeeService
    {
        public void Display()
        {
            
            var inv = _context.Invoices.Include(q=>q.Employee).FirstOrDefault();
            
            Console.WriteLine($"can call deep to base : {inv?.Employee}");
            //Console.WriteLine($"Herer::: {repo.FirstOrDefault(q => q.EmpName == "liza")?.EmpName}");
            //Console.WriteLine($"Test::EMP :: {Get(1)}");
        }

        public Employee Get(int id)
        {
            Console.WriteLine("Yes i can override Base Service");
            return base.Get(id);
        }


    }
}