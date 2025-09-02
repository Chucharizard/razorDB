using Bogus;
using razordb.Data;
using razordb.Models;
using Microsoft.EntityFrameworkCore;

namespace razordb.Seeders
{
    public static class TareaSeeder
    {
        public static void SeedData(TareaDbContext context)
        {
     
            context.Database.EnsureCreated();

      
            if (context.Tareas.Any())
            {
                return; 
            }

          
            var tareaFaker = new Faker<Tarea>()
                .RuleFor(t => t.nombreTarea, f => f.Lorem.Sentence(3))
                .RuleFor(t => t.fechaVencimiento, f => f.Date.Future(1))
                .RuleFor(t => t.estado, f => f.PickRandom(new[] { "Pendiente", "En Curso", "Finalizado" }))
                .RuleFor(t => t.idUsuario, f => f.Random.Number(1, 5));

            var tareas = tareaFaker.Generate(25);

           
            context.Tareas.AddRange(tareas);
            context.SaveChanges();

            Console.WriteLine("✅ Base de datos inicializada con 25 tareas de prueba.");
        }
    }
}