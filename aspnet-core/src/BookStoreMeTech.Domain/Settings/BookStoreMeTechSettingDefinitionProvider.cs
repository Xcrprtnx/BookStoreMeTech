using Volo.Abp.Settings;

namespace BookStoreMeTech.Settings;

public class BookStoreMeTechSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(BookStoreMeTechSettings.MySetting1));
    }
}
