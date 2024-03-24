using System;
using Volo.Abp.Application.Dtos;

namespace Announcement.DTOs
{
    public class AnnouncementDto:EntityDto<Guid>
    {
        public string? Title { get; set; }
        public string? Content { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
