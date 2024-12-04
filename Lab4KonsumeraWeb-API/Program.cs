using Lab4KonsumeraWeb_API;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        HttpClient client = new HttpClient();
        client.DefaultRequestHeaders.UserAgent.ParseAdd("Mozilla/5.0 (compatible; Lab4App)");

        // Hämta JSON-data från GitHub API
        var response = await client.GetAsync("https://api.github.com/orgs/dotnet/repos");
        var content = await response.Content.ReadAsStringAsync();

        // Deserialisera JSON till en lista av Repository-objekt
        var repositories = JsonSerializer.Deserialize<List<Repository>>(content);

        // Skriv ut resultaten
        foreach (var repo in repositories)
        {
            Console.WriteLine(repo);
        }
    }
}



