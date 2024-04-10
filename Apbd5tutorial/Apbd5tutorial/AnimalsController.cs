using Apbd5tutorial.database;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace Apbd5tutorial;

[ApiController]
[Route("/animals-controllers")]
//[Route("[Controller]")]
public class AnimalsController : ControllerBase
{
    [HttpGet]
    public IActionResult GetAnimals()
    {
        var animals = new MockDb().Animals;
        return Ok(animals);
    }
    
    [HttpPost]
    public IActionResult AddAnimals()
    {
        return Created();
    }
}