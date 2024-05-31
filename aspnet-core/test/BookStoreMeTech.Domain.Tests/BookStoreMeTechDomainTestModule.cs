using Volo.Abp.Modularity;

namespace BookStoreMeTech;

[DependsOn(
    typeof(BookStoreMeTechDomainModule),
    typeof(BookStoreMeTechTestBaseModule)
)]
public class BookStoreMeTechDomainTestModule : AbpModule
{

}
