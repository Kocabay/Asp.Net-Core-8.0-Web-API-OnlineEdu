using AutoMapper;
using OnlineEdu.DtoLayer.DTOs.AboutDtos;
using OnlineEdu.EntityLayer.Entities;

namespace OnlineEdu.API.Mapping
{
	public class AboutMapping:Profile
	{
        public AboutMapping()
        {
            CreateMap<CreateAboutDto,About>().ReverseMap();
            CreateMap<UpdateAboutDto,About>().ReverseMap();
		}
    }
}
