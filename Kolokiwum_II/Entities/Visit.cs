using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kolokiwum_II.Entities;

public class Visit
{
    [Key]
    public int IdVisit { get; set; }
    public DateTime Date { get; set; }
    public int IdPatient { get; set; }

    [ForeignKey(nameof(IdPatient))]
    public Patient Patient { get; set; } = null!;
    
    public int IdDoctor { get; set; }

    [ForeignKey(nameof(IdDoctor))]
    public Doctor PDoctor { get; set; } = null!;
    
    public decimal Price { get; set; }
}