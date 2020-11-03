using DrEthos.Entities.Kisiler;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DrEthos.DataAccess.EntityFramework
{
    public class EFDatabaseContext : DbContext
    {
        public EFDatabaseContext(DbContextOptions<EFDatabaseContext> options) : base(options)
        {

        }
        public DbSet<Kisi> Kisi { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Kisi>().HasData(new Kisi
            {
                Adi = "Adem",
                Soyadi = "Bayar",
                Telefon = "5398782874",
                DogumTarihi = new DateTime(1991, 07, 08),
            },
            new Kisi
            {
                Adi = "Mehmet",
                Soyadi = "Bayar",
                Telefon = "5398782874",
                DogumTarihi = new DateTime(1990, 10, 10),
            });

            base.OnModelCreating(builder);
        }
    }

    public class EFDatabaseContextFactory : IDesignTimeDbContextFactory<EFDatabaseContext>
    {
        public EFDatabaseContext CreateDbContext(params string[] args)
        {
            // Get environment
            string environment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");

            // Build config
            IConfiguration configuration = new ConfigurationBuilder()
                 .SetBasePath(Directory.GetCurrentDirectory())
                 .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddJsonFile($"appsettings.{environment}.json", optional: true)
                .AddEnvironmentVariables()
                .Build();

            var builder = new DbContextOptionsBuilder<EFDatabaseContext>();
            builder.UseSqlServer(configuration.GetConnectionString("DatabaseContext"));

            return new EFDatabaseContext(builder.Options);
        }

    }
}
