﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Products.Api.DTO
{
    public class ProductCreateInputModel
    {
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        [Required]
        public decimal? Price { get; set; }
    }
}
