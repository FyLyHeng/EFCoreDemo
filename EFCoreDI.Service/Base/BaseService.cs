using EFCoreDI.Domain;
using EFCoreDI.Domain.Entity;
using EFCoreDI.Service.DI;
using Microsoft.EntityFrameworkCore;
using AppContext = EFCoreDI.Domain.AppContext;

namespace EFCoreDI.Service.Base
{
    public class BaseService<T> : IBaseService<T> where T : BaseEntity
    {

        public readonly AppContext _context;
        public readonly DbSet<T> repo;
        private readonly bool _isAllowDelete;
        private readonly bool _isAllowUpdate;
        private T? _entity;

        public BaseService(AppContext appContext)
        {
            _context = appContext;
            repo = _context.Set<T>();
        }
        public BaseService()
        {
            _context = ServiceRegistration.GetIService<AppContext>();
            repo = _context.Set<T>();
        }


        public T Get(int id)
        {
            return repo.Single(q => q.Id == id);
        }
        public Task<T> Get(string query)
        {
            throw new NotImplementedException();
        }
        public Task<List<T>> GetAll()
        {
            throw new NotImplementedException();
        }
        public Task<List<T>> GetAll(string query)
        {
            throw new NotImplementedException();
        }
        public Task<T> Update(T entity)
        {
            throw new NotImplementedException();
        }
        public T Add(T entity)
        {
            var rs = repo.Add(entity);
            _context.SaveChanges();
            _entity = rs.Entity;
            return _entity;
        }
    }
}
