using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UserMicroservice.Entities.Concrete;

namespace UserMicroservice.Configuration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Property(x => x.Id).IsRequired();
            builder.Property(x => x.FullName).IsRequired();
            builder.Property(x => x.Username).IsRequired();
            builder.Property(x => x.PasswordHash).IsRequired();
            builder.Property(x => x.PasswordSalt).IsRequired();

            builder.HasMany(x => x.Roles)
                .WithMany(x => x.Users);

        }
    }
}
