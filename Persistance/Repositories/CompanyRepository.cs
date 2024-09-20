using Application.Repositories.Abstract;
using Application.Repositories.Base;
using Domain.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Persistance.Contexts;

namespace Persistance.Repositories;

public class CompanyRepository : ICompanyRepository
{
    protected AppDbContext _context;
    protected DbSet<Company> _entity;

    public CompanyRepository(AppDbContext context)
    {
        _context = context;
        _entity = context.Set<Company>();
    }

    public async Task AddAsync(Company entity)
    {
        await _context.AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(long id)
    {
        var entity = await _entity.FirstOrDefaultAsync(x => x.Id == id);

        if (entity is not null)
            _entity.Remove(entity);

        await _context.SaveChangesAsync();
    }

    public async Task<IQueryable<Company>> GetAllAsync()
    {
        return _entity;
    }

    public async Task<Company?> GetAsync(long id)
    {
        return await _entity.FirstOrDefaultAsync(x => x.Id == id); ;
    }

    public async Task<Company> UpdateAsync(Company entity)
    {
        _entity.Update(entity);

        await _context.SaveChangesAsync();

        return entity;
    }
}