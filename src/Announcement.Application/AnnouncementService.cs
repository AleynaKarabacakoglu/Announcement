using Announcement.DTOs;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Announcement
{
    public class AnnouncementService : ApplicationService, IAnnouncementService
    {
        private readonly IRepository<Announcement, Guid> _announcementRepository;
        public AnnouncementService(IRepository<Announcement, Guid> announcementRepository)
        {
            _announcementRepository = announcementRepository;
        }
        public async Task<AnnouncementDto> CreateAsync(AnnouncementDto input)
        {
            var existingAnnouncement = await _announcementRepository.FirstOrDefaultAsync(x => x.Id == input.Id);
            if (existingAnnouncement != null)
            {
                throw new UserFriendlyException("Announcement with this id already exists.");
            }

            var announcement = ObjectMapper.Map<AnnouncementDto, Announcement>(input);
            var response = await _announcementRepository.InsertAsync(announcement);

            return ObjectMapper.Map<Announcement, AnnouncementDto>(response);
        }

        public async Task<AnnouncementDto> GetAsync(Guid id)
        {
            var announcement = await _announcementRepository.GetAsync(id);

            return ObjectMapper.Map<Announcement, AnnouncementDto>(announcement);
        }

        public async Task<List<AnnouncementDto>> GetListAsync()
        {
            var announcements = await _announcementRepository.GetListAsync();

            return ObjectMapper.Map<List<Announcement>, List<AnnouncementDto>>(announcements);
        }
        public async Task DeleteAsync(Guid id)
        {
            var existingAnnouncement = await _announcementRepository.FirstOrDefaultAsync(x => x.Id == id);
            if (existingAnnouncement == null)
            {
                throw new UserFriendlyException("No announcements with this ID were found.");
            }
            await _announcementRepository.DeleteAsync(id);
        }

        [RemoteService(IsEnabled = false)]
        public async Task DeleteAnnouncementsOlderThanOneDay()
        {
            await _announcementRepository.DeleteDirectAsync(x => x.CreatedDate <= DateTime.Now.AddDays(-1));
        }
       
    }
}
