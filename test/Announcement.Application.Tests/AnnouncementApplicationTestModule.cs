using Volo.Abp.Modularity;

namespace Announcement;

[DependsOn(
    typeof(AnnouncementApplicationModule),
    typeof(AnnouncementDomainTestModule)
)]
public class AnnouncementApplicationTestModule : AbpModule
{

}
