using Volo.Abp.Settings;

namespace Announcement.Settings;

public class AnnouncementSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(AnnouncementSettings.MySetting1));
    }
}
