using AutoMapper;
using OnlineEdu.DtoLayer.DTOs.CourseDtos;
using OnlineEdu.EntityLayer.Entities;

namespace OnlineEdu.API.Mapping
{
    public class CourseMapping:Profile
    {
        public CourseMapping()
        {
            CreateMap<CreateCourseDto, Course> ().ReverseMap();
            CreateMap<UpdateCourseDto, Course> ().ReverseMap();
            CreateMap<ResultCourseDto, Course> ().ReverseMap();
        }
    }
}
