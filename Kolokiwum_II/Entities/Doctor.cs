using System.ComponentModel.DataAnnotations;

namespace Kolokiwum_II.Entities;

public class Doctor
{
    [Key]
    public int IdDoctor { get; set; }
    [MaxLength(100)]
    public string FirstName { get; set; }
    [MaxLength(100)]
    public string LasttName { get; set; }

    [MaxLength(100)]
    public string? Specialization { get; set; }
    
    public decimal PriceForVisit { get; set; }
    
    public ICollection<Visit> Visites { get; set; } = new List<Visit>();
}