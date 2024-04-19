using Apbd5tutorial.database;
using Apbd5tutorial.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace Apbd5tutorial;
[ApiController]
[Route("/visit-controllers")]

public class VisitControllers : ControllerBase
{
    [HttpGet("{AnimalId}")]
    public IActionResult GetVisits(int AnimalId) 
    {
        var visits = StaticData.visits.Where(visit => visit.AnimalId == AnimalId).ToList();
        return Ok(visits);
    }
    
    [HttpPost]
    public IActionResult AddVisit(Visit visit)
    {
        StaticData.visits.Add(visit);
        return StatusCode(StatusCodes.Status201Created);
    }
}