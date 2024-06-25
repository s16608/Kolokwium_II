using Kolokiwum_II.Entities;

namespace Kolokiwum_II.DTOs;

public class PatientDetailsDto
{
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    
    public DateTime BirthDate { get; set; }
    
    public int NumberOfVisits { get; set; }
    
    public IEnumerable<VisitDto> Visites { get; set; } = (IEnumerable<VisitDto>)Enumerable.Empty<VisitDto>();
}