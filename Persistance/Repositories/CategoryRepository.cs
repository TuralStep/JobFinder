using Application.Repositories;
using Domain.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Persistance.Contexts;

namespace Persistance.Repositories;

public class CategoryRepository : IGenericRepository<Category>
{
    protected AppDbContext _context;
    protected DbSet<Category> _entity;

    public CategoryRepository(AppDbContext context)
    {
        _context = context;
        _entity = context.Set<Category>();
    }

    public async Task AddAsync(Category entity)
    {
        await _context.AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var entity = await _entity.FirstOrDefaultAsync(x => x.Id == id);

        if (entity is not null)
            _entity.Remove(entity);

        await _context.SaveChangesAsync();
    }

    public async Task<IQueryable<Category>> GetAllAsync()
    {
        return _entity;
    }

    public async Task<Category?> GetAsync(int id)
    {
        return await _entity.FirstOrDefaultAsync(x => x.Id == id); ;
    }

    public async Task<Category> UpdateAsync(Category entity)
    {
        _entity.Update(entity);

        await _context.SaveChangesAsync();

        return entity;
    }
}