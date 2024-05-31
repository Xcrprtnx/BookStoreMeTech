using BookStoreMeTech.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace BookStoreMeTech.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(BookStoreMeTechEntityFrameworkCoreModule),
    typeof(BookStoreMeTechApplicationContractsModule)
    )]
public class BookStoreMeTechDbMigratorModule : AbpModule
{
}
