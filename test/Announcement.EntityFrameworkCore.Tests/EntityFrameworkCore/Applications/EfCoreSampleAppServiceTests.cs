using Announcement.Samples;
using Xunit;

namespace Announcement.EntityFrameworkCore.Applications;

[Collection(AnnouncementTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<AnnouncementEntityFrameworkCoreTestModule>
{

}
