using DrEthos.DataAccess.EntityFramework;
using DrEthos.DataAccess.EntityFramework.Repo;
using DrEthos.DataAccess.EntityFramework.Repo.Concrete;
using DrEthos.Entities.Kisiler;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace DrEthos.DataAccess
{
    public class Startup
    {
        public static void ConfigureServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IDataRepository<Kisi>, KisiManager>();

            string connectionString = configuration.GetConnectionString("DatabaseContext");
            services.AddDbContext<EFDatabaseContext>(opts => opts.UseSqlServer(connectionString));

            EFDatabaseContextFactory databaseContextFactory = new EFDatabaseContextFactory();
            EFDatabaseContext context = databaseContextFactory.CreateDbContext();
        }
    }
}
