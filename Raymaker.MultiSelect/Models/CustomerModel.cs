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

        [BindProperty]
        [Required]
        public List<string> Toppings { get; set; }
    }
}
