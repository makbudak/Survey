﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorLearn.Models.Entities
{
    public class User : BaseEntity
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }
        public bool Deleted { get; set; }
    }
}
