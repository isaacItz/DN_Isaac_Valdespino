// See https://aka.ms/new-console-template for more information
using WebApi.WindowsClient;
using Api.Entities;
using System.Text;

//IpAddress ip = GetIP().Result;
//IpInfo ipInfo = GetIPInfo(ip.Ip).Result;
//Console.WriteLine($"Country: {ipInfo.Country}");
//Console.WriteLine($"Hostname: {ipInfo.Hostname}");
//.WriteLine($"City: {ipInfo.City}");

System.Threading.Thread.Sleep(20000);
Zone zone = new Zone
{
    City = "Acapulco",
    Date = new DateTime(2021, 12, 24)
};
var forecast = GetWeatherForecastAsync(zone).Result;
Console.WriteLine($"ciudad: {forecast.Zone.City}");
Console.WriteLine($"fecha: {forecast.Zone.Date}");
Console.WriteLine();
foreach (var item in forecast.WeatherForecast)
{
    Console.WriteLine($"Summary: {item.Summary}");
    Console.WriteLine($"temperature: {item.TemperatureC}");
    Console.WriteLine($"date: {item.Date}");
}


async Task<ZoneWeatherForecast> GetWeatherForecastAsync(Zone zone)
{
    string jsonContent = Newtonsoft.Json.JsonConvert.SerializeObject(zone);
    StringContent content = new StringContent(jsonContent, Encoding.UTF8, "application/json");
    HttpClient client = new HttpClient();
    HttpResponseMessage response = await client.PostAsync("https://localhost:7222/weatherforecast/byzone", content);
    response.EnsureSuccessStatusCode();
    string responseBody = await response.Content.ReadAsStringAsync();
    ZoneWeatherForecast zoneWF = Newtonsoft.Json.JsonConvert.DeserializeObject<ZoneWeatherForecast>(responseBody);
    return zoneWF;
}
async Task<IpAddress> GetIP()
{
    HttpClient client = new HttpClient();
    HttpResponseMessage response = await client.GetAsync("https://api.ipify.org/?format=json");
    response.EnsureSuccessStatusCode();
    string responseBody = await response.Content.ReadAsStringAsync();
    IpAddress ip = Newtonsoft.Json.JsonConvert.DeserializeObject<IpAddress>(responseBody);
    Console.WriteLine("my current ip: " + ip.Ip);
    return ip;
}

async Task<IpInfo> GetIPInfo(string ip)
{
    HttpClient client = new HttpClient();
    HttpResponseMessage response = await client.GetAsync($"https://ipinfo.io/{ip}/geo");
    response.EnsureSuccessStatusCode();
    string responseBody = await response.Content.ReadAsStringAsync();
    IpInfo ipInfo = Newtonsoft.Json.JsonConvert.DeserializeObject<IpInfo>(responseBody);
    return ipInfo;
}