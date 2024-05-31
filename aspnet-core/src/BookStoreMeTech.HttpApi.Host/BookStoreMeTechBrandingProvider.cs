using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace BookStoreMeTech;

[Dependency(ReplaceServices = true)]
public class BookStoreMeTechBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "BookStoreMeTech";
}
