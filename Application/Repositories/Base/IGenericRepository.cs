using Domain.Entities.Abstract;

namespace Application.Repositories.Base;

public interface IGenericRepository<T> where T : BaseEntity, new()
{
    Task<T?> GetAsync(long id);
    Task<IQueryable<T>> GetAllAsync();


    Task AddAsync(T entity);
    Task DeleteAsync(long id);
    Task<T> UpdateAsync(T entity);
}
