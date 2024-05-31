using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace BookStoreMeTech.Data;

/* This is used if database provider does't define
 * IBookStoreMeTechDbSchemaMigrator implementation.
 */
public class NullBookStoreMeTechDbSchemaMigrator : IBookStoreMeTechDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
