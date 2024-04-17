using AutoMapper;
using OnlineEdu.DtoLayer.DTOs.BannerDtos;
using OnlineEdu.EntityLayer.Entities;

namespace OnlineEdu.API.Mapping
{
    public class BannerMapping:Profile
    {
        public BannerMapping()
        {
            CreateMap<CreateBannerDto,Banner>().ReverseMap();
            CreateMap<UpdateBannerDto,Banner>().ReverseMap();
        }
    }
}
