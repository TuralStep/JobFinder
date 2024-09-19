using UserMicroservice.Entities.Abstract;

namespace UserMicroservice.Entities.Concrete
{
    public class UserRole : BaseRole
    {
        public UserRole()
        {
            base.RoleName = "User";
        }
    }
}
