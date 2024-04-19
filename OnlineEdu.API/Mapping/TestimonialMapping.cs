using AutoMapper;
using OnlineEdu.DtoLayer.DTOs.TestimonialDtos;
using OnlineEdu.EntityLayer.Entities;

namespace OnlineEdu.API.Mapping
{
    public class TestimonialMapping:Profile
    {
        public TestimonialMapping()
        {
            CreateMap<CreateTestimonialDto,Testimonial>().ReverseMap();
            CreateMap<UpdateTestimonialDto,Testimonial>().ReverseMap();
        }
    }
}
