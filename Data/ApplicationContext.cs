using Data.Mapping;
using Domain.Entities;

using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Npgsql;

namespace Data
{
    public class ApplicationDbContext : DbContext
    {
        protected readonly IConfiguration Configuration;
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options, 
                                    IConfiguration configuration) : base(options)
        {
            Configuration = configuration;
        }
        public DbSet<Developer> Developers { get; set; }
        public DbSet<Project> Projects { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // connect to postgres with connection string from app settings
            var conStrBuilder = new NpgsqlConnectionStringBuilder(Configuration.GetConnectionString("WebApiDatabase"));
            conStrBuilder.Password = Configuration["WebApiDatabase:Password"];
            options.UseNpgsql(conStrBuilder.ConnectionString);

            //options.EnableSensitiveDataLogging();
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.HasDefaultSchema("DGTIDev");
            builder.ApplyConfiguration(new ProjectMapping());
        }
    }
}