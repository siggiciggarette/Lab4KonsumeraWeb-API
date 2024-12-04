using Lab4KonsumeraWeb_API;
using System;
using System.Net.Http;
using System.Text.Json;
using System.Collections.Generic;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        // Skapa en instans av HttpClient
        using HttpClient client = new HttpClient();

        // Ange en User-Agent (krävs av GitHub API)
        client.DefaultRequestHeaders.Add("User-Agent", "C# App");

        // URL till API:et
        string url = "https://api.github.com/orgs/dotnet/repos";

        try
        {
            // Skicka en GET-förfrågan och vänta på svaret
            HttpResponseMessage response = await client.GetAsync(url);

            // Kontrollera att svaret är framgångsrikt
            response.EnsureSuccessStatusCode();

            // Läs innehållet som en sträng
            string content = await response.Content.ReadAsStringAsync();

            // Deserialisera JSON-strängen till en lista av Repository-objekt
            var repositories = JsonSerializer.Deserialize<List<Repository>>(content);

            // Iterera genom alla repository-objekt och skriv ut deras innehåll
            foreach (var repo in repositories)
            {
                Console.WriteLine(repo);
            }
        }
        catch (Exception ex)
        {
            // Hantera eventuella fel
            Console.WriteLine($"Ett fel inträffade: {ex.Message}");
        }
    }
}



