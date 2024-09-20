using Domain.Entities.Abstract;
using Domain.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities.Concrete;

public class Vacancy : BaseEntity
{

    public string Name { get; set; } = "[Vacancy name here]";
    public string Description { get; set; }
    public string Location { get; set; }
    public string ImageLink { get; set; }
    public int MinSalary { get; set; }
    public int MaxSalary { get; set; }
    public int VacantPlace { get; set; }
    public DateTime PublishedDate { get; set; }
    public JobNature JobNature { get; set; }
    public Experience Experience { get; set; }



    // public long CategoryId { get; set; }
    // 
    // [ForeignKey(nameof(CategoryId))]
    // public Category? Category { get; set; }
    // 
    // 
    // 
    // public long CompanyId { get; set; }
    // 
    // [ForeignKey(nameof(CompanyId))]
    // public Company? SupplierCompany { get; set; }

}
