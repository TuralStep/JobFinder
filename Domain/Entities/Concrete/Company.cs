using Domain.Entities.Abstract;

namespace Domain.Entities.Concrete;

public class Company : BaseEntity
{
    public string Name { get; set; } = "[Company name here]";
    public string? Description { get; set; }
    public string? WebPage { get; set; }
    public string? Mail { get; set; }


    public ICollection<Vacancy>? Vacancies { get; set; }
}
