using EFCoreDI.Domain.Entity;
using EFCoreDI.Service.Base;

namespace EFCoreDI.Service
{
    public interface ISaleService : IBaseService<Sale>
    {
        public void GetSale();
    }
}
