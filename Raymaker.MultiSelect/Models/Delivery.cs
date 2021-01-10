using System;
using Microsoft.AspNetCore.Mvc;

namespace Raymaker.MultiSelect.Models
{
    public class Delivery
    {
        [BindProperty]
        public decimal Price { get; set; }
        public DateTime DeliveryDate { get; set; }
        public string Address { get; set; }
    }
}