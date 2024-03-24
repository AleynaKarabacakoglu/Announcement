using Volo.Abp.Modularity;

namespace Announcement;

/* Inherit from this class for your domain layer tests. */
public abstract class AnnouncementDomainTestBase<TStartupModule> : AnnouncementTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
