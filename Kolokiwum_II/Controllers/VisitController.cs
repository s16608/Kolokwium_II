using Kolokiwum_II.Entities;
using Kolokiwum_II.Repositories;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace Kolokiwum_II.Controllers;

public class VisitController
{
    private readonly IVisitRepository _visitRepository;
    private object _kolokwiumDbContext;

    public VisitController(IVisitRepository visitRepository)
    {
        _visitRepository = visitRepository;
    }

    /*[HttpPost("visits/{idPatient:int, idDoctor, date}")]
    public async Task AddVisit(int idPatient, int IdDoctor, DateTime date)
    {
    }*/
}