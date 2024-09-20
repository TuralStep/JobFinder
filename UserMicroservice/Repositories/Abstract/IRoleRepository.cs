using UserMicroservice.Entities.Abstract;

namespace UserMicroservice.Repositories.Abstract;

public interface IRoleRepository : IRepository<BaseRole>
{
    Task<List<BaseRole>> GetRolesOfUser(int id);
}
