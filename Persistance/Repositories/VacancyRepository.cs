using Application.Repositories.Abstract;
using Application.Repositories.Base;
using Domain.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Persistance.Contexts;

namespace Persistance.Repositories;

public class VacancyRepository : IVacancyRepository
{
    protected AppDbContext _context;
    protected DbSet<Vacancy> _entity;

    public VacancyRepository(AppDbContext context)
    {
        _context = context;
        _entity = context.Set<Vacancy>();
    }

    public async Task AddAsync(Vacancy entity)
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

    public async Task<IQueryable<Vacancy>> GetAllAsync()
    {
        return _entity;
    }

    public async Task<Vacancy?> GetAsync(long id)
    {
        return await _entity.FirstOrDefaultAsync(x => x.Id == id); ;
    }

    public async Task<Vacancy> UpdateAsync(Vacancy entity)
    {
        _entity.Update(entity);

        await _context.SaveChangesAsync();

        return entity;
    }
}
