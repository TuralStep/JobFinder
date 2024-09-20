using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using UserMicroservice.Data;
using UserMicroservice.Entities.Abstract;
using UserMicroservice.Entities.Concrete;
using UserMicroservice.Repositories.Abstract;

namespace UserMicroservice.Repositories.Concrete
{
    public class UserRepository : IUserRepository
    {
        private readonly UserDbContext _context;

        public UserRepository(UserDbContext context)
        {
            _context = context;
        }



        public async Task<List<User>> GetAll()
        {
            var users = await _context.Users.ToListAsync();
            return users;
        }

        public async Task<User> GetById(int id)
        {
            var user = await _context.Users.FirstOrDefaultAsync(x => x.Id == id);
            return user;
        }




        public async Task Add(User entity)
        {
            await _context.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(User entity)
        {
            _context.Remove(entity);
            await _context.SaveChangesAsync();
        }


        public async Task Update(User entity)
        {
            var user = _context.Users.FirstOrDefaultAsync(x => x.Id == entity.Id).Result;
            user = entity;
            await _context.SaveChangesAsync();
        }

    }
}
