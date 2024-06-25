using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices.JavaScript;

namespace Kolokiwum_II.Entities;

public class Patient
{
    [Key]
    public int IdPatient { get; set; }
    [MaxLength(100)]
    public string FirstName { get; set; }
    [MaxLength(100)]
    public string LastName { get; set; }
    public DateTime Birthdate { get; set; }
    
    public ICollection<Visit> Visites { get; set; } = new List<Visit>();
}