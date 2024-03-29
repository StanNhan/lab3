﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace lab3.Models
{
    public class Category
    {
        public byte Id { get; set; }
        [required]
        [StringLength(255)]
        public string Name { get; set; }
    }
}