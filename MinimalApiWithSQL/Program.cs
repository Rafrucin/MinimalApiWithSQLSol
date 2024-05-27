using Microsoft.EntityFrameworkCore;
using MinimalApiWithSQL.Contexts;
using MinimalApiWithSQL.Entities;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer("name=defaultConnection"));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapPost("/people", async (Person person, ApplicationDbContext context) =>
{
    context.Add(person);
    await context.SaveChangesAsync();
    return TypedResults.Ok();
});

app.MapGet("/people", async (ApplicationDbContext context) =>
{
    var all = await context.People.ToListAsync();
    return TypedResults.Ok(all);
});

app.Run();


