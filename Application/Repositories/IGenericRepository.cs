using Domain.Entities.Abstract;

namespace Application.Repositories;

public interface IGenericRepository<T> where T : BaseEntity, new()
{
    Task<T?> GetAsync(int id);
    Task<IQueryable<T>> GetAllAsync();


    Task AddAsync(T entity);
    Task DeleteAsync(int id);
    Task<T> UpdateAsync(T entity);
}
