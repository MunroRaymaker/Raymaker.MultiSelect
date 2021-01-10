using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace Raymaker.MultiSelect.Models
{
    public class CustomerModel
    {
        [BindProperty]
        [Required]
        public string CustomerName { get; set; }

        [BindProperty, DataType(DataType.Date)]
        [DisplayFormat(DataFormatString="{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime BirthDate { get; set; }

        [BindProperty]
        [Required]
        public List<string> Toppings { get; set; }
    }
}
