using Domain.Enums;

namespace Domain.DTOs;

public class VacancySimpleDto
{
    public string Name { get; set; } = "[Vacancy name here]";
    public string? CompanyName { get; set; }
    public string? Location { get; set; }
    public string? ImageLink { get; set; }
    public int MinSalary { get; set; }
    public int MaxSalary { get; set; }
    public DateTime PublishedDate { get; set; }
    public JobNature JobNature { get; set; }
}
