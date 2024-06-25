using Kolokiwum_II.Context;
using Kolokiwum_II.DTOs;
using Microsoft.EntityFrameworkCore;

namespace Kolokiwum_II.Repositories;

public class PatientRepository : IPatientRepository
{
    
    private readonly KolokwiumDbContext _kolokwiumDbContext;

    public PatientRepository(KolokwiumDbContext kolokwiumDbContext)
    {
        _kolokwiumDbContext = kolokwiumDbContext;
    }

    public async Task<PatientDetailsDto?> GetPatient(int IdPatient)
    {
        return await _kolokwiumDbContext.Patients
            .Where(x => x.IdPatient == IdPatient)
            .Select(x => new PatientDetailsDto()
            {
                FirstName = x.FirstName,
                LastName = x.LastName,
                BirthDate = x.Birthdate,
                NumberOfVisits = x.Visites.Count,
                Visites = x.Visites.Select(s => new VisitDto()
                {
                    IdVisit = s.IdVisit,
                    // Doctor = s.Doctor,
                    Date = s.Date,
                    Price = s.Price
                }).ToList()
            })
            .FirstOrDefaultAsync();
    }
    
}