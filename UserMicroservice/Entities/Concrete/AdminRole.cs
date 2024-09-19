using UserMicroservice.Entities.Abstract;

namespace UserMicroservice.Entities.Concrete
{
    public class AdminRole : BaseRole
    {
        public AdminRole()
        {
            base.RoleName = "Admin";
        }
    }
}
