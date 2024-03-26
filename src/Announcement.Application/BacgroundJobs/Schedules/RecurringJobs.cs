using Hangfire;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Announcement.BacgroundJobs.Schedules
{
    public static class RecurringJobs
    {
        public static void ScheduleCreateAnnouncementJob()
        {
            const string createAnnouncementJob = nameof(createAnnouncementJob);
            RecurringJob.AddOrUpdate<AnnouncementJob>(createAnnouncementJob, x => x.CreateAnnonuncement(), Cron.Hourly(1));
        }
        public static void ScheduleDeleteAnnouncementJob()
        {
            const string deleteAnnouncementJob = nameof(deleteAnnouncementJob);
            RecurringJob.AddOrUpdate<AnnouncementJob>(deleteAnnouncementJob, x => x.DeleteAnnouncementsOlderThanOneDay(), Cron.Hourly(1));
        }
    }
}
