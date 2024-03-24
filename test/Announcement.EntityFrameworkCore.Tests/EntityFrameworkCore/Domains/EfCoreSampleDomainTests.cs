using Announcement.Samples;
using Xunit;

namespace Announcement.EntityFrameworkCore.Domains;

[Collection(AnnouncementTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<AnnouncementEntityFrameworkCoreTestModule>
{

}
