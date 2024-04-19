using AutoMapper;
using OnlineEdu.DtoLayer.DTOs.SubscriberDtos;
using OnlineEdu.EntityLayer.Entities;

namespace OnlineEdu.API.Mapping
{
    public class SubscribeMapping:Profile
    {
        public SubscribeMapping()
        {
            CreateMap<CreateSubscriberDto,Subscriber>().ReverseMap();
            CreateMap<UpdateSubscriberDto,Subscriber>().ReverseMap();
        }
    }
}
