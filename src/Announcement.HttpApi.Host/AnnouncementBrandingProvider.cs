using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Announcement;

[Dependency(ReplaceServices = true)]
public class AnnouncementBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "Announcement";
}
