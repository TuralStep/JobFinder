using UserMicroservice.Entities.Abstract;

namespace UserMicroservice.Entities.Concrete
{
    public class GuestRole : BaseRole
    {
        public GuestRole()
        {
            base.RoleName = "Guest";
        }
    }
}
