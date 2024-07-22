﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace MyFirstBlazor.Shared
{
    public class Customer
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please provide a name")]
        public string Name { get; set; } = default!;

        [Required(ErrorMessage = "Please provide a street")]
        public string Street { get; set; } = default!;

        [Required(ErrorMessage = "Please provide a city")]
        public string City { get; set; } = default!;
    }
}