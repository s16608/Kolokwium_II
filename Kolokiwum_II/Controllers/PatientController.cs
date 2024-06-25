using Kolokiwum_II.DTOs;
using Kolokiwum_II.Repositories;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace Kolokiwum_II.Controllers;

public class PatientController
{
    private readonly IPatientRepository _patientRepository;

    public PatientController(IPatientRepository patientRepository)
    {
        _patientRepository = patientRepository;
    }

    [HttpGet("patients/{idPatient:int}")]
    public async Task<ActionResult<PatientDetailsDto>> GetPateint(int idPatient)
    {
        var patient = await _patientRepository.GetPatient(idPatient);

        
        return patient;
    }
}