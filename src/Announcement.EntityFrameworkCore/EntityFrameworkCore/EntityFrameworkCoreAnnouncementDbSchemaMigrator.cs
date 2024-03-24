using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Announcement.Data;
using Volo.Abp.DependencyInjection;

namespace Announcement.EntityFrameworkCore;

public class EntityFrameworkCoreAnnouncementDbSchemaMigrator
    : IAnnouncementDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreAnnouncementDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolve the AnnouncementDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<AnnouncementDbContext>()
            .Database
            .MigrateAsync();
    }
}
