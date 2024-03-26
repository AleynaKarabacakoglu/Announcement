using Announcement.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp;

namespace Announcement.BacgroundJobs
{
    internal class AnnouncementJob
    {
        private readonly IAnnouncementService _announcementService;
        private static readonly Random random = new Random();

        public AnnouncementJob(IAnnouncementService announcementService)
        {
            _announcementService = announcementService;
        }
        public async Task CreateAnnonuncement()
        {
            await _announcementService.CreateAsync(GenerateAnnouncement());
        }
        public async Task DeleteAnnouncementsOlderThanOneDay()
        {
            await _announcementService.DeleteAnnouncementsOlderThanOneDay();
        }
        private static AnnouncementDto GenerateAnnouncement()
        {
            var title = GenerateRandomString(10);
            var content = GenerateRandomString(50);
            var createdDate = DateTime.Now.AddDays(-random.Next(1, 365));

            return new AnnouncementDto
            {
                Id = new Guid(),
                Title = title,
                Content = content,
                CreatedDate = createdDate
            };
        }

        private static string GenerateRandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
