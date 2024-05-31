using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using BookStoreMeTech.Data;
using Volo.Abp.DependencyInjection;

namespace BookStoreMeTech.EntityFrameworkCore;

public class EntityFrameworkCoreBookStoreMeTechDbSchemaMigrator
    : IBookStoreMeTechDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreBookStoreMeTechDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolve the BookStoreMeTechDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<BookStoreMeTechDbContext>()
            .Database
            .MigrateAsync();
    }
}
