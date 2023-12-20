using Volo.Abp.Settings;

namespace OrgDoc.Settings;

public class OrgDocSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(OrgDocSettings.MySetting1));
    }
}
