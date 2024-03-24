using Announcement.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace Announcement.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(AnnouncementEntityFrameworkCoreModule),
    typeof(AnnouncementApplicationContractsModule)
    )]
public class AnnouncementDbMigratorModule : AbpModule
{
}
