﻿ 
 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineEdu.WebUI.DTOs.BlogCategoryDtos
{
    public class UpdateBlogCategoryDto
    {
        public int BlogCategoryID { get; set; }
        public string Name { get; set; }
        //public List<ResultBlogDto> Blogs { get; set; }
    }
}
