using AutoMapper;
using OnlineEdu.DtoLayer.DTOs.ContactDtos;
using OnlineEdu.EntityLayer.Entities;

namespace OnlineEdu.API.Mapping
{
    public class ContactMapping:    Profile
    {
        public ContactMapping()
        {
            CreateMap<CreateContactDto,Contact>().ReverseMap();
            CreateMap<UpdateContactDto,Contact>().ReverseMap();
        }
    }
}
