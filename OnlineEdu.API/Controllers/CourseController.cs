using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineEdu.BusinessLayer.Abstract;
using OnlineEdu.DtoLayer.DTOs.AboutDtos;
using OnlineEdu.DtoLayer.DTOs.CourseDtos;
using OnlineEdu.EntityLayer.Entities;

namespace OnlineEdu.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController(IGenericService<Course> _courseService ,IMapper _mapper) : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var values = _courseService.TGetList();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public IActionResult GetByID(int id)
        {
            var value = _courseService.TGetById(id);
            return Ok(value);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _courseService.TDelete(id);
            return Ok("Kurs Alanı Silindi.");
        }
        [HttpPost]
        public IActionResult Creta(CreateCourseDto  createCourseDto)
        {
            var newValue = _mapper.Map<Course>(createCourseDto);
            _courseService.TCreate(newValue);
            return Ok("Yeni Kurs Alanı Oluşturuldu.");
        }
        [HttpPut]
        public IActionResult Update(UpdateCourseDto  updateCourseDto)
        {
            var value = _mapper.Map<Course>(updateCourseDto );
            _courseService.TUpdate(value);
            return Ok("Kurs Alanı Güncellendi.");
        }
    }
}
