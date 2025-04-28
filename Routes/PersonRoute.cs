using Microsoft.EntityFrameworkCore;
using Person.Data;
using Person.Models;

namespace Person.Routes;

public static class PersonRoute
{
    public static void PersonRoutes(this WebApplication app)
    {
        var route = app.MapGroup("person");

        route.MapPost("",
        async (PersonRequest req, AppDbContext context) =>
        {
            var person = new PersonModel(req.Name);
            await context.AddAsync(person);
            await context.SaveChangesAsync();
        });


        route.MapGet("", async (AppDbContext context) =>
        {
            var persons = await context.Persons.ToListAsync();
            return Results.Ok(persons);
        });

        route.MapGet("{id:guid}", async (Guid id, AppDbContext context) =>
        {
            var person = await context.Persons.FirstOrDefaultAsync(p => p.Id == id);
            if (person is null)
            {
                return Results.NotFound();
            }
            
            return Results.Ok(person);
        });

        route.MapPut("{id:guid}",
        async (Guid id, PersonRequest req, AppDbContext context) =>
        {
            var person = await context.Persons.FirstOrDefaultAsync(p => p.Id == id);

            if (person is null)
            {
                return Results.NotFound();
            }

            person.ChangeName(req.Name);
            await context.SaveChangesAsync();
            return Results.Ok(person);
        });


        route.MapDelete("{id:guid}", async (Guid id, AppDbContext context) =>
        {
            var person = await context.Persons.FirstOrDefaultAsync(p => p.Id == id);

            if (person is null)
            {
                return Results.NotFound();
            }

            person.SetInactive();

            await context.SaveChangesAsync();
            return Results.Ok(person);
        });
     }
}
