using Volo.Abp.Modularity;

namespace Announcement;

[DependsOn(
    typeof(AnnouncementDomainModule),
    typeof(AnnouncementTestBaseModule)
)]
public class AnnouncementDomainTestModule : AbpModule
{

}
