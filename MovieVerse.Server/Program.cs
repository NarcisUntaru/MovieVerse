using Microsoft.EntityFrameworkCore;
using MovieVerse.Server.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

var password = builder.Configuration["DbPassword"];
var connectionString = $"server=localhost;port=3306;database=MovieVerseDb;user=root;password={password}";

builder.Services.AddDbContext<MovieVerseServerContext>(options =>
    options.UseMySql(
        connectionString,
        new MySqlServerVersion(new Version(8, 0, 42))
    )
);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseDefaultFiles();
app.UseStaticFiles();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.MapFallbackToFile("/index.html");

app.Run();
