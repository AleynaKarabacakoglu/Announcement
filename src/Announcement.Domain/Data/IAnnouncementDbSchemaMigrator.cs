using System.Threading.Tasks;

namespace Announcement.Data;

public interface IAnnouncementDbSchemaMigrator
{
    Task MigrateAsync();
}
