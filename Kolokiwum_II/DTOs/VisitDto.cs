namespace Kolokiwum_II.DTOs;

public class VisitDto
{
    public int IdVisit { get; set; }
    
    public string Doctor { get; set; }
    
    public DateTime Date { get; set; }
    public decimal Price { get; set; }
}