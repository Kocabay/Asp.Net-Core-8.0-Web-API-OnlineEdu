﻿using OnlineEdu.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineEdu.DtoLayer.DTOs.CourseCategoryDtos
{
    public class ResultCourseCategoryDto
    {
        public int CourseCategoryID { get; set; }
        public string Name { get; set; }
        public string Icon { get; set; }
        public string Description { get; set; }
        public bool IsShown { get; set; }
        public List<Course> Courses { get; set; }
    }
}
