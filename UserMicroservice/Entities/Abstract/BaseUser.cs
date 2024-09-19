using Microsoft.AspNetCore.Identity;

namespace UserMicroservice.Entities.Abstract
{
    public class BaseUser : BaseEntity
    {
        public string FullName { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public string PasswordSalt { get; set; }
        public ICollection<BaseRole> Roles { get; set; }
    }
}
