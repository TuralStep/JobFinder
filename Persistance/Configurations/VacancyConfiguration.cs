using Domain.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistance.Configurations;

public class VacancyConfiguration : IEntityTypeConfiguration<Vacancy>
{
    public void Configure(EntityTypeBuilder<Vacancy> builder)
    {
        builder.Property(x => x.Name).IsRequired();
        builder.Property(x => x.Description).IsRequired();
        builder.Property(x => x.Location).IsRequired();
        builder.Property(x => x.ImageLink).IsRequired();
        builder.Property(x => x.MinSalary).IsRequired();
        builder.Property(x => x.MaxSalary).IsRequired();
        builder.Property(x => x.VacantPlace).IsRequired();
        builder.Property(x => x.PublishedDate).IsRequired();
        builder.Property(x => x.JobNature).IsRequired();
        builder.Property(x => x.Experience).IsRequired();

        //builder.HasOne(x => x.Category)
        //    .WithMany(x => x.Vacancies)
        //    .HasForeignKey(x => x.CategoryId);
        //
        //builder.HasOne(x => x.SupplierCompany)
        //    .WithMany(x => x.Vacancies)
        //    .HasForeignKey(x => x.CompanyId);

    }
}
