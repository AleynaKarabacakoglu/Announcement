using Announcement.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Announcement.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class AnnouncementController : AbpControllerBase
{
    protected AnnouncementController()
    {
        LocalizationResource = typeof(AnnouncementResource);
    }
}
