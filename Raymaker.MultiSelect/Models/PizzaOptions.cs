using System.Collections.Generic;

namespace Raymaker.MultiSelect.Models
{
    public class PizzaOptions
    {
        public List<string> Toppings { get; set;}
        public Delivery Delivery { get; set; }
    }
}