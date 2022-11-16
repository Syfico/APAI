using System.Security.AccessControl;
using RestSharp;
using System.Text.Json;
using System.Net;
using System.IO;

RestClient pokeClient = new("https://digimon-api.vercel.app/api/digimon");
RestRequest request = new("name/agumon");
RestResponse response = pokeClient.GetAsync(request).Result;

if (response.StatusCode == HttpStatusCode.OK)
{
    // File.WriteAllText("./test.json", response.Content.Substring(1, response.Content.Length - 2));
    Digimon d = JsonSerializer.Deserialize<Digimon>(response.Content.Substring(1, response.Content.Length - 2));
    Console.WriteLine(d.Name);
    Console.WriteLine(d.Level);
}
else
{
    Console.WriteLine("What?");
}

// Console.WriteLine(response.Content);

Console.ReadLine();