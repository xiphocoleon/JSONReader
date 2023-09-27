using System.IO;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

String line = "";

string contents = File.ReadAllText("C:\\Users\\thoma\\Documents\\cs\\projectInfo.txt");
try
{
    Project? projectDNP = JsonSerializer.Deserialize<Project>(contents);
    Console.WriteLine($"project: {projectDNP?.projectName}"); //Property must match the value in the JSON
}
catch(Exception e)
{

    Console.WriteLine(e.Message);
}


public class Project
{
    public string projectName { get; set; }
    public DateTimeOffset Date { get; set; }
}