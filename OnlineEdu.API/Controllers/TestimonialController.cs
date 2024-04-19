using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineEdu.BusinessLayer.Abstract;
using OnlineEdu.DtoLayer.DTOs.SocialMediaDtos;
using OnlineEdu.DtoLayer.DTOs.TestimonialDtos;
using OnlineEdu.EntityLayer.Entities;

namespace OnlineEdu.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestimonialController(IGenericService<Testimonial> _testimonialService,IMapper _mapper) : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var values = _testimonialService.TGetList();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public IActionResult GetByID(int id)
        {
            var value = _testimonialService.TGetById(id);
            return Ok(value);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _testimonialService.TDelete(id);
            return Ok("Referans Alanı Silindi.");
        }
        [HttpPost]
        public IActionResult Creta(CreateTestimonialDto  createTestimonialDto)
        {
            var newValue = _mapper.Map<Testimonial>( createTestimonialDto);
            _testimonialService.TCreate(newValue);
            return Ok("Yeni Referans Alanı Oluşturuldu.");
        }
        [HttpPut]
        public IActionResult Update(UpdateTestimonialDto  updateTestimonialDto )
        {
            var value = _mapper.Map<Testimonial>( updateTestimonialDto);
            _testimonialService.TUpdate(value);
            return Ok("Referans Alanı Güncellendi.");
        }
    }
}
