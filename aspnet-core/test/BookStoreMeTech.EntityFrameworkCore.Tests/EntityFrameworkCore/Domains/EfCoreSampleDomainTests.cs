using BookStoreMeTech.Samples;
using Xunit;

namespace BookStoreMeTech.EntityFrameworkCore.Domains;

[Collection(BookStoreMeTechTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<BookStoreMeTechEntityFrameworkCoreTestModule>
{

}
