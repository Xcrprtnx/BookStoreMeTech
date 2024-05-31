using System.Threading.Tasks;

namespace BookStoreMeTech.Data;

public interface IBookStoreMeTechDbSchemaMigrator
{
    Task MigrateAsync();
}
