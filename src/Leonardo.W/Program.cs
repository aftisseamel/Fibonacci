
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/HelloWorld", () => "Hello      5 World");
app.MapGet("/Fibonacci", 
    async () => await Leonardo.Fibonacci.RunAsync(new []{"44", "43"}));

app.Run();