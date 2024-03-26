using Announcement.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace Announcement
{
    public interface IAnnouncementService : IApplicationService
    {
        Task<AnnouncementDto> CreateAsync(AnnouncementDto input);
        Task<List<AnnouncementDto>> GetListAsync();
        Task<AnnouncementDto> GetAsync(Guid id);
        Task DeleteAsync(Guid id);
        Task DeleteAnnouncementsOlderThanOneDay();
    }

}
