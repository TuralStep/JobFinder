using Microsoft.EntityFrameworkCore;
using UserMicroservice.Data;
using UserMicroservice.Entities.Abstract;
using UserMicroservice.Repositories.Abstract;

namespace UserMicroservice.Repositories.Concrete
{
    public class RoleRepository : IRoleRepository
    {
        private readonly UserDbContext _context;

        public RoleRepository(UserDbContext context)
        {
            _context = context;
        }



        public async Task<List<BaseRole>> GetAll()
        {
            return await _context.Roles.ToListAsync();
        }

        public async Task<BaseRole> GetById(int id)
        {
            var role = await _context.Roles.FirstOrDefaultAsync(r => r.Id == id);
            return role;
        }

        public async Task<List<BaseRole>> GetRolesOfUser(int id)
        {
            var user = await _context.Users.FirstOrDefaultAsync(u => u.Id == id);
            var list = (List<BaseRole>)user.Roles;
            return list;
        }




        public async Task Add(BaseRole entity)
        {
            await _context.Roles.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(BaseRole entity)
        {
            _context.Roles.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Update(BaseRole entity)
        {
            var role = _context.Roles.FirstOrDefaultAsync(x => x.Id == entity.Id).Result;
            role = entity;
            await _context.SaveChangesAsync();
        }

    }
}
