using EFCoreDI.Domain.Entity;
using EFCoreDI.Service.Base;

namespace EFCoreDI.Service
{
    public interface IInvoiceService : IBaseService<Invoice>
    {
        public void GetInvoiceNo();
    }
}
