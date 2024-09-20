using UserMicroservice.Entities.Abstract;
using UserMicroservice.Entities.Concrete;

namespace UserMicroservice.Repositories.Abstract;

public interface IUserRepository : IRepository<User>
{
    Task<List<User>> GetUsersByRole(BaseRole role);
}
