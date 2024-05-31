using BookStoreMeTech.Samples;
using Xunit;

namespace BookStoreMeTech.EntityFrameworkCore.Applications;

[Collection(BookStoreMeTechTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<BookStoreMeTechEntityFrameworkCoreTestModule>
{

}
