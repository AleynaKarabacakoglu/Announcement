using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Announcement.Data;

/* This is used if database provider does't define
 * IAnnouncementDbSchemaMigrator implementation.
 */
public class NullAnnouncementDbSchemaMigrator : IAnnouncementDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
