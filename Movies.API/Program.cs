using GraphQL;
using Microsoft.EntityFrameworkCore;
using Movies.API.Data;
using Movies.API.GraphQL.Queries;
using Movies.API.GraphQL.Schemas;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

string connectionString = builder.Configuration.GetConnectionString("MoviesConnectionString")
    ?? throw new ArgumentException("Connection string not set.");
builder.Services.AddDbContext<MoviesDbContext>(options =>
    options.UseNpgsql(connectionString));

builder.Services.AddScoped<MovieQuery>();
builder.Services.AddScoped<MovieSchema>();

builder.Services.AddGraphQL(options =>
    options.AddGraphTypes()
        .AddSystemTextJson());

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseGraphQL<MovieSchema>();
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
