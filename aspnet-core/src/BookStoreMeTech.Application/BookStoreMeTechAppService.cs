using System;
using System.Collections.Generic;
using System.Text;
using BookStoreMeTech.Localization;
using Volo.Abp.Application.Services;

namespace BookStoreMeTech;

/* Inherit your application services from this class.
 */
public abstract class BookStoreMeTechAppService : ApplicationService
{
    protected BookStoreMeTechAppService()
    {
        LocalizationResource = typeof(BookStoreMeTechResource);
    }
}
