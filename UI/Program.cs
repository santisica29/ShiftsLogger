await Task.Delay(2000);

var client = new HttpClient();
client.BaseAddress = new Uri("https://localhost:7263");

var response = await client.GetAsync("/api/shifts");

var content = await response.Content.ReadAsStringAsync();

Console.WriteLine(content);
Console.ReadLine();