using EFCoreDI.Domain.Entity;
using EFCoreDI.Service.Base;

namespace EFCoreDI.Service
{
    public class InvoiceService : BaseService<Invoice>, IInvoiceService
    {
        private IEmployeeService _employeeService;
        private ISaleService _saleService;
        
        public InvoiceService(IEmployeeService employeeService, ISaleService saleService) {
            _employeeService = employeeService;
            _saleService = saleService;
            
            
        }
        
        public void GetInvoiceNo()
        {
            _employeeService.Display();
            _saleService.GetSale();
            Console.WriteLine("There is INV No ::");
        }
    }
}
