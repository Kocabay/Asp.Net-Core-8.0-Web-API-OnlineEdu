﻿using OnlineEdu.DtoLayer.DTOs.CourseCategoryDtos;
using OnlineEdu.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineEdu.DtoLayer.DTOs.CourseDtos
{
    public class ResultCourseDto
    {
        public int CourseID { get; set; }
        public string CourseName { get; set; }
        public string ImageUrl { get; set; }
        public int CourseCategoryID { get; set; }
        public ResultCourseCategoryDto ResultCourseCategoryDto { get; set; }
        public decimal Price { get; set; }
        public bool IsShown { get; set; }
    }
}
