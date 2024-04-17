using AutoMapper;
using OnlineEdu.DtoLayer.DTOs.BlogCategoryDtos;
using OnlineEdu.EntityLayer.Entities;

namespace OnlineEdu.API.Mapping
{
    public class BlogCategoryMapping:Profile
    {
        public BlogCategoryMapping()
        {
            CreateMap<CreateBlogCategoryDto,BlogCategory>().ReverseMap();
            CreateMap<UpdateBlogCategoryDto,BlogCategory>().ReverseMap();
            CreateMap<ResultBlogCategoryDto,BlogCategory>().ReverseMap();
        }
    }
}
