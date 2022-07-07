using EFCoreDI.Domain.Entity;
using EFCoreDI.Service.Base;

namespace EFCoreDI.Service
{
    public class SaleService : BaseService<Sale> ,ISaleService
    {
        private IEmployeeService _employeeService;
        public SaleService(IEmployeeService employeeService)
        {
            Console.WriteLine("work add sale");
            _employeeService = employeeService;
        }

        public void GetSale()
        {
            _employeeService.Display();
            Console.WriteLine("From "+nameof(SaleService));
        }
    }
}
