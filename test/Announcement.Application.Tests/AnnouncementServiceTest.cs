using Announcement.DTOs;
using AutoMapper.Internal.Mappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Modularity;
using Xunit;

namespace Announcement
{
    public abstract class AnnouncementServiceTest<TStartupModule> : AnnouncementApplicationTestBase<TStartupModule>
    where TStartupModule : IAbpModule
    {
        private readonly IAnnouncementService _announcementService;

        protected AnnouncementServiceTest()
        {
            _announcementService = GetRequiredService<IAnnouncementService>();
        }

        [Fact]
        public async Task GetAsync_WithValidId_ShouldReturnAnnouncementDto()
        {
            var announcementId = Guid.NewGuid();

            var result = await _announcementService.GetAsync(announcementId);

            Assert.IsType<AnnouncementDto>(result);

        }
        [Fact]
        public async Task CreateAsync_ShouldReturnCreatedAnnouncementDto()
        {

            var announcementDto = new AnnouncementDto
            {
                Title = "Title",
                CreatedDate = DateTime.Now,
                Content = "Content"
            };

            var result = await _announcementService.CreateAsync(announcementDto);

            Assert.IsType<AnnouncementDto>(result);
        }

    }
}
