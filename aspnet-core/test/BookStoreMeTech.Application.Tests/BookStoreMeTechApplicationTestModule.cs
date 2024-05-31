using Volo.Abp.Modularity;

namespace BookStoreMeTech;

[DependsOn(
    typeof(BookStoreMeTechApplicationModule),
    typeof(BookStoreMeTechDomainTestModule)
)]
public class BookStoreMeTechApplicationTestModule : AbpModule
{

}
