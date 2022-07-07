using EFCoreDI.Domain.Entity;
using EFCoreDI.Service.Base;

namespace EFCoreDI.Service
{
    public interface IEmployeeService : IBaseService<Employee>
    {
        public void Display();
    }
}
