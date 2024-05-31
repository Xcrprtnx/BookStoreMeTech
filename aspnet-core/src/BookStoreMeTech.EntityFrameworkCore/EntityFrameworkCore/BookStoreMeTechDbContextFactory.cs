using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace BookStoreMeTech.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class BookStoreMeTechDbContextFactory : IDesignTimeDbContextFactory<BookStoreMeTechDbContext>
{
    public BookStoreMeTechDbContext CreateDbContext(string[] args)
    {
        BookStoreMeTechEfCoreEntityExtensionMappings.Configure();

        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<BookStoreMeTechDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));

        return new BookStoreMeTechDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../BookStoreMeTech.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
