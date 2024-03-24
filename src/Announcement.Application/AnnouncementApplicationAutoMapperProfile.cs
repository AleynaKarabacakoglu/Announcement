using Announcement.DTOs;
using AutoMapper;
using JetBrains.Annotations;

namespace Announcement;

public class AnnouncementApplicationAutoMapperProfile : Profile
{
    public AnnouncementApplicationAutoMapperProfile()
    {

        CreateMap<Announcement, AnnouncementDto>();
        CreateMap<AnnouncementDto, Announcement>();
    }
}
