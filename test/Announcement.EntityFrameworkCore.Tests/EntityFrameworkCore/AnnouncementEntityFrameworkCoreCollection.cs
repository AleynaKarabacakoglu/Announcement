using Xunit;

namespace Announcement.EntityFrameworkCore;

[CollectionDefinition(AnnouncementTestConsts.CollectionDefinitionName)]
public class AnnouncementEntityFrameworkCoreCollection : ICollectionFixture<AnnouncementEntityFrameworkCoreFixture>
{

}
