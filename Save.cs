using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class Save
{
    public static string Card(string question)
    {
        Console.WriteLine(question);
        string filename = Console.ReadLine();
        return $"{filename}.json";
    }

    public static void SaveEntriesToFile(List<Summary> entries)
    {
        var options = new JsonSerializerOptions
        {
            IncludeFields = true,
        };
        string fileName = Card("What is the file name");
        string jsonString = JsonSerializer.Serialize(entries, options);
        File.WriteAllText(fileName, jsonString);
    }

    public static List<Summary> ReadEntriesFromFile()
    {
        var options = new JsonSerializerOptions
        {
            IncludeFields = true,
        };
        string fileName = Card("What is the file name?");
        string jsonString = File.ReadAllText(fileName);
        return JsonSerializer.Deserialize<List<Summary>>(jsonString, options);
    }
}