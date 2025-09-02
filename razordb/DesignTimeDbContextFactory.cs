using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;
using razordb.Data;

namespace razordb
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<TareaDbContext>
    {
        public TareaDbContext CreateDbContext(string[] args)
        {
          
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

        
            var builder = new DbContextOptionsBuilder<TareaDbContext>();
            var connectionString = configuration.GetConnectionString("DefaultConnection");

           
            builder.UseSqlServer(connectionString);

           
            return new TareaDbContext(builder.Options);
        }
    }
}
