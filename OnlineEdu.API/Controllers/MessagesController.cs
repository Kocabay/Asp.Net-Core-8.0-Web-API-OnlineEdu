using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineEdu.BusinessLayer.Abstract;
using OnlineEdu.DtoLayer.DTOs.AboutDtos;
using OnlineEdu.DtoLayer.DTOs.MessageDtos;
using OnlineEdu.EntityLayer.Entities;

namespace OnlineEdu.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessagesController(IGenericService<Message> _messageService, IMapper _mapper) : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var values = _messageService.TGetList();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public IActionResult GetByID(int id)
        {
            var value = _messageService.TGetById(id);
            return Ok(value);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _messageService.TDelete(id);
            return Ok("Mesaj Alanı Silindi.");
        }
        [HttpPost]
        public IActionResult Creta(CreateMessageDto createMessageDto)
        {
            var newValue = _mapper.Map<Message>(createMessageDto);
            _messageService.TCreate(newValue);
            return Ok("Yeni Mesaj Alanı Oluşturuldu.");
        }
        [HttpPut]
        public IActionResult Update(UpdateMessageDto updateMessageDto)
        {
            var value = _mapper.Map<Message>(updateMessageDto);
            _messageService.TUpdate(value);
            return Ok("Mesaj Alanı Güncellendi.");
        }
    }
}
