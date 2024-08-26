var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();


var test1 = new[]
{
    "ett","two","tre","fyra"
};

app.MapGet("/nummer", () =>
{
    var num1 = test1;
    return num1;
});

app.MapPost("/post", (int i, string num2) =>
{
    var num1 = test1;
    num1[i] = num2;
    return num1;
});

app.MapPut("/put", (int i, string num2) =>
{
    var num1 = test1;
    num1[i] = num2;
    return num1;

});

app.MapDelete("delete", (int i) =>
{
    var num1 = test1;
    num1[i].Remove(i);
    return num1;

});


app.Run();

internal record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}
