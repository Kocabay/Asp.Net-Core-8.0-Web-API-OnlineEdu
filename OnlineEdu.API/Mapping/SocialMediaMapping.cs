using AutoMapper;
using OnlineEdu.DtoLayer.DTOs.SocialMediaDtos;
using OnlineEdu.EntityLayer.Entities;

namespace OnlineEdu.API.Mapping
{
    public class SocialMediaMapping:Profile
    {
        public SocialMediaMapping()
        {
            CreateMap<CreateSocialMediaDto, SocialMedia>().ReverseMap(); 
            CreateMap<UpdateSocialMediaDto, SocialMedia>().ReverseMap();
        }
    }
}
