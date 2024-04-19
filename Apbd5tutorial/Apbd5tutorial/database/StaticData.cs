using Apbd5tutorial.Models;

namespace Apbd5tutorial.database;

public class StaticData
{
    public static List<Animal> animals = new List<Animal>()
    {
        new Animal(),
        new Animal(),
        new Animal()
    };
    
    public static List<Visit> visits = new List<Visit>()
    {
        new Visit(),
        new Visit(),
        new Visit()
    };

}