namespace Domain.DTOs;

public class VacancyAddDto
{
    public long Id { get; set; }
    public string Name { get; set; } = "[Vacancy name here]";
    public string Description { get; set; }
    public string Location { get; set; }
    public string ImageLink { get; set; }
    public int MinSalary { get; set; }
    public int MaxSalary { get; set; }
    public int VacantPlace { get; set; }
}
