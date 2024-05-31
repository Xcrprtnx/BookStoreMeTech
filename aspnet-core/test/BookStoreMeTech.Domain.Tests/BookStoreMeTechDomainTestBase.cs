using Volo.Abp.Modularity;

namespace BookStoreMeTech;

/* Inherit from this class for your domain layer tests. */
public abstract class BookStoreMeTechDomainTestBase<TStartupModule> : BookStoreMeTechTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
