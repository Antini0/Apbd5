using Apbd5tutorial.database;
using Apbd5tutorial.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace Apbd5tutorial;

[ApiController]
[Route("/animals-controllers")]
//[Route("[Controller]")]
public class AnimalsController : ControllerBase
{
    [HttpGet]
    public IActionResult GetAnimals() //interfejs moze oznaczac roznego rodzaju zwracane dane z naszego api
    {
        var animals = new MockDb().Animals;
        return Ok(animals); //opakowuje zwracane dane w kod http
    }
    
    [HttpGet("{id}")]
    public IActionResult GetAnimal(int id) 
    {
        var animals = StaticData.animals.FirstOrDefault((a => a.Id == id));
        return Ok(animals);
    }
    
    [HttpPost]
    public IActionResult AddAnimal(Animal animal)
    {
        StaticData.animals.Add(animal);
        return StatusCode(StatusCodes.Status201Created);
    }
    
    [HttpPut("{id}")]
    public IActionResult UpdateAnimal(int id, Animal animal) 
    {
        var animalToEdit = StaticData.animals.FirstOrDefault((a => a.Id == id));

        if (animalToEdit == null)
        {
            return NotFound($"animal with id was not found");
        }
        
        StaticData.animals.Remove(animalToEdit);
        StaticData.animals.Add(animal);
        return NoContent();
    }
    
    [HttpDelete("{id}")]
    public IActionResult DeleteAnimal(int id) 
    {
        var animalToDelete = StaticData.animals.FirstOrDefault((a => a.Id == id));

        if (animalToDelete == null)
        {
            return NotFound($"animal with id was not found");
        }
        
        StaticData.animals.Remove(animalToDelete);
        return NoContent();
    }
}