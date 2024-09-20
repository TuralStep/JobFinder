using Domain.Entities.Abstract;

namespace Domain.Entities.Concrete;

public class Category : BaseEntity
{
    public string Name { get; set; } = "[Category name here]";
    public string Description { get; set; } = "No description";



    public ICollection<Vacancy>? Vacancies { get; set; }

}
