using Apbd5tutorial.database;
using Apbd5tutorial.Models;

namespace Apbd5tutorial;

public static class AnimalEndpoints
{
    public static void MapAnimalEndpoints(this WebApplication app)
    {
        app.MapGet("/animals/{id}", (int id) =>
        {
            //Kody html
            //200 - ok
            //400 - Bad request
            //401 - Unauthorized
            //402 - 
            //403 - forbidden
            //404 - not found
            //500 - internal server error


            var animals = StaticData.animals;
            return Results.Ok(id);
        });

        app.MapPost("/animals", (Animal animal) =>
        {
            //201 - created
            return Results.Created();
        });
    }
}