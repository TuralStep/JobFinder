using UserMicroservice.Entities.Concrete;

namespace UserMicroservice.Entities.Abstract
{
    public class BaseRole : BaseEntity
    {
        public string RoleName { get; set; }

        public ICollection<User> Users { get; set; }
    }
}
