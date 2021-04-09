using System;
using System.Threading.Tasks;
using ConsoleDemo;

swaggerClient client = new("https://localhost:44380", new System.Net.Http.HttpClient());

var records = await client.WeatherForecastAsync();

foreach (var r in records)
{
    Console.WriteLine($"{r.Date}: {r.Summary}");
}
