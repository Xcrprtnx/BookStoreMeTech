using BookStoreMeTech.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace BookStoreMeTech.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class BookStoreMeTechController : AbpControllerBase
{
    protected BookStoreMeTechController()
    {
        LocalizationResource = typeof(BookStoreMeTechResource);
    }
}
