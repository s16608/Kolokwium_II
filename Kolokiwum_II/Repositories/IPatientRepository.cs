using Kolokiwum_II.DTOs;

namespace Kolokiwum_II.Repositories;

public interface IPatientRepository
{
    Task<PatientDetailsDto> GetPatient(int IdPatient);
}