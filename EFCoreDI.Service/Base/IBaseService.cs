using EFCoreDI.Domain.Entity;

namespace EFCoreDI.Service.Base
{
    public interface IBaseService<T> where T : BaseEntity
    {
        T Get(int id);
        Task<T> Get(string query);
        Task<List<T>> GetAll();
        Task<List<T>> GetAll(string query);
        Task<T> Update(T entity);
        T Add(T entity);
        // Task<QueryResult<T>> Search(QueryObjectParams queryParams);
        // Task<QueryResult<T>> Search(string query, QueryObjectParams queryParams);
    }
}
