using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

public class House
{
    [JsonPropertyName("Address")]
    public string Address { get; set; }

    [JsonPropertyName("Flats")]
    public List<Flat> Flats { get; set; }

    public static House DeserializeFromJson(string json)
    {
        return JsonSerializer.Deserialize<House>(json);
    }
}

public class Flat
{
    [JsonPropertyName("Number")]
    public int Number { get; set; }

    [JsonPropertyName("Square")]
    public int Square { get; set; }

    [JsonPropertyName("NumberOfResidents")]
    public int NumberOfResidents { get; set; }
}

// Пример использования
class program
{
    static void Main(string[] args)
    {
        House house = House.DeserializeFromJson(@"C: \Users\Студент.TOP\source\repos\ConsoleApp2\ConsoleApp2\Class1.json");

        Console.WriteLine($"Address: {house.Address}");
        foreach (var flat in house.Flats)
        {
            Console.WriteLine($"Flat Number: {flat.Number}");
            Console.WriteLine($"Square Meters: {flat.Square}");
            Console.WriteLine($"Number of Residents: {flat.NumberOfResidents}");
            Console.WriteLine();
        }
    }
}

