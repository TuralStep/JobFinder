using UserMicroservice.Entities.Abstract;

namespace UserMicroservice.Entities.Concrete
{
    public class User : BaseUser
    {
        public User(string fullName, string username, List<BaseRole> roles)
        {
            base.FullName = fullName;
            this.Username = username;
            this.Roles = roles;
        }
    }
}
