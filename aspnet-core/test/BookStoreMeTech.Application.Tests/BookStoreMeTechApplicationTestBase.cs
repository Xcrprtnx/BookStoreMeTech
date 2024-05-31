using Volo.Abp.Modularity;

namespace BookStoreMeTech;

public abstract class BookStoreMeTechApplicationTestBase<TStartupModule> : BookStoreMeTechTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
