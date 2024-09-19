using UserMicroservice.Entities.Abstract;

namespace UserMicroservice.Entities.Concrete
{
    public class EmployerRole : BaseRole
    {
        public EmployerRole()
        {
            base.RoleName = "Employer";
        }
    }
}
