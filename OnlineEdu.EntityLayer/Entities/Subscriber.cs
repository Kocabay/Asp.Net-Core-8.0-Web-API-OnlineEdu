﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineEdu.EntityLayer.Entities
{
    public class Subscriber
    {
        public int SubscriberID { get; set; }
        public string Email { get; set; }
        public bool IsActive { get; set; }
    }
}
