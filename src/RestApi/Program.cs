
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddCors();

var app = builder.Build();

app.MapGet("/api/home", (HttpResponse res) =>
{
    return Results.Text("Minimal API :)");
});


app.Run();
