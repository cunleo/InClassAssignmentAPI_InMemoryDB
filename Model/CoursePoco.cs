﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CourseAPI.Model
{
    public class CoursePoco
    {
        public int Id { get; set; }
        [Required]
        public string CourseName { get; set; }


    }
}
