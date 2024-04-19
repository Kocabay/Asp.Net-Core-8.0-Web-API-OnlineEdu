using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineEdu.BusinessLayer.Abstract;
using OnlineEdu.DtoLayer.DTOs.SocialMediaDtos;
using OnlineEdu.DtoLayer.DTOs.SubscriberDtos;
using OnlineEdu.EntityLayer.Entities;

namespace OnlineEdu.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubscribersController(IGenericService<Subscriber> _subscriberService,IMapper _mapper) : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var values = _subscriberService.TGetList();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public IActionResult GetByID(int id)
        {
            var value = _subscriberService.TGetById(id);
            return Ok(value);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _subscriberService.TDelete(id);
            return Ok("Abone Alanı Silindi.");
        }
        [HttpPost]
        public IActionResult Creta(CreateSubscriberDto  createSubscriberDto)
        {
            var newValue = _mapper.Map<Subscriber>( createSubscriberDto);
            _subscriberService.TCreate(newValue);
            return Ok("Yeni Abone Alanı Oluşturuldu.");
        }
        [HttpPut]
        public IActionResult Update(UpdateSubscriberDto  updateSubscriberDto)
        {
            var value = _mapper.Map<Subscriber>( updateSubscriberDto);
            _subscriberService.TUpdate(value);
            return Ok("Abone Alanı Güncellendi.");
        }
    }
}
