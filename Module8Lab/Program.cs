using System;
using System.Collections.Generic;
using System.Linq;

class Pokemon
{
    //Attributes of Pokeman
    public int Id { get; set; }
    /// ? is nullable & prevent compiler warner
    public string? Name { get; set; }
    public string? Type { get; set; }
    public int Level { get; set; }
}

///LINQ Lab Contains are main method
///This is the first method that will be called when the program runs
class PokemonLINQLab
{
    public static void Main()
    {
        // Sample data: list of Pokemon
        var pokemons = new List<Pokemon>
        {
            new Pokemon { Id = 1, Name = "Bulbasaur", Type = "Grass", Level = 15 },
            new Pokemon { Id = 2, Name = "Charmander", Type = "Fire", Level = 36 },
            new Pokemon { Id = 3, Name = "Squirtle", Type = "Water", Level = 10 },
            new Pokemon { Id = 4, Name = "Pikachu", Type = "Electric", Level = 22 },
            new Pokemon { Id = 5, Name = "Eevee", Type = "Normal", Level = 25 },
            new Pokemon { Id = 6, Name = "Jigglypuff", Type = "Normal", Level = 20 }
        };

        // LINQ Query: find Pokemon ready to evolve (level 16 for first evolution)
        //THis is a collection that will hold multiple values
        //p is alias for pokeman
        //Test run with descending
        //Test run with less than
        var readyToEvolve = from p in pokemons
                            where p.Level <= 16
                            orderby p.Level descending
                            select p;

        // Execute the query and display the results
        Console.WriteLine("Pokemon Ready to Evolve:");
        foreach (var p in readyToEvolve)
        {
            Console.WriteLine($"Name: {p.Name}, Type: {p.Type}, Level: {p.Level}");
        }
    }
}