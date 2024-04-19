﻿using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineEdu.BusinessLayer.Abstract;
using OnlineEdu.DtoLayer.DTOs.MessageDtos;
using OnlineEdu.DtoLayer.DTOs.SocialMediaDtos;
using OnlineEdu.EntityLayer.Entities;

namespace OnlineEdu.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SocialMediasController(IGenericService<SocialMedia>_socialMediaService, IMapper _mapper) : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var values = _socialMediaService.TGetList();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public IActionResult GetByID(int id)
        {
            var value = _socialMediaService.TGetById(id);
            return Ok(value);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _socialMediaService.TDelete(id);
            return Ok("Sosyal Medya Alanı Silindi.");
        }
        [HttpPost]
        public IActionResult Creta(CreateSocialMediaDto  createSocialMediaDto)
        {
            var newValue = _mapper.Map<SocialMedia>( createSocialMediaDto);
            _socialMediaService.TCreate(newValue);
            return Ok("Yeni Sosyal Medya Alanı Oluşturuldu.");
        }
        [HttpPut]
        public IActionResult Update(UpdateSocialMediaDto  updateSocialMediaDto)
        {
            var value = _mapper.Map<SocialMedia>( updateSocialMediaDto);
            _socialMediaService.TUpdate(value);
            return Ok("Sosyal Medya Alanı Güncellendi.");
        }
    }
}
