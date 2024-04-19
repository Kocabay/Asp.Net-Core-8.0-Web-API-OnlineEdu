using AutoMapper;
using OnlineEdu.DtoLayer.DTOs.MessageDtos;
using OnlineEdu.EntityLayer.Entities;

namespace OnlineEdu.API.Mapping
{
    public class MessageMapping:Profile
    {
        public MessageMapping()
        {
            CreateMap<CreateMessageDto, Message>().ReverseMap();
            CreateMap<UpdateMessageDto, Message>().ReverseMap();
        }
    }
}
