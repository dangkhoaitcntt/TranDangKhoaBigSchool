﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BigSchool_1611060152.Models
{
    public class Category
    {
        public byte Id { get; set; }
        [Required]
        [StringLength(225)]
        public string Name { get; set; }
    }
}