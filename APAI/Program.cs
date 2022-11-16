using RestSharp;
using System.Text.Json;
using System.Net;

RestClient pokeClient = new("https://digimon-api.vercel.app/api/digimon");
RestRequest request = new("/api/digimon/name/agumon");
RestResponse response = pokeClient.GetAsync(request).Result;

if (response.StatusCode == HttpStatusCode.OK)
{
    Digimon d = JsonSerializer.Deserialize<Digimon>(response.Content);
    Console.WriteLine(p.Name);
    Console.WriteLine(p.Level);
}
else
{
    Console.WriteLine("What?");
}

// Console.WriteLine(response.Content);

Console.ReadLine();