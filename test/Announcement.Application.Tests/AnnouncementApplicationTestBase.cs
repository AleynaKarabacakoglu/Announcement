using Volo.Abp.Modularity;

namespace Announcement;

public abstract class AnnouncementApplicationTestBase<TStartupModule> : AnnouncementTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
