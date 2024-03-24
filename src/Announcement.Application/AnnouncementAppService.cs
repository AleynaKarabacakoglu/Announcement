using System;
using System.Collections.Generic;
using System.Text;
using Announcement.Localization;
using Volo.Abp.Application.Services;

namespace Announcement;

/* Inherit your application services from this class.
 */
public abstract class AnnouncementAppService : ApplicationService
{
    protected AnnouncementAppService()
    {
        LocalizationResource = typeof(AnnouncementResource);
    }
}
